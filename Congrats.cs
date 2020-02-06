using System;

namespace MyWheelOfFortune
{
    public class Congrats
    {
        //FIELD
       // public string FullName;

        //CONSTRUCTOR
        //public Congrats(string fullName)
        //{
        //    this.FullName = fullName;
        //}

        //METHOD
        public static void SayCongrats(string FullName)
        {
            var index = FullName.IndexOf('-');
            if (index == -1 && !string.IsNullOrWhiteSpace(FullName))
                Console.WriteLine("Congratulations!");

        }


    }

 
}
