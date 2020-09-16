using System;

public class Eje5_4{
    public static int Factorial(int n){
        if(n <= 1) return 1;

        return n * Factorial(n-1);
    }
}