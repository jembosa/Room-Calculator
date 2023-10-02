


using System;




public class PerimeterofRoom

{
    public static void Main()
    {

        Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
        Console.Write("What is the width of your room? : ");
        double Length = Convert.ToDouble(Console.ReadLine());

        Console.Write("What is the Length of your room?");
        double Width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the Height of your room?");
        double Height = Convert.ToDouble(Console.ReadLine());

        double Perimeter = 2 * (Length + Width);
        double Area = (Length * Width);
        double Volume = (Area * Height);
        double SurfaceArea = (2 * (Length * Width) + 2*(Length * Height) + 2*(Height * Width));



        Console.WriteLine("Perimeter of Room is: " + Perimeter);
        Console.WriteLine("Area of Room is: " + Area);
        Console.WriteLine("Volume of Room is: " +  Volume);
        Console.WriteLine("Surface Area of Room is: " + SurfaceArea);

        if (Area < 251) Console.WriteLine("Room is considered: Small");
        else if (Area > 250 && Area < 649) Console.WriteLine("Room is considered: Medium");
        else if (Area > 649) Console.WriteLine("Room is considered: Large");


        Console.WriteLine("Thank you for using the Room Detail Generator!"); 
        Console.ReadKey();

    }


}


