/* Efetuar o cáluclo da área elevando o valor de raio ao quadrado e multiplicando por n;
   Considere n = 3.14159;
   Entrada: valor de ponto flutuante que é a variável raio;
   Saída: "A=" + valor da variável area com 4 casas após o ponto decimal;  */

using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {
        double raio = double.Parse(Console.ReadLine());
        double n = 3.14159;
        double area = n * (raio * raio);

        Console.WriteLine("A="+area.ToString("F4", CultureInfo.InvariantCulture));
    }
}