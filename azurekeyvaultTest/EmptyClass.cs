using System;
namespace azurekeyvaultTest
{
    static public class EmptyClass

    { 

        static public string getName()
        {
            Random ran = new Random();
            string name = "akv" + Convert.ToString(ran.Next(10, 1000));
            return name;
        }

    }

}