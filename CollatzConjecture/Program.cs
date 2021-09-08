using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace CollatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
			Stopwatch sw = new Stopwatch();
			sw.Start();

			int pow = 9;
			BigInteger max = BigInteger.Pow(10, pow);
			Console.WriteLine($"Checking numbers up to 10^{pow}");
			BigInteger sumCheck = 0;
			for (BigInteger i = 1; i < max + (max / 2); i += 2)
			{
				BigInteger x = i;
				if (x % 3 == 0)
					continue;
				else if (x % 3 == 1)
					x *= 4;
				else if (x % 3 == 2)
					x *= 2;
				while (((x - 1) / 3) < max)
				{ 
					sumCheck += (x - 1) / 3;
					x *= 4;
				}
			}

			sw.Stop();

			BigInteger sumOfNumbers = (BigInteger)(max / 4) * max;
			if(sumOfNumbers == sumCheck)
				Console.WriteLine($"Check Completed: {(double)sw.ElapsedMilliseconds/1000}s");
		}
    }
}
