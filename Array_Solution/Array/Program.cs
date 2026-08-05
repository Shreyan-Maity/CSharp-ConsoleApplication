using System;

//-------------------------------------------------------------------------
//public class Prog
//{
//    public static void Main()
//    {
//        Console.Write("Enter the number of rows you want to have : ");
//        int ro = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter the number of columns you want to have : ");
//        int co = Convert.ToInt32(Console.ReadLine());

//        int[,] array = new int[ro, co];

//        for (int i = 0; i < ro; i++)
//        {
//            for (int j = 0; j < co; j++)
//            {
//                Console.Write("Enter the value of [" + i + "," + j + "] : ");
//                array[i, j] = Convert.ToInt32(Console.ReadLine());
//            }
//        }

//        int sumR=0, sumL=0,total=0;
//        Console.WriteLine("\nYour Array is :\n{");
//        for (int i = 0; i < ro; i++)
//        {
//            Console.Write("{");
//            for (int j = 0; j < co; j++)
//            {
//                Console.Write(array[i, j] + ", ");
//                total += array[i, j];
//                if (i == j) sumR += array[i, j];
//                if (i + j == ro - 1) sumL += array[i, j];
//            }
//            Console.WriteLine("}");
//        }
//        Console.WriteLine("}");

//        Console.WriteLine("\nThe sum of all right diagonal will be : " + sumR);
//        Console.WriteLine("\nThe sum of all left diagonal will be : " + sumL);
//        Console.WriteLine("\nThe sum of all elements of the Array will be : " + total);
//    }
//}
//
//-------------------------------------------------------------------------

//public class Programe
//{
//    public static void Main()
//    {
//        int[] arr = new int[] { 0, 20, 30 };
//        try
//        {
//            Console.WriteLine(arr[0]);
//            Console.WriteLine(arr[1]);
//            Console.WriteLine(arr[1] / arr[0]);
//            Console.WriteLine(arr[2]);
//            Console.WriteLine(arr[3]);
//        }
//        catch (IndexOutOfRangeException ex)
//        {
//            Console.WriteLine("Sorry there is no index left to show");
//        }
//        catch(DivideByZeroException ex)
//        {

//            Console.WriteLine("Infinity");
//        }
//        finally
//        {
//            Console.WriteLine("You are in Finally block");
//        }
//        Console.ReadLine();  //used just make the terminal stay, just to see the output.
//    }
//}

//-------------------------------------------------------------------------

public class Students
{
    int roll;
    string name;
    int age;
    string course;
    double fees;
    public void Input()
    {
        try
        {
            Console.Write("\nEnter the Roll : ");
            roll = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Name : ");
            name = Console.ReadLine();

            Console.Write("Enter the Age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Course name : ");
            course = Console.ReadLine();

            Console.Write("Enter the fess : ");
            fees = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Wrong Format data entered. Start Over again !!!\nRestart The Programe. or this entry will have all '0' values ");
        }

    }
    
    public void Display()
    {
        Console.WriteLine("/////////////////////////////");
        Console.WriteLine("Entered Roll:" + roll);
        Console.WriteLine("Entered Name:" + name);
        Console.WriteLine("Entered Age:" + age);
        Console.WriteLine("Entered Fees:" + fees);
        Console.WriteLine("Entered Course:" + course);
        //Console.WriteLine("/////////////////////////////");

    }
    public static void Main()
    {
        Students FirstStudent = new Students();
        Students SecondStudent = new Students();
        Students ThirdStudent = new Students();
        Students FourthStudent = new Students();
        
        FirstStudent.Input();
        SecondStudent.Input();
        ThirdStudent.Input();
        FourthStudent.Input();

        FirstStudent.Display();
        SecondStudent.Display();
        ThirdStudent.Display();
        FourthStudent.Display();

        Console.ReadLine();
    }
}