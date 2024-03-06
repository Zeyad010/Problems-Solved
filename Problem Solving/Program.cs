
using Problem_Solving;
using System.ComponentModel;
using System.Text.RegularExpressions;
void PrintArray(int[] array)
{
	Console.WriteLine("Array Elements:");

	foreach (int element in array)
	{
		Console.Write(element + " ");
	}

	Console.WriteLine(); // Add a line break for better readability
}


/*int firstnumber ;
firstnumber =Convert.ToInt32(Console.ReadLine());
int secondnumber ;
secondnumber =Convert.ToInt32(Console.ReadLine());
int temp;


temp = firstnumber;
firstnumber = secondnumber;
secondnumber = temp;










Console.WriteLine("First number =" + firstnumber);
Console.WriteLine("Second Number ="+secondnumber);
*/


// # Digits Summation

/*

using System.Collections.Specialized;

int num1, num2, sum = 0;
int x, y;

Console.WriteLine("Enter tow numbers each number contains tow digits");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());

if(num1>=0 || num2 >= 0)
{
    x = num1 % 10;
    y = num2 % 10;

    sum+=x+ y;  
}

Console.WriteLine("Sum = " + sum);

*/




// Rearrange array by even numbers in the first of the array and the odd in the last of it

/*
int [] arr=  {1, 2, 3, 4, 5, 6, 7, 8, 9};

int Tracker = 0;

for (int i = 0; i < arr.Length; i++)                
{

    if (arr[i] %2==0)
    {


        (arr[Tracker], arr[i]) = (arr[i], arr[Tracker]);
        //int temp = arr[i];
        //arr[i] = arr[Tracker];
        //arr[Tracker] = temp;
       
        
        Tracker++;
    }



}

foreach (int i in arr)
{
    Console.Write(i+" ");
}

*/


/*
using System.Runtime.InteropServices;

int sizee;
Console.WriteLine("Enter size of array");
sizee = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sizee);
int[] Numbers = new int[sizee] ;

for(int i = 0; i < Numbers.Length; i++)
{

    Console.WriteLine("Enter element at the index "+(i+1));
   Numbers[i] = Convert.ToInt32(Console.ReadLine());


}




PrintInfo(Numbers);

 bool IsPrime(int number)
{
    if (number <= 1)
        return false;

    if (number <= 3)
        return true;

    if (number % 2 == 0 || number % 3 == 0)
        return false;

    for (int i = 5; i * i <= number; i += 6)
    {
        if (number % i == 0 || number % (i + 2) == 0)
            return false;
    }

    return true;
}

 int CountPrimes(int[] array)
{
    int count = 0;

    foreach (int num in array)
    {
        if (IsPrime(num))
        {
            count++;
        }
    }

    return count;
}

void PrintInfo(int[] array)
{
    Console.WriteLine("The maximum number : " + array.Max());

    Console.WriteLine("The minimum number : " + array.Min());
    Console.WriteLine("The number of prime numbers : " + CountPrimes(array));
    Console.WriteLine("The number of palindrome numbers : "+ CountPalindromes(array));
    Console.WriteLine("The number that has the maximum number of divisors" + NumberWithMaxDivisors(array) );


}
void PrintArray(int[] array)
{

    foreach (int i in array)
    {

        Console.WriteLine(i);
    }

}

 bool IsPalindrome(int number)
{
    string numString = number.ToString();
    int left = 0;
    int right = numString.Length - 1;

    while (left < right)
    {
        if (numString[left] != numString[right])
        {
            return false;
        }
        left++;
        right--;
    }

    return true;
}

 int CountPalindromes(int[] array)
{
    int count = 0;

    foreach (int num in array)
    {
        if (IsPalindrome(num))
        {
            count++;
        }
    }

    return count;
}

 int CountDivisors(int number)
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            count++;
        }
    }
    return count;
}

 int NumberWithMaxDivisors(int[] array)
{
    int maxDivisors = 0;
    int numberWithMaxDivisors = -1;

    foreach (int num in array)
    {
        int divisors = CountDivisors(num);
        if (divisors > maxDivisors)
        {
            maxDivisors = divisors;
            numberWithMaxDivisors = num;
        }
    }

    return numberWithMaxDivisors;
}


*/








