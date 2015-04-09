using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array
            string[] food = new string[10];
            string[] foo2 = { "taco", "pizza" };
            food[1] = "tacos";
            Console.WriteLine(food[1]);

            // Lists 
            List<string> foodList = new List<string>() {"taco","pizza"} ;
            foodList.Add("ice Cream");
            foodList.Add("cheeseburger");
            foodList.Add("hamburger");

            //add at index 
            foodList.Insert(0, "apple");

            //replace value 
            foodList[2] = "bananna";

            //get value from list
            string temp = foodList.ElementAt(3);
            string temp2 = foodList[3];

            string one = string.Empty;
            //get value by name
            for (int i = 0; i < foodList.Count; i++)
            {
                if (foodList.ElementAt(i).("apple"))
                {
                    one = foodList.ElementAt(i);
                }
            }
            // using contains
            List<string> burgers = new List<string>();
            for (int i = 0; i < length; i++)
			{
			    if (foodList.ElementAt(i).Contains("burger")) {
                    //store in burger
                    burgers.Add(foodList.ElementAt(i));
                }
                       
			}

            //sort list
            foodList.Sort(); //alphabetic
            foodList.Reverse(); //would reverse
            
            
            
            
            //remove elements from list
            foodList.Remove("apple");
            foodList.RemoveAt(3);
            foodList.Clear();

            //keep console open 
            Console.ReadKey();
        }
    }
}
