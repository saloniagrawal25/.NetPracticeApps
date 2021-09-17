using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Vehicle
    {
        string _regNum;
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is initialized");
        //} 
        public Vehicle(string regNum)
        {
            this._regNum = regNum;
            Console.WriteLine("Vehicle is initialized, {0}", regNum);
        }
    }

    public class Car : Vehicle
    {
        public Car(string regNum) : base (regNum)
        {
            Console.WriteLine("Car is initialized, {0}", regNum);
        }

    }
}
