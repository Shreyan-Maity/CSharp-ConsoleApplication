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

//public class ClassA
//{
//    int a;
//    public ClassA()
//    {
//        a = 10;
//    }
//    public void MethodA()
//    {
//        Console.WriteLine(a);
//    }
//}
//public class ClassB : ClassA
//{
//    int b;
//    public ClassB()
//    {
//        b = 11;
//    }
//    public void MethodA()
//    {
//        base.MethodA();
//        Console.WriteLine("This is MethodA in ClassB");
//    }
//    public void MethodB()
//    {
//        MethodA();
//        Console.WriteLine(b);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        ClassB B1 = new ClassB();
//        B1.MethodB();
//    }
//}


//-------------------------------------------------------------------------


//public class ClassA
//{
//    public int x;
//    public ClassA(int x)
//    {
//        this.x = x;
//    }
//}
//public class ClassB : ClassA
//{
//    public int y, z;
//    public ClassB(int x,int y,int z):base(x)
//    {
//        this.y = y;
//        this.z = z;
//    }
//    public void Output()
//    {
//        Console.WriteLine(x);
//        Console.WriteLine(y);
//        Console.WriteLine(z);
//    }
//}
//public class Program
//{
//    public static void Main()
//    {
//        ClassB New = new ClassB(10,20,30);
//        New.Output();
//    }
//}


//-------------------------------------------------------------------------

//public class ClassA
//{
//    public void Display()
//    {
//        Console.WriteLine("This is from ClassA");
//    }
//}
//public class Program :ClassA
//{
//    public void Display()
//    {
//        base.Display();
//        Console.WriteLine("Display1 : No value");
//    }
//    public void Display(int y)
//    {
//        Console.WriteLine("After Overriding Display2 :"+y);
//    }
//    public static void Main()
//    {
//        Program New = new Program();
//        //ClassA NewA = new ClassA();

//        //NewA.Display();
//        New.Display();
//        New.Display(100);
//    }
//}

//-------------------------------------------------------------------------

//public class ClassA
//{
//    public virtual void Display()
//    {
//        Console.WriteLine("This is from A");
//    }
//}
//public class ClassB :ClassA
//{
//    public override void Display()
//    {
//        base.Display();
//        Console.WriteLine("This is from B");
//    }
//}
//public sealed class ClassC : ClassB //Here is "ClassC" is marked as sealed so nother class can inherit "ClassC"
//{
//    public override void Display()
//    {
//        base.Display();
//        Console.WriteLine("This is from C");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        ClassC New = new ClassC();
//        New.Display();
//    }
//}


//-------------------------------------------------------------------------

//namespace Calculator
//{
//    public abstract class Calcu
//    {
//        protected int x=10;
//        protected int y=5;
//        internal void Output(int Result) //normal Method
//        {
//            Console.WriteLine("This is normal method");
//            Console.WriteLine("Result from Output : " + Result);
//        }
//        internal abstract void Input();
//        internal abstract int Cal();
//    }
//    internal class Add : Calcu
//    {
//        int num1, num2;
//        internal override void Input()
//        {
//            Console.Write("Enter num1 : ");
//            num1 = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter num2 : ");
//            num2 = Convert.ToInt32(Console.ReadLine());
//        }
//        internal override int Cal()
//        {
//            return num1+num2+x;
//        }
//    }
//    internal class Sub : Calcu
//    {
//        int num1, num2;
//        internal override void Input()
//        {
//            Console.Write("Enter num1 : ");
//            num1 = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter num2 : ");
//            num2 = Convert.ToInt32(Console.ReadLine());
//        }
//        internal override int Cal()
//        {
//            return num1 - num2+y;
//        }

//    }
//    internal class Program
//    {
//        internal static void Main()
//        {
//            //Calcu New = new Calcu(); //this object can not be created as this is a abstract class
//            Add New_1 = new Add();
//            Sub New_2 = new Sub();

//            New_1.Input();
//            int Res = New_1.Cal();
//            New_1.Output(Res);
//            //Console.WriteLine("Result from Main : " + New_1.Cal());

//            New_2.Input();
//            Res = New_2.Cal();
//            New_2.Output(Res);
//            //Console.WriteLine("Result from Main : " + New_2.Cal());
//        }
//    }
//}


//-------------------------------------------------------------------------


//public class User
//{
//    private string name;
//    public string GetName()
//    {
//        return name;
//    }
//    public void SetName(string NewName)
//    {
//        name = NewName;
//    }
//}
//public class Function
//{
//    public static void Main()
//    {
//        User New = new User();

//        Console.Write("Enter the New Name: ");
//        string n = Console.ReadLine();
//        New.SetName(n);
//        Console.WriteLine("NewName :"+New.GetName());
//    }
//}


//-------------------------------------------------------------------------


//public interface IDemo
//{
//    public void Display();

//    //public void Display() // we can write this method in iterface after wards C# 8.0
//    //{                     // but better to only declare the method in Interface   
//    //    Console.WriteLine("This is Interface");
//    //}
//}
//public class Demo : IDemo
//{
//    public void Display()
//    {
//        Console.WriteLine("Method from class Demo");
//    }
//}
//public class Program : IDemo
//{
//    public void Display()
//    {
//        Console.WriteLine("Method from Interface");
//    }
//    public static void Main()
//    {
//        IDemo N = new Demo();
//        N.Display();
//    }
//}


//-------------------------------------------------------------------------


