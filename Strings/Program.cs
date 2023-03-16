//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

string sampleString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

string[] stringArr = sampleString.Split(". ");

Console.WriteLine(stringArr[1]);

Console.WriteLine(string.Join(",", stringArr));

Console.WriteLine("Hello, Strings!");

