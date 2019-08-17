using System;

namespace Prac_Inheritance
{
    //Interitance class which contains common details
    public class Routing
    {
        public String Region;
        public String Country;

        //Printing all route details 
        public void PrintDetails1()
        {
            Console.WriteLine("Region: {0}, Country: {1}", Region, Country);
        }
    }
   
    // This class contains longitude and latitude values and inherits the routing class properties
    public class Longtitude_Latitude : Routing
    {
        public float longitude;
        public float latitude;
        //Printing all route details 
        public void PrintDetails2()
        {
            Console.WriteLine("longitude: {0}, latitude: {1}", longitude, latitude);
        }
    }
    //This class contains address and inherits the routing class properties
    public class Address : Routing
    {
       public int postal_code;
       public void PrintDetails3()
       {
           Console.WriteLine("Postal Code: {0}", postal_code );
       }

    }
   
    //Main class
    class MainClass
    {
        public static void Main(string[] args)
        {
            Longtitude_Latitude longlat = new Longtitude_Latitude();

            longlat.Region = "Melbourne";
            longlat.Country = "Australia";
            longlat.longitude = 23890;
            longlat.latitude = 9978;
            longlat.PrintDetails1();
            longlat.PrintDetails2();
            


            Address addr = new Address();
            addr.postal_code = 3197;
            addr.PrintDetails3();


        }
    }
}
