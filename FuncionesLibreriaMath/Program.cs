﻿int Num;
string Linea;
long Resul;
Console.WriteLine("Digite un numero: ");
Linea = Console.ReadLine();
Num = int.Parse(Linea);
Resul = Math.Abs(Num);
Console.WriteLine("Valor Absoluto: " + Resul);
Console.WriteLine("Potencia: " + Math.Pow(Num, 3));
Console.WriteLine("Raiz Cuadrada: " + Math.Sqrt(Num));
Console.WriteLine("Seno : " + Math.Sin(Num * Math.PI/180));
Console.WriteLine("Seno : " + Math.Cos(Num * Math.PI / 180));
Console.WriteLine("Numero Maximo: " + Math.Max(Num, 50));
Console.WriteLine("Numero Minimo: " + Math.Min(Num, 50));
Console.WriteLine("Parte entera: " + Math.Truncate(18.78));
Console.WriteLine("Redondeo: " + Math.Round(18.78));
Console.WriteLine("precionar cualquier tecla para salir: ");
Console.ReadLine();
