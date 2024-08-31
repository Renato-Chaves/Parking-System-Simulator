using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System_Simulator.Core
{
    internal class Car
    {
        private string _carName;
        private string _carColor;
        private int [] _carLane;
        private string _carPlate;
        private string _carImage;
        private string _carEntryTime;

        public Car(string carName, string carColor, int[] carLane, string carPlate, string carEntryTime, string carImage)
        {
            _carName = carName;
            _carColor = carColor;
            _carLane = carLane;
            _carPlate = carPlate;
            _carEntryTime = carEntryTime;
            _carImage = carImage;
        }

        public string GetCarName()
        {
            return _carName;
        }

        public string GetCarColor()
        {
            return _carColor;
        }

        public int[] GetCarLane()
        {
            return _carLane;
        }
        
        public string GetCarPlate()
        {
            return _carPlate;
        }

        public string GetEntryTime()
        {
            return _carEntryTime;
        }

        public string GetCarImage()
        {
            return _carImage;
        }

    }
}
