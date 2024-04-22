using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4___Actividad_1
{
    class GeneradorNumeros
    {
        public int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        public int Primo(int n)
        {
            int count = 0;
            int num = 2;
            while (count < n)
            {
                bool esPrimo = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                    count++;
                num++;
            }
            return num - 1;
        }

        public int NumeroPerfecto(int n)
        {
            int count = 0;
            int num = 2;
            while (count < n)
            {
                int sum = 1;
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        if (i * i != num)
                            sum = sum + i + num / i;
                        else
                            sum = sum + i;
                    }
                }
                if (sum == num)
                    count++;
                num++;
            }
            return num - 1;
        }
    }
}
