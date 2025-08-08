using System.Numerics;

class Program{
    static void Main(){
        string[] ss = Console.ReadLine().Split(' ');

BigInteger m = BigInteger.Parse(ss[0]);
BigInteger n = BigInteger.Parse(ss[1]);            

Console.WriteLine(m / n);
Console.WriteLine(m % n);
    }
}

