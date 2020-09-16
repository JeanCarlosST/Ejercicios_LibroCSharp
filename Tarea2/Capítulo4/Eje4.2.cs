using System;

public class Eje4_2{
    public static int Potencia(int base_, int pow){
        int num = base_;

        for(int i = 1; i < pow; i++){
            num *= base_;
        }

        return num;
    }
}