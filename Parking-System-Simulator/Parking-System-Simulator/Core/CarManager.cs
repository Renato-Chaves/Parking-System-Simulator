using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace Parking_System_Simulator.Core
{
    internal class CarManager
    {

        Car[,] cars = new Car[2,6];
        Car _newestCar;

        public void NewCar(DateTime entryTime)
        {
            //Counts if there are any free parking spaces remaining
            int freeSlotsCount = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (cars[i, j] == null)
                    {
                        freeSlotsCount++;
                    }
                }
            }

            //Returns functions if there are no more spaces for new cars
            if (freeSlotsCount <= 0)
            {
                MessageBox.Show("No more space to add more cars");
                return;
            }

            Car car = new Car("Audi", "Red", new int[]{0,4}, GenerateRandomPlate(), entryTime, "/Images/Cars/Audi.png");
            int [] freeSlot = GetRandomFreeSlot();

            switch (new Random().Next(1,10))
            {
                case 1:
                    car = new Car("Audi", "Red", new int[] { freeSlot[0], freeSlot[1] }, GenerateRandomPlate(), entryTime, "/Images/Cars/Audi.png");
                    break;
                case 2:
                    car = new Car("Dodge", "Orange", new int[] { freeSlot[0], freeSlot[1] }, GenerateRandomPlate(), entryTime, "/Images/Cars/Dodge.png");
                    break;
                case 3:
                    car = new Car("Black Viper", "Black", new int[] { freeSlot[0], freeSlot[1] }, GenerateRandomPlate(), entryTime, "/Images/Cars/Black_Viper.png");
                    break;
                case 4:
                    car = new Car("Ambulance", "White", new int[] { freeSlot[0], freeSlot[1] }, GenerateRandomPlate(), entryTime, "/Images/Cars/Ambulance.png");
                    break;
                case 5:
                    car = new Car("Mini Truck", "Blue", new int[] { freeSlot[0], freeSlot[1] }, GenerateRandomPlate(), entryTime, "/Images/Cars/Mini_Truck.png");
                    break;
                case 6:
                    car = new Car("Mini Van", "White", new int[] { freeSlot[0], freeSlot[1] }, GenerateRandomPlate(), entryTime, "/Images/Cars/Mini_Van.png");
                    break;
                case 7:
                    car = new Car("Police", "Black", new int[] { freeSlot[0], freeSlot[1] }, GenerateRandomPlate(), entryTime, "/Images/Cars/Police.png");
                    break;
                case 8:
                    car = new Car("Taxi", "Yellow", new int[] { freeSlot[0], freeSlot[1] }, GenerateRandomPlate(), entryTime, "/Images/Cars/Taxi.png");
                    break;
                case 9:
                    car = new Car("Truck", "White", new int[] { freeSlot[0], freeSlot[1] }, GenerateRandomPlate(), entryTime, "/Images/Cars/Truck.png");
                    break;
            }

            //MessageBox.Show("FreeSlot: [" + freeSlot[0] + ", " + freeSlot[1] + "]");
            cars[freeSlot[0], freeSlot[1]] = car;
            _newestCar = car;
        }

        public Car GetCar(int indexX, int indexY)
        {
            return cars[indexX, indexY];
        }

        public Car GetNewestCar()
        {
            return _newestCar;
        }

        public Car[] GetCurCars()
        {
            Car[] curCars;
            int curCarCount = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (cars[i, j] != null)
                    {
                        curCarCount++;
                    }
                }
            }

            curCars = new Car[curCarCount];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (cars[i, j] != null)
                    {
                        for (int k = 0; k < curCars.Length; k++)
                        {
                            if (curCars[k] == null)
                            {
                                curCars[k] = cars[i, j];
                                break;
                            }
                        }
                    }
                }
            }

            string debugString = "\n";
            for (int i = 0; i < curCars.Length; i++)
            {
                debugString += "[";
                debugString += curCars[i].GetCarLane()[0] + ", "+ curCars[i].GetCarLane()[1];
                debugString += "]";
            }
            //MessageBox.Show("Current Car Count: " + curCarCount.ToString() + "\nUsed Slots: " + debugString);
            return curCars;
        }

        public void RemoveCar(int[] carIndex)
        {
            cars[carIndex[0], carIndex[1]] = null;
        }

        private string GenerateRandomPlate()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "123456789";
            string plate = "";
            Random rng = new Random();

            for(int i = 0; i<7; i++)
            {
                if(i < 3 || i == 4) plate += alphabet[rng.Next(alphabet.Length)];
                else if(i == 3 || i > 4) plate += numbers[rng.Next(numbers.Length)];
            }

            return plate;
        }

        private int[] GetRandomFreeSlot()
        {
            int[,] freeSlotLocation = new int[12, 2];
            int freeSlotsCount = 0;

            //Clear freeSlotLocation
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    freeSlotLocation[i, j] = -1;
                }
            }
            //Counts and store free slots
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if(cars[i, j] == null)
                    {
                        freeSlotsCount++;
                        for (int k = 0; k < 12; k++)
                        {
                            if(freeSlotLocation[k, 0] == -1)
                            {
                                freeSlotLocation[k, 0] = i;
                                freeSlotLocation[k, 1] = j;
                                break;
                            }
                        }
                    }
                }
            }

            string debugString = "\n";
            for (int i = 0; i < 12; i++)
            {
                debugString += "[";
                for (int j = 0; j < 2; j++)
                {
                    debugString += freeSlotLocation[i, j].ToString() + " ";

                }
                debugString += "]\n";
            }
            //MessageBox.Show("Free Slots Count: " + freeSlotsCount.ToString() + "\nFree Slots: " + debugString);

            int randomIndex = new Random().Next(0, freeSlotsCount);
            int[] freeSlotIndex = { freeSlotLocation[randomIndex, 0] , freeSlotLocation[randomIndex, 1] };
            return freeSlotIndex;
        }
    }
}