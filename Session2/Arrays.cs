using System;

public class Arrays
{
	public string month = "November";
	private string year = "2021";
	protected string day = "18";

	public void todaysDate(string day, string month, string year, string week=null, string century="1")
    {
		Console.WriteLine("------------------");
		Console.WriteLine("Today's date is " + day + month + year);
        Console.WriteLine("------------------");
        Console.WriteLine($"The day is {day} of the month {month} of the year {year}.");
		Console.WriteLine("------------------");
		Console.WriteLine($"{day}/{month}/{year}/{week}/{century}");
	}


	public  string todaysDate2(string day, string month, string year, string week = null, string century = "1")
	{
		string date = $"{day}/{month}/{year}/{week}/{century}";
        return date;
	}


	public static void Arrays_method()
	{
		int[] intList;

		intList = new int[3];

		intList[0] = 12;
		intList[1] = 1000000;
		intList[2] = 1000;

		//Console.WriteLine(intList[0]);
		//Console.WriteLine(intList[1]);
		//Console.WriteLine(intList[2]);

		for(int i=0; i < intList.Length; i++)
        {
			Console.WriteLine(intList[i]);
        }

		string[] days = new string[5];

		days[0] = "Monday";
		days[1] = "Tuesday";
		days[2] = "Wednesday";
		days[3] = "Thursday";
		days[4] = "Friday";

		int count = 0;

        while (count< days.Length)
        {
			Console.WriteLine(days[count]);
			count++;
		}

	}
}
