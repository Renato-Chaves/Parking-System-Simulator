using Parking_System_Simulator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parking_System_Simulator
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        CarManager carManager;
        Image[,] imageSlots;
        public MainWindow()
        {
            InitializeComponent();
            imageSlots = new Image[2, 6] { { A1Img, A2Img, A3Img, A4Img, A5Img, A6Img }, { B1Img, B2Img, B3Img, B4Img, B5Img, B6Img } };
            carManager = new CarManager();
        }

        private void AddCarBtn_Click(object sender, RoutedEventArgs e)
        {
            carManager.NewCar();
            foreach(Car car in carManager.GetCurCars())
            {
                string carLaneTxt;
                if (car.GetCarLane()[0] == 0) carLaneTxt = "A" + car.GetCarLane()[1].ToString();
                else carLaneTxt = "B" + car.GetCarLane()[1].ToString();

                carNameTB.Text = car.GetCarName();
                carColorTB.Text = car.GetCarColor();
                carLaneTB.Text = carLaneTxt;
                carPlateTB.Text = car.GetCarPlate();
                entryTimeTB.Text = car.GetEntryTime();
                carImage.Source = new BitmapImage(new Uri(car.GetCarImage(), UriKind.Relative));
                imageSlots[car.GetCarLane()[0], car.GetCarLane()[1]].Source = new BitmapImage(new Uri(car.GetCarImage(), UriKind.Relative));
            }
            //Car car = carManager.GetCar(1, 3); 

        }
    }
}
