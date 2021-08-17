
using System;
class Multiplicar {
  static void Main() {
    Console.WriteLine("Introduzca un numero a multiplicar");
    int n = Convert.ToInt32(Console.ReadLine());
    
    if (n < 0){
        Console.WriteLine("Debe ingresar un numero mayor a cero");
    } else{
        for (int i=1; i<=10; i++){
            int resultado = i*n;
            Console.WriteLine(n + "X" + i + "=" + resultado);
        }
    }
    
  }
}

