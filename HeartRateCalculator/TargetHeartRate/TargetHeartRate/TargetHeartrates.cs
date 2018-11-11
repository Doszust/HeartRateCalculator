// Dylan Oszust
// May 27th, 2018 

using System;

class TargetHeartRates
{
   static void Main(string[] args)
   {
        //instantiates new object
        HeartRates myHeartRates = new HeartRates();

        //user inputs first name
        Console.Write("Enter First Name: ");
        string fName = Console.ReadLine();

        //user inputs last name
        Console.Write("Enter Last Name: ");
        string lName = Console.ReadLine();

        //user inputs birth year
        Console.Write("Enter Year Of Birth: ");
        int YOB = int.Parse(Console.ReadLine());

        //sets object attributes to user input values
        myHeartRates.SetFName(fName);
        myHeartRates.SetLName(lName);
        myHeartRates.SetYOB(YOB);

        //displays all information
        Console.WriteLine($"First Name: {myHeartRates.GetFName()}\n" +
            $"Last Name: {myHeartRates.GetLName()}\n" +
            $"Year Of Birth: {myHeartRates.GetYOB()}\n" +
            $"Age: {myHeartRates.GetAge()}\n" +
            $"Max HR: {myHeartRates.GetMaxHR()} BPM\n" +
            $"Target HR: {myHeartRates.GetTargetHR()} BPM\n");
    }
}

