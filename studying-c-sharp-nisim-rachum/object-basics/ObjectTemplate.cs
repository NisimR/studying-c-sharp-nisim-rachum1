using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_nisim_rachum.object_basics
{
    public class ObjectTemplate
    {
        public int intProperty = 10;

        public bool boolProperty = false;

        public string stringProperty = "some string";

        public void ToggleBoolProperty()
        {
            boolProperty = !boolProperty;

        }
        public void Add10()
        {
            intProperty = intProperty + 10;
        }      
    }

    public class Car
    {
        public string model = "";
        public string color = "";
        public int carNum = 0;
        public bool isFix = false;

        public string [] breakdowns = new string[10];
        public int numOfBreakdowns = 0;

        public Car (string model, string color, int carNum, bool isFix)
        {
            this.model = model;
            this.color = color;
            this.carNum = carNum;
            this.isFix = isFix;
            
        }

        public void AddBreakdown (string s) {

            this.breakdowns[numOfBreakdowns] = s;
            numOfBreakdowns++;
        
        }
        public void FixCar ()
        {
            isFix = true;
        }
    }

    public class Garage
    {
        public string name = "";
        public string city = "";
        public string activityTime = "";

        public int numOfCars = 0;
        public int maxCars = 20;
        public Car[] cars;

        public Garage(string name, string city, int numOfCars, int maxCars, Car[] cars, string activityTime)
        {
            this.name = name;
            this.city = city;
            this.numOfCars = numOfCars;
            this.maxCars = maxCars;
            this.cars = new Car[maxCars];
            this.activityTime = activityTime;
        }
    }

    public class GarageChain
    {
        public string activityTime = "07:00 - 17:00";
        public Garage[] garages = new Garage[10];

        public void StatusGarages()
        {
             
            for (int i = 0; i < garages.Length; i++)
            {
                Console.WriteLine("Garage name: {0}, Max Cars: {1}, Nums Cars: {2} " , garages[i].name, garages[i].maxCars, garages[i].numOfCars);
            }

            
        }
    }

    public class TestBasicObject
    {
        public static void Demo()
        { 
            ObjectTemplate template1 = new ObjectTemplate();

            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                               , template1.intProperty, template1.stringProperty, template1.boolProperty);

            template1.ToggleBoolProperty();
            template1.Add10();

            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                                , template1.intProperty, template1.stringProperty, template1.boolProperty);

            ObjectTemplate template2 = new ObjectTemplate();

            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                                , template2.intProperty, template2.stringProperty, template2.boolProperty);


            
        }
    }
}
