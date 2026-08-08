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

//public class Students
//{
//    int roll;
//    string name;
//    int age;
//    string course;
//    double fees;
//    public void Input()
//    {
//        try
//        {
//            Console.Write("\nEnter the Roll : ");
//            roll = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter the Name : ");
//            name = Console.ReadLine();

//            Console.Write("Enter the Age : ");
//            age = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter the Course name : ");
//            course = Console.ReadLine();

//            Console.Write("Enter the fess : ");
//            fees = Convert.ToDouble(Console.ReadLine());
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine("Wrong Format data entered. Start Over again !!!\nRestart The Programe. or this entry will have all '0' values ");
//        }

//    }

//    public void Display()
//    {
//        Console.WriteLine("/////////////////////////////");
//        Console.WriteLine("Entered Roll:" + roll);
//        Console.WriteLine("Entered Name:" + name);
//        Console.WriteLine("Entered Age:" + age);
//        Console.WriteLine("Entered Fees:" + fees);
//        Console.WriteLine("Entered Course:" + course);
//        //Console.WriteLine("/////////////////////////////");

//    }
//    public static void Main()
//    {
//        Students FirstStudent = new Students();
//        Students SecondStudent = new Students();
//        Students ThirdStudent = new Students();
//        Students FourthStudent = new Students();

//        FirstStudent.Input();
//        SecondStudent.Input();
//        ThirdStudent.Input();
//        FourthStudent.Input();

//        FirstStudent.Display();
//        SecondStudent.Display();
//        ThirdStudent.Display();
//        FourthStudent.Display();

//        Console.ReadLine();
//    }
//}

//-------------------------------------------------------------------------

//public class Program
//{
//    public int Add(int x,int y)
//    {
//        return x + y;
//    }
//    public static void Main()
//    {
//        int a = 10, b = 20,Sum;
//        Program New = new Program();
//        Sum=New.Add(a, b);
//        Console.WriteLine(Sum);
//        Console.ReadLine();    
//    }
//}


//-------------------------------------------------------------------------

//public class ElectricityBill
//{
//    double consumedUnits, customerID;
//    string name= string.Empty;
//    double bill;
//    //public double Bill(double Input)
//    //{
//    //    double Bill = 0;0

//    //    return Bill;
//    //}
//    public void UserInput()
//    {
//        Console.Write("Enter your CustomerID : ");
//        customerID = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter your Name : ");
//        name = Console.ReadLine() ?? string.Empty;
//        Console.Write("Enter your Consumption Units : ");
//        consumedUnits = Convert.ToDouble(Console.ReadLine());
//        if (consumedUnits <= 100) bill = consumedUnits * 2;
//        else if (consumedUnits <= 200) bill = (100 * 2) + (consumedUnits - 100) * 3;
//        else if (consumedUnits <= 400) bill = (100 * 2) + (100 * 3) + (consumedUnits - 200) * 5;
//        else bill = (100 * 2) + (100 * 3) + (200 * 5) + (consumedUnits - 400) * 8;
//    }
//    public void Output()
//    {
//        Console.WriteLine($"\nCustomerID : {customerID},{name} ");
//        Console.WriteLine("Your billed amount is : " + bill);
//    }
//    public static void Main()
//    {
//        ElectricityBill New = new ElectricityBill();

//        New.UserInput();
//        New.Output();
//        Console.ReadLine();
//    }
//}


//-------------------------------------------------------------------------

//public class CallByValue
//{
//    public void Swap(int i,int j)
//    {
//        int temp = i;
//        i = j;
//        j = temp;

//        Console.Write($"\nValue of 1st num in Swap : {i}");
//        Console.Write($"\nValue of 2nd num in Swap : {j}");

//    }
//    public static void Main()
//    {
//        int x, y;
//        Console.Write("Enter value of 1st num : ");
//        x = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter value of 2nd num : ");
//        y = Convert.ToInt32(Console.ReadLine());

//        CallByValue New = new CallByValue();
//        New.Swap(x,y);

//        Console.Write($"\nValue of 1st num in Main : {x}");
//        Console.Write($"\nValue of 2nd num in Main : {y}");

//    }
//}


//-------------------------------------------------------------------------

//public class CallByReference
//{
//    public void Swap(ref int i, ref int j)
//    {
//        int temp = i;
//        i = j;
//        j = temp;

//        Console.Write($"\nValue of 1st num in Swap : {i}");
//        Console.Write($"\nValue of 2nd num in Swap : {j}");

//    }
//    public static void Main()
//    {
//        int x, y;
//        Console.Write("Enter value of 1st num : ");
//        x = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter value of 2nd num : ");
//        y = Convert.ToInt32(Console.ReadLine());

//        CallByReference New = new CallByReference();
//        New.Swap(ref x, ref y);

//        Console.Write($"\nValue of 1st num in Main : {x}");
//        Console.WriteLine($"\nValue of 2nd num in Main : {y}");
//    }
//}


//-------------------------------------------------------------------------


//public class Numbers
//{
//    public int i;
//    public int j;
//}
//public class Program
//{
//    public int Add(Numbers NumObj)
//    {
//        return NumObj.i+ NumObj.j;
//    }
//    public void Swap(Numbers NumObj)
//    {
//        int t = NumObj.i;
//        NumObj.i = NumObj.j;
//        NumObj.j = t;
//        Console.WriteLine($"\n1st num in swap : {NumObj.i}");
//        Console.Write($"2nd num in swap : {NumObj.j}");
//    }
//    public static void Main()
//    {
//        Program NewObj=new Program();
//        Numbers NumObj = new Numbers();
//        Console.Write("Enter 1st num : ");
//        NumObj.i = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter 2nd num : ");
//        NumObj.j = Convert.ToInt32(Console.ReadLine());
//        int Sum = NewObj.Add(NumObj);
//        NewObj.Swap(NumObj);

