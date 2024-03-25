using System;
using MySolutions;

class Program {
    
    public delegate void DelegateToVoid(int [] numbers);

    static void Main(){
        
        //Task 1
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

        Delegates newDelegates = new Delegates();
        
        DelegateToVoid delegateToOdd = newDelegates.Odd;
        DelegateToVoid delegateToEven = newDelegates.Even;
        DelegateToVoid delegateToSimple = newDelegates.Simple;
        DelegateToVoid delegateToFibonachi = newDelegates.Fibonachi;
        
        
        delegateToOdd.Invoke(numbers); //Odd numbers
        Console.WriteLine();
        
        delegateToEven.Invoke(numbers); //Even numbers
        Console.WriteLine();
        
        delegateToSimple.Invoke(numbers); //Simple numbers
        Console.WriteLine();
        
        delegateToFibonachi.Invoke(numbers); //Simple numbers
        Console.WriteLine();
        
        
        //Task 2
        Action myAction = PrintTime;
        myAction+=PrintDate;
        myAction+=PrintWeekDay;
        myAction.Invoke();
        
        Func <double, double, double> myFunc1 = GetAreaTriangleBySides;
        double result = myFunc1.Invoke(5,4);
        Console.WriteLine($"Area of triangle is {result}");
        
        Func <double, double, int, double> myFunc2 = GetAreaTriangleBy2SidesAndAngleBetween;
        double result2 = myFunc2.Invoke(5,4,45);
        Console.WriteLine($"Area of triangle is {result2}");
        
        Func <double, double, double> myFunc3 = GetAreaRectangle;
        double result3 = myFunc3.Invoke(5,4);
        Console.WriteLine($"Area of rectangle is {result3}");
        
        Predicate<int> checkYears = CheckYear;
        bool Check = checkYears.Invoke(2025);
        Console.WriteLine($"Year that inserted {(Check? "more than current year" : "less than current year")}");
        
    }
    public static void PrintTime(){
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Current time: {currentTime.ToString("HH:mm:ss")}");
    }
    public static void PrintDate(){
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Current date: {currentTime.ToString("dd-MM-yyyy")}");
    }
    public static void PrintWeekDay(){
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Today: {currentTime.DayOfWeek}");
    }
    public static double GetAreaTriangleBySides(double height, double baseSide){
        double result = 0.5*height*baseSide;
        return result;
    }
    public static double GetAreaTriangleBy2SidesAndAngleBetween(double side1, double side2, int angle){
        double sinValue = Math.Sin(angle * Math.PI / 180);
        double result = 0.5*side1*side2*sinValue;
        return result;
    }
    public static double GetAreaRectangle(double side1, double side2){
        double result = side1*side2;
        return result;
    }
    public static bool CheckYear(int year){
        if(year > DateTime.Now.Year){
            return true;
        }
        else{
            return false;
        }
    }
    
}
