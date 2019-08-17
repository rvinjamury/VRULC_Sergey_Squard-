using System;

namespace Rigveda_Prac
{
    class customer_details
    {
        string _firstName;
        string _lastName;

        //If details are passed in the parameters
        //Default
        public customer_details() : this("No Firstname provided", "No LastName provided")
        {

        }

        //creating constructors
        public customer_details(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void printFullName()
        {
            Console.WriteLine("Full Name:{0}", _firstName + " " + _lastName);
        }

        //Destructors
        ~customer_details()
        {
            //cleans up the code
        }

    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            customer_details c1 = new customer_details("Vehicle Routing", "with Constarints" );
            c1.printFullName();

            customer_details c2 = new customer_details();
            c2.printFullName();
    }
}