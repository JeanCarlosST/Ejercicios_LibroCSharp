using System;

public class Eje5_5{
    public static string Numeros(int n){
        string number = "";

        if(n < 0){
            Console.Write("Negativo ");
            n *= -1;
        }

        int div = n/100;
        int res = n%100;

        bool centenas = false;
        if(div > 0){
            centenas = true;
            switch(div){
                case 0:
                    break;
                case 1:
                    number += "ciento";
                    break;
                case 2:
                    number += "doscientos";
                    break;
                case 3:
                    number += "trescientos";
                    break;
                case 4:
                    number += "cuatrocientos";
                    break;
                case 5:
                    number += "quinietos";
                    break;
                case 6:
                    number += "seiscientos";
                    break;
                case 7:
                    number += "setecientos";
                    break;
                case 8:
                    number += "ochocientos";
                    break;
                case 9:
                    number += "novecientos";
                    break;
            }
        }

        if(centenas){
            res = res%10;
            if(res > 19) div = res/10;
        }

        bool decena = false;
        if(div > 1){
            decena = true;
            switch(div){
                case 0: case 1:
                    break;
                case 2:
                    number += "veinte";
                    break;
                case 3:
                    number += "treinta";
                    break;
                case 4:
                    number += "cuarenta";
                    break;
                case 5:
                    number += "cincuenta";
                    break;
                case 6:
                    number += "sesenta";
                    break;
                case 7:
                    number += "setenta";
                    break;
                case 8:
                    number += "ochenta";
                    break;
                case 9:
                    number += "noventa";
                    break;
            }
        }

        if(res > 0){
            if(decena) number += "i";
        
            switch(res){
                case 0: 
                    number += "cero"; 
                    break;
                case 1: 
                    number += "uno"; 
                    break;
                case 2: 
                    number += "dos"; 
                    break;
                case 3: 
                    number += "tres"; 
                    break;
                case 4: 
                    number += "cuatro"; 
                    break;
                case 5: 
                    number += "cinco"; 
                    break;
                case 6: 
                    number += "seis"; 
                    break;
                case 7: 
                    number += "siete"; 
                    break;
                case 8: 
                    number += "ocho"; 
                    break;
                case 9: 
                    number += "nueve"; 
                    break;
                case 10: 
                    number += "diez"; 
                    break;
                case 11: 
                    number += "once"; 
                    break;
                case 12: 
                    number += "doce"; 
                    break;
                case 13: 
                    number += "trece"; 
                    break;
                case 14: 
                    number += "catorce"; 
                    break;
                case 15: 
                    number += "quince"; 
                    break;
                case 16: 
                    number += "dieciseis"; 
                    break;
                case 17: 
                    number += "diecisiete"; 
                    break;
                case 18: 
                    number += "dieciocho"; 
                    break;
                case 19: 
                    number += "diecinueve"; 
                    break;
            }
        }

        return number;
    }
}