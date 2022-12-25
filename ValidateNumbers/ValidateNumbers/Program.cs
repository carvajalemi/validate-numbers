using System;

class Program {
  public static void Main (string[] args) {
   int a = Leer("ingrese Valor1: ");
   int b = Leer("ingrese Valor2: ");
    Console.WriteLine("El valor de a: "+a);
    Console.WriteLine("El valor de b: "+b);
         
  }
  
  public static int Leer(string mensaje)
  {
    int intentos = 0;
    while (intentos < 3)
    {
      Console.WriteLine(mensaje);
      string numeroComoString = Console.ReadLine();
      int valorReal=0;
      if(!int.TryParse(numeroComoString, out valorReal))
      {
        Console.WriteLine("valor ingresado invalido, intente de nuevo ...");
        intentos++; // intentos = intentos +1
      }
      else
      {
          valorReal=Int32.Parse(numeroComoString);
          return valorReal;
      }
    }
     throw new Exception("No se pude leer nada");
  }
 
}