using Parking_System_Simulator.Core;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Parking_System_Simulator
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        CarManager carManager;
        Image[,] imageSlots;
        int[] selectedCarIndex = new int[2] {-1, -1};
        DateTime curTime = new DateTime(2024, 07, 21, 12, 00, 00);
        int baseCost = 3;
        int hourlyCost = 2;

        public MainWindow()
        {
            InitializeComponent();
            imageSlots = new Image[2, 6] { { A1Img, A2Img, A3Img, A4Img, A5Img, A6Img }, { B1Img, B2Img, B3Img, B4Img, B5Img, B6Img } };
            carManager = new CarManager();
            UpdateTimeTB();
            UpdateCarInfoUI(new int[] { selectedCarIndex[0], selectedCarIndex[1]});
        }

        private void AddCarBtn_Click(object sender, RoutedEventArgs e)
        {
            carManager.NewCar(curTime);
            selectedCarIndex[0] = carManager.GetNewestCar().GetCarLane()[0];
            selectedCarIndex[1] = carManager.GetNewestCar().GetCarLane()[1];
            UpdateSelectedBorder();
            UpdateCarInfoUI(new int[]{carManager.GetNewestCar().GetCarLane()[0], carManager.GetNewestCar().GetCarLane()[1]});
        }

        private void UpdateCarInfoUI(int[] carIndex)
        {
            if (carIndex[0] == -1)
            {
                selectCarTitle.Text = "Select a Car...";
                carNameTB.Text = "...";
                carColorTB.Text = "...";
                carLaneTB.Text = "...";
                carPlateTB.Text = "...";
                entryTimeTB.Text = "...";
                elapsedTimeTB.Text = "...";
                currentCostTB.Text = "$...";
                paymentBtn.Content = "...";
                carImage.Source = null;
                return;
            }

            Car car = carManager.GetCar(carIndex[0], carIndex[1]);

            string carLaneTxt;
            if (car.GetCarLane()[0] == 0) carLaneTxt = "A" + (car.GetCarLane()[1] + 1).ToString();
            else carLaneTxt = "B" + (car.GetCarLane()[1] + 1).ToString();

            selectCarTitle.Text = "Selected Car";
            paymentBtn.Content = "Pay and Leave";
            carNameTB.Text = car.GetCarName();
            carColorTB.Text = car.GetCarColor();
            carLaneTB.Text = carLaneTxt;
            carPlateTB.Text = car.GetCarPlate();
            entryTimeTB.Text = car.GetEntryTime().ToString("HH:mm");

            TimeSpan timeDiff = curTime.Subtract(car.GetEntryTime());
            elapsedTimeTB.Text = timeDiff.Days+"d "+timeDiff.Hours+"h "+timeDiff.Minutes+"m";

            currentCostTB.Text = "$"+(baseCost + (hourlyCost * (int)timeDiff.TotalHours)).ToString();

            carImage.Source = new BitmapImage(new Uri(car.GetCarImage(), UriKind.Relative));
            imageSlots[car.GetCarLane()[0], car.GetCarLane()[1]].Source = new BitmapImage(new Uri(car.GetCarImage(), UriKind.Relative));
        }

        private void CarImg_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            //Get which position was selected
            Border border = (Border)sender;
            Image selectedImage = (Image)border.Child;
            if(selectedImage.Source == null) return;

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if (imageSlots[i, j].Equals(selectedImage))
                    {
                        //MessageBox.Show(i + " | " + j);
                        selectedCarIndex[0] = i;
                        selectedCarIndex[1] = j;
                        break;
                    }
                }
            }

            UpdateSelectedBorder();
            UpdateCarInfoUI(new int[] { selectedCarIndex[0], selectedCarIndex[1] });
        }

        private void UpdateSelectedBorder()
        {
            ResetBorderBrushes();
            if (selectedCarIndex[0] == -1) return;
            Border border = (Border)imageSlots[selectedCarIndex[0], selectedCarIndex[1]].Parent;
            border.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#BED6D9");
        }

        private void ResetBorderBrushes()
        {
            foreach(Image image in imageSlots)
            {
                Border border = (Border)image.Parent;
                if(border.BorderBrush != Brushes.Transparent) border.BorderBrush = Brushes.Transparent;
            }
        }

        private void TimeBtn_Click(object sender, RoutedEventArgs e)
        {
            Button pressedBtn = sender as Button;
            switch (pressedBtn.Name)
            {
                case "addMinuteBtn":
                    AddCurTime(10);
                    break;
                case "addHourBtn":
                    AddCurTime(60);
                    break;
                case "subMinuteBtn":
                    AddCurTime(-10);
                    TimeTravelerCheck();
                    break;
                case "subHourBtn":
                    AddCurTime(-60);
                    TimeTravelerCheck();
                    break;
            }
        }

        private void PaymentBtn_Click(object sender, RoutedEventArgs e)
        {
            if (selectedCarIndex[0] == -1) return;
            RemoveCar(new int[] { selectedCarIndex[0], selectedCarIndex[1] });
        }

        private void RemoveCar(int[] carIndex)
        {
            carManager.RemoveCar(carIndex);
            imageSlots[carIndex[0], carIndex[1]].Source = null;
            selectedCarIndex[0] = -1;
            selectedCarIndex[1] = -1;
            UpdateCarInfoUI(new int[] { selectedCarIndex[0], selectedCarIndex[1] });
            ResetBorderBrushes();
        }

        private void TimeTravelerCheck()
        {
            foreach(Car car in carManager.GetCurCars())
            {
                if(curTime.CompareTo(car.GetEntryTime()) < 0) RemoveCar(car.GetCarLane());
            }
        }

        private void AddCurTime(int minutes)
        {
            curTime = curTime.AddMinutes(minutes);
            UpdateTimeTB();
            UpdateCarInfoUI(new int[] { selectedCarIndex[0], selectedCarIndex[1] });
        }

        private void UpdateTimeTB()
        {
            timeTB.Text = curTime.ToString("HH:mm");
            if(curTime.Hour >= 0 && curTime.Hour < 6)
            {
                DateTime time = curTime;
                double hour = time.Hour;
                double opacity = (0.5 - (hour / 10));
                shadowLayer.Opacity = opacity;
            }
            else if(curTime.Hour > 18)
            {
                DateTime time = curTime.AddHours(-18);
                double hour = time.Hour;
                double opacity = (0.0 + (hour / 10));
                shadowLayer.Opacity = opacity;
            }
            else
            {
                shadowLayer.Opacity = 0;
            }
        }
    }
}
