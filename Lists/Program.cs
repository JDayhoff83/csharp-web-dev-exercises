//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

List<int> newList = new List<int>
{
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9,
    10
};

static int sumEven(List<int> list)
{
    int total = 0;
    foreach(int item in list)
    {
        if(item % 2 == 0)
        {
            total += item;
        }
    }
    return total;
}

Console.WriteLine(sumEven(newList));

static void fiveLetterWord(List<string> list)
{  
    foreach(string word in list)
    {
        if(word.Length == 5)
        { 
            Console.WriteLine(word);
        }

    }
}

List<string> stringList = new List<string>
{
    "Hello",
    "How",
    "Are",
    "You",
    "Today"
};

fiveLetterWord(stringList);

Console.WriteLine("Hello, Lists!");
