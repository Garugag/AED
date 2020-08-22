using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int numero1, numero2, numero3, numero4, resultado;
    Console.WriteLine ("Insira um numero inteiro: ");
    numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Insira um numero inteiro: ");
    numero2 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Insira um numero inteiro: ");
    numero3 = int.Parse(Console.ReadLine());Console.WriteLine ("Insira um numero inteiro: ");
    numero4 = int.Parse(Console.ReadLine());
    resultado = (numero1 + numero2 + numero3 + numero4)/4;
    Console.WriteLine("O resultado é: " + resultado);
    Console.ReadLine();
  }
}