//        Console.WriteLine($"\nSum : {Sum}");

//        Console.WriteLine($"\n1st num in Main : {NumObj.i}");
//        Console.Write($"2nd num in Main : {NumObj.j}");
//    }
//}


//-------------------------------------------------------------------------

////public class StaticVar
////{
////    public int roll;
////    public string name;
////    public static string School;
////}
//public class Student
//{
//    public int roll;
//    public string name;
//    public static string School;
//    public void Display()
//    {
//        Console.WriteLine($"Roll in Display : {roll}");
//        Console.WriteLine($"Name in Display : {name}");
//        Console.WriteLine($"School in Display : {School}");
//    }
//    public static void Main()
//    {
//        //StaticVar New = new StaticVar();
//        Student st1 = new Student();
//        Student st2 = new Student();
//        Student.School = "Belur Boys";
//        Student st3 = new Student();
//        Student st4 = new Student();
//        //School = "SchollName"; //we can also initialize static values like this in main

//        Console.Write("Enter roll : ");
//        st1.roll = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter name : ");
//        st1.name = Console.ReadLine();

//        Console.Write("Enter roll : ");
//        st2.roll = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter Name : ");
//        st2.name = Console.ReadLine();

//        Console.Write("Enter roll : ");
//        st3.roll = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter Name : ");
//        st3.name = Console.ReadLine();

//        Console.Write("Enter roll : ");
//        st4.roll = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter Name : ");
//        st4.name = Console.ReadLine();

//        st1.Display();
//        st2.Display();
//        st3.Display();
//        st4.Display();
//    }
//}


//-------------------------------------------------------------------------

//public class Mainly
//{
//    int i;
//    double j;
//    string nm;
//    bool b;
//    //public Mainly() //This is a Default constructor created by me
//    public Mainly(int q) //This is a Parameterized constructor created by me
//    {
//        i = q;
//        j = 99.99;
//        nm = "Shreyan";
//        //b = True;
//    }
//    public void Display(Mainly New)
//    {
//        Console.WriteLine(New.i);
//        Console.WriteLine(New.j);
//        Console.WriteLine(New.nm);
//        Console.WriteLine(New.b);
//        Console.WriteLine();
//    }
//    public static void Main()
//    {
//        Mainly N1 = new Mainly(1);
//        Mainly N2 = new Mainly(10);

//        N1.Display(N1);

//        N2.j = 22.22;
//        N2.nm = "Ram";
//        N2.Display(N2);
//    }
//}

//-------------------------------------------------------------------------

//public class You
//{
//    int roll;
//    string name;
//    int age;
//    string school="SchoolName";

//    //Our created default Constructor
//    public You()
//    {
//        roll = 01;
//        name = "Name";
//        age = 18;
//    }
//    ~You()
//    {
//        Console.WriteLine("Destructor working...");
//    }

//    //Taking input form user
//    public void Input()
//    {
//        Console.Write("Enter Roll : ");
//        roll = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter Name : ");
//        name = Console.ReadLine();
//        Console.Write("Enter Age : ");
//        age = Convert.ToInt32(Console.ReadLine());
//    }

//    //Display Our created Objects Details
//    public void OutPut()
//    {
//        Console.WriteLine($"\nYou entered Roll : {roll}");
//        Console.WriteLine($"You entered Name : {name}");
//        Console.WriteLine($"You entered Age : {age}");
//        Console.WriteLine($"Defalt School name : {school}");
//    }

//    public static void Main()
//    {
//        You New_1 = new You();
//        You New_2 = new You();
//        You New_3 = new You();

//        New_1.school = "Name of School";

//        New_1.Input();
//        New_2.Input();



//        New_1.OutPut();
//        New_2.OutPut();
//        New_3.OutPut();
//    }
//}


//-------------------------------------------------------------------------

//public class Name
//{
//    public string name,nk;
//    public Name()
//    {
//        name = "Your Name";
//        nk = "Your nick name";
//    }
//    public static void NameMethod()
//    {
//        Name n = new Name();
//        Console.Write("Name: ");
//        n.name = Console.ReadLine();
//        Console.Write("Nick Name: ");
//        n.nk = Console.ReadLine();
//        Console.WriteLine(n.name);
//        Console.WriteLine(n.nk);
//    }
//}
//public class Title : Name
//{
//    public string title;
//    public Title()
//    {
//        title = "Your Title";
//    }
//    public void TitleMethod()
//    {
//        NameMethod();
//        Title t = new Title();
//        Console.Write("Title: ");
//        t.title = Console.ReadLine();
//        Console.WriteLine(t.title);
//    }
//}
//public class Prog 
//{
//    public static void Main()
//    {
//        Title n1 = new Title();
//        Title n2 = new Title();

//        n1.TitleMethod();
//        n2.TitleMethod();
//    }
//}


//-------------------------------------------------------------------------

public class ClassA
{
    int a;
    public ClassA()
    {
        a = 10;
    }
    public void MethodA()
    {
        Console.WriteLine(a);
    }
}
public class ClassB : ClassA
{
    int b;
    public ClassB()
    {
        b = 11;
    }
    public void MethodA()
    {
        base.MethodA();
        Console.WriteLine("This is MethodA in ClassB");
    }
    public void MethodB()
    {
        MethodA();
        Console.WriteLine(b);
    }
}

public class Program
{
    public static void Main()
    {
        ClassB B1 = new ClassB();
        B1.MethodB();
    }
}


//-------------------------------------------------------------------------