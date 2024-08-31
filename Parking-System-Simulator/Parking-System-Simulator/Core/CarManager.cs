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

        public void NewCar()
        {

            Car car = new Car("Audi", "Red", new int[]{0,4}, "EWK-8995", "13:05", "/Images/Cars/Audi.png");
            int [] freeSlot = GetRandomFreeSlot();

            switch (new Random().Next(1,4))
            {
                case 1:
                    car = new Car("Audi", "Red", new int[] { freeSlot[0], freeSlot[1] }, "EWK-8995", "13:05", "/Images/Cars/Audi.png");
                    break;
                case 2:
                    car = new Car("Dodge", "Orange", new int[] { freeSlot[0], freeSlot[1] }, "EWK-8995", "13:05", "/Images/Cars/Dodge.png");
                    break;
                case 3:
                    car = new Car("Black Viper", "Black", new int[] { freeSlot[0], freeSlot[1] }, "EWK-8995", "13:05", "/Images/Cars/Black_Viper.png");
                    break;
            }


            cars[freeSlot[0], freeSlot[1]] = car;
        }

        public Car GetCar(int indexX, int indexY)
        {
            return cars[indexX, indexY];
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
            MessageBox.Show("Current Car Count: " + curCarCount.ToString() + "\nUsed Slots: " + debugString);
            return curCars;
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
            MessageBox.Show("Free Slots Count: " + freeSlotsCount.ToString() + "\nFree Slots: " + debugString);

            int randomIndex = new Random().Next(1, freeSlotsCount + 1);
            int[] freeSlotIndex = { freeSlotLocation[randomIndex, 0] , freeSlotLocation[randomIndex, 1] };
            return freeSlotIndex;
        }
    }
}