//namespace Name
//{
//    interface IinterfaceA
//    {
//        public void MethodA();
//        public void MethodB();
//    }
//    interface IinterfaceB
//    {
//        public void MethodC();
//    }
//    class ClassA : IinterfaceA,IinterfaceB
//    {
//        public void MethodA()
//        {
//            Console.WriteLine("Method A - Class A");
//        }
//        public void MethodB()
//        {
//            Console.WriteLine("Method B - Class A");
//        }
//        public void MethodC()
//        {
//            Console.WriteLine("Method C - Class A");
//        }
//    }
//    class ClassB : IinterfaceA,IinterfaceB
//    {
//        public void MethodA()
//        {
//            Console.WriteLine("Method A - Class B");
//        }
//        public void MethodB()
//        {
//            Console.WriteLine("Method B - Class B");
//        }
//        public void MethodC()
//        {
//            Console.WriteLine("Method C - Class B");
//        }
//    }
//    class Program
//    {
//        public static void Main()
//        {
//            ClassA New_1 = new ClassA();
//            New_1.MethodA();
//            New_1.MethodB();
//            New_1.MethodC();

//            ClassB New_2 = new ClassB();
//            New_2.MethodA();
//            New_2.MethodB();
//            New_2.MethodC();
//        }
//    }
//}


//-------------------------------------------------------------------------


//public interface INum
//{

//}
//public class Name
//{
//    int x;
//    public Name(int x) //Constructor
//    {
//        this.x=x;
//    }
//    public void Method()
//    {
//        Console.WriteLine(x);
//    }
//    public void Method(int x) //This is Method Overloading
//    {
//        Console.WriteLine(x);
//    }
//}
//class Program :Name
//{
//    public Program(int x) : base(x)
//    {

//    }
//    public static void Main()
//    {
//        Name New = new Name(10);
//        New.Method();
//        New.Method(11);
//        Program N = new Program(12);
//        N.Method();
//        N.Method(13);
//    }
//}


//-------------------------------------------------------------------------


//class Method
//{
//    public static void Main()
//    {
//        int x = 100;
//        int y = 0;
//        try
//        {
//            Console.WriteLine(x / y);
//        }
//        catch(DivideByZeroException ex)
//        {
//            Console.WriteLine("Exception");
//        }
//        finally
//        {
//            Console.WriteLine("Finally");
//        }
//    }
//}


//-------------------------------------------------------------------------


//public class ClassA
//{
//    int integer;
//    float salary;
//    string Name;
//    public ClassA() //Default Constructor
//    {
//        integer = 10;
//        salary = 99.99f;
//        Name = "Your Name";
//    }
//    public ClassA(int integer,float salary,string Name) //Parameterized Constructor
//    {
//        this.integer = integer;
//        this.salary = salary;
//        this.Name = Name;
//    }
//    public void MethodA() //Method
//    {
//        Console.WriteLine(integer);
//        Console.WriteLine(salary);
//        Console.WriteLine(Name);
//    }
//    public void MethodA(int x) //Method OverLoading (Ploymorphism)
//    {
//        Console.WriteLine(x);
//    }
//    public static void Main() //Main Method
//    {
//        ClassA New = new ClassA(11,12.09f,"Shreyan");
//        ClassA Old = new ClassA();
//        New.MethodA();
//        Old.MethodA();
//        Old.MethodA(100);
//    }
//}


//-------------------------------------------------------------------------

//public class Class
//{
//    public static void Main()
//    {
//        List<int> New = new List<int>();

//        New.Add(50);
//        New.Add(20);
//        New.Add(40);
//        New.Add(10);
//        New.Add(30);

//        New.Remove(20);
//        New.Sort();
//        foreach(int item in New)
//        {
//            Console.WriteLine(item + " ");
//        }
//        Console.WriteLine(New.Count);

//    }
//}


//-------------------------------------------------------------------------


namespace Interface
{
    interface Iinterface
    {
        void MethodCal(); //inside interface we cannot have acces modifieres
    }
    public class ClassA : Iinterface
    {
        public string userName { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public ClassA(string userName)
        {
            this.userName = userName;
        }
        public ClassA(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MethodCal()
        {
            Console.WriteLine($"ClassA - MethodCal - {userName}");
        }
        public void MethodCal(int num)
        {
            Console.WriteLine($"ClassA - MethodCal - {x+y} + {num} = {x+y+num}");
        }
    }
    public class ClassB : ClassA
    {
        public ClassB(string userName) : base(userName) { }
        public ClassB(int x, int y) : base(x,y) { }
        public void MethodCal()
        {
            Console.WriteLine($"ClassB - MethodCal - {userName}");
        }
    }
    public class ClassC : ClassA
    {
        public ClassC(string userName) : base(userName) { }
        public ClassC(int x, int y) : base(x, y) { }
        public void MethodCal()
        {
            Console.WriteLine($"ClassC - MethodCal - {userName}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Iinterface objA = new ClassA("Ram");
            ClassA objA_1 = new ClassA(9,10);
            ClassA Obj_A_11 = new ClassA("Ram-1");
            objA.MethodCal();
            objA_1.MethodCal(10);
            Obj_A_11.MethodCal();

            Console.WriteLine();

            Iinterface objB = new ClassB("Sam");
            ClassB objB_1 = new ClassB(11, 12);
            ClassB Obj_B_11 = new ClassB("Ram-1");
            objB.MethodCal();
            objB_1.MethodCal(11);
            Obj_B_11.MethodCal();

            Console.WriteLine();

            Iinterface objC = new ClassC("Jadu");
            ClassC objC_1 = new ClassC(30,20);
            ClassC Obj_C_11 = new ClassC("Jadu-1");
            objC.MethodCal();
            objC_1.MethodCal(50);
            Obj_C_11.MethodCal();
        }
    }
}


//-------------------------------------------------------------------------

