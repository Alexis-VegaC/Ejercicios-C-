/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class Factorial {

  static void Main() {
    
    Console.WriteLine("Introduzca un numero entero del 1 al 10");
    int n = Convert.ToInt32(Console.ReadLine());
    
    
    if (n < 0 || n>10){
        
        Console.WriteLine("Debe ingresar un numero entero dentro del rango");
    } else{
        Console.WriteLine("El resultado es: " + factorial(n));
    }
        
    }
    
    public static int factorial(int n){
        int i = 2;
        int resultado = 1;
        
        while (i<=n) {
            resultado *= i;
            i++;
        }
        
        return resultado;
  }
}
