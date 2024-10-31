using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS3050_002_Group_Collaboration_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare and instantiate your classes
            // invoke your methods
            Bird myBird = new Bird();  // Instantiate
            Bird.HappyHalloween();
            Cat.HappyHalloween();
            Turtle.HappyHalloween();
            Fish.HappyHalloween("Not Used");
            Squirrel.HappyHalloween();  


        }
    }
}
