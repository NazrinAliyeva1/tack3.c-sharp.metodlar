

//task a//:	
//a) Method Task: Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapın.


//using System;

//class Program
//{

//    static int Min(int[] arr)
//    {
//        int min = arr[0];
//        foreach (int num in arr)
//        {
//            if (num < min)
//            {
//                min = num;
//            }
//        }
//        return min;
//    }
//    static void Main()
//    {
//        int[] arr = { 9, 7, -1, 4, -5, -8,-9 };
//        Console.WriteLine("Minimum eded: " + Min(arr));
//    }
//}





//a) Method Task: max tapır.-elave yazmisam.

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 400, 2, 200, 1, 9, 5, 24, 78, 94,190 };
//        Console.WriteLine("Maksimum eded: " + Max(arr));
//    }

//    static int Max(int[] arr)
//    {
//        int max = arr[0]; // İlk ədədi mövcud maksimum olaraq qəbul edirik.
//        foreach (int num in arr)
//        {
//            if (num > max)
//                max = num;
//        }
//        return max;
//    }
//}

//task b //

//using System;
//class Program
//{
//    static double Area(double r)
//    {
//        const double p = 3;
//        return p * r * r;

//    }
//    static double Area(double a, double b)
//    {
//        return a * b;

//    }
//    static double Area(double a, double b, double c)
//    {
//        return 2 * (a * b + a * c + b * c);

//    }
//    static double Area(double r, double a, double b, double c)
//    {

//        double p = (a + b + c) / 2;
//        return p * r;

//    }
//    static void Main()
//    {
//        double S1 = Area(4);
//        Console.WriteLine("Çevrenin sahesi: " + S1);

//        double S2 = Area(6, 5);
//        Console.WriteLine("Düzbucaqlının sahesi: " + S2);

//        double S3 = Area(8, 9, 10);
//        Console.WriteLine("Düzbucaqlı paralelpipedin tam sethinin sahesi: " + S3);

//        double S4 = Area(18, 16, 12, 8);
//        Console.WriteLine("Ücbucaqlının daxiline cekilmis çevrenin sahesi: " + S4);

//    }
//}


