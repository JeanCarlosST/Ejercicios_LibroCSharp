using System;

namespace Cap5{
    public class Eje5_5{
        public static string Numeros(int n){
            
            string number = "";

            if(Math.Abs(n) >= 1000)
                return "Too much";

            else if(n == 0)
                return "cero";

            else if(n == 100)
                return "cien";

            else if(n < 0){
                number += "Negativo ";
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

            div = res/10;
            if(res%10 < 19)
                res = res%10;

            bool decena = false;
            switch(div){
                case 0: 
                    break;
                case 1:
                    res += 10;
                    break;
                case 2:
                    number += "veinte";
                    decena = true;
                    break;
                case 3:
                    number += "treinta";
                    decena = true;
                    break;
                case 4:
                    number += "cuarenta";
                    decena = true;
                    break;
                case 5:
                    number += "cincuenta";
                    decena = true;
                    break;
                case 6:
                    number += "sesenta";
                    decena = true;
                    break;
                case 7:
                    number += "setenta";
                    decena = true;
                    break;
                case 8:
                    number += "ochenta";
                    decena = true;
                    break;
                case 9:
                    number += "noventa";
                    decena = true;
                    break;
            }

            if(res > 0){
                if(decena && res < 10) number += "i";
                if(!centenas && !decena) res = n;
            
                switch(res){
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
}