// P1 : Convert Number to Corresponding Month

/*

string MonthName(int num) {


    string[] Months = { "Januar", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


    if(num>=0 && num<=12)
    return Months[num]; 
    else
        return "Not Valid";
}


Console.WriteLine("Enter Month Number ");
int In=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your Month Is " + MonthName(In - 1));

*/

/*
// Another SOL by using System.Globalization ****
using System.Globalization;

static string MonthName2(int num)
{
    return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
}
Console.WriteLine("Enter Month Number ");
int In = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your Month Is " + MonthName2(In));
*/











// P2 : Return the Index of All Capital Letters

/*

int[]  IndexOfCapitals(string text)
{
    List<int> CIndex = new List<int>();    
    foreach(char c in text)
    {
        if (char.IsUpper(c))
        {
        CIndex.Add(text.IndexOf(c));
                               
        }
    }

    return CIndex.ToArray();

}


PrintArray(IndexOfCapitals("STRIKE"));
*/




// P3 : Find the Bomb

/*

bool FindBomb(string inputString , string bom)
{


    return inputString.IndexOf(bom,StringComparison.OrdinalIgnoreCase)>=0;
}


string sentence = "Hey, did you think there is a Bomb?";

string search = "bomb";

bool BombFound =FindBomb(sentence,search);

Console.WriteLine($"{(BombFound ? "Duck!!!" : "There is no bomb, relax")}.");

*/







//P4 : Equality Check

/*
bool CheckEquality(object a, object b)
{


    if(a.GetType() == b.GetType())
        return true;
    else 
        return false;



    
}

bool check= CheckEquality(1, "1");

if (check)
    Console.WriteLine("true");
else
    Console.WriteLine("false");


*/




//int[] TrackRobot(string[] instructions)
//{





//}


/*
// P5 : Track the Robot
static int[] CalculateFinalPosition(string[] instructions)
{
    int[] currentPosition = { 0, 0 };

    foreach (string instruction in instructions)
    {
        string[] parts = instruction.Split(' ');
        string direction = parts[0].ToLower(); 
        int distance = int.Parse(parts[1]);

        
        switch (direction)
        {
            case "up":
                currentPosition[1] += distance;
                break;
            case "down":
                currentPosition[1] -= distance;
                break;
            case "left":
                currentPosition[0] -= distance;
                break;
            case "right":
                currentPosition[0] += distance;
                break;
            default:
                Console.WriteLine($"Invalid direction: {direction}");
                break;
        }
    }

    return currentPosition;
}


string[] instructions = { "left 2", "up 3", "right 5", "down 1" };


int[] finalPosition = CalculateFinalPosition(instructions);

Console.WriteLine($"Final Position: [{finalPosition[0]}, {finalPosition[1]}]");
*/

/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower", "flow", "flight"]
Output: "fl"
Example 2:

Input: strs = ["dog", "racecar", "car"]
Output: ""
Explanation: There is no common prefix among the input strings.
*/


/*
 static string LongestCommonPrefix(string[] strs)
{
	int size = strs.Length;
	if (size == 0)
		return ""; // Empty input array

	if (size == 1)
		return strs[0]; // Only one string in the array

	Array.Sort(strs); // Sort the array lexicographically
	int end = Math.Min(strs[0].Length, strs[size - 1].Length);
	int i = 0;

	// Compare characters from the first and last string
	while (i < end && strs[0][i] == strs[size - 1][i])
		i++;

	// Extract the common prefix
	string prefix = strs[0].Substring(0, i);
	return prefix;
}


string[] testStrings = { "flower", "flow", "flight" };

LongestCommonPrefix(testStrings);



*/



