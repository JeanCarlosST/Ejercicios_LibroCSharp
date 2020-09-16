using System;

public class Eje4_5{
    private static int cant = 0;
    private static float avg = 0.0f;
    private static int oldest = 0;
    private static int youngest = 0;
    private static int age = 0;

    public static void Promedio(){

        Console.Write("Ingrese la cantidad de personas: ");
        cant = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < cant; i++){
            Console.Write("Ingrese una edad: ");
            age = Convert.ToInt32(Console.ReadLine());
            avg += age;

            if(i == 0)
                oldest = youngest = age;

            if(age > oldest) oldest = age;
            if(age < youngest) youngest = age;
        }

        avg /= cant;

        Console.WriteLine($"Promedio: {avg}");
        Console.WriteLine($"Mas grande: {oldest}");
        Console.WriteLine($"Mas joven: {youngest}");
    }
}