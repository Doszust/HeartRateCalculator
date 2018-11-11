// Dylan Oszust
// May 27th, 2018 

using System;

class HeartRates
{
    private string fName; //First Name
    private string lName; //Last Name
    private int year = DateTime.Now.Year; //Current Year From System
    private int yob; //Year Of Birth
    private int age;
    private int maxHR;
    private string targetHR;

    public void SetFName(string fName) //Sets Objects First Name
    {
        this.fName = fName;
    }

    public string GetFName() //Returns Objects First Name
    {
        return fName;
    }

    public void SetLName(string LName) //Sets Objects Last Name
    {
        this.lName = LName;
    }

    public string GetLName() //Returns Objects Last Name
    {
        return lName;
    }

    public void SetYOB(int yob) //Sets Objects Year Of Birth
    {
        this.yob = yob;
    }

    public int GetYOB() //Returns Objects Year Of Birth
    {
        return yob;
    }

    public int GetAge() //Calculates Users Age
    {
        age = year - yob;
        CalcHeartRates(); //Calls Heart Rate Calculation Method At This Point
        return age;
    }

    public int GetMaxHR() //Returns Max Heart Rate
    {
        return maxHR;
    }

    public string GetTargetHR() //Returns Target Heart Rate
    {
        return targetHR;
    }

    private void CalcHeartRates() //Calculates Max Heart Rate and Target Heart Rate Range
    {
        maxHR = 220 - age;
        targetHR = $"{maxHR * .5} - {maxHR * .85}";
    }
}
