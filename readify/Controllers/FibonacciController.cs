using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace readify.Controllers
{
    public class FibonacciController : ApiController
    {
        private static int Max = 92;
        // GET api/<controller>/5
        public long Get(long n)
        {
            if (n > Max || n < -Max)
            {
                throw new ArgumentException("Fib number beyond range.");
            }
            else
            {
                long a = 0;
                long b = 1;
                long result = 0;
                if (n == 0)
                {
                    result = 0;
                }
                else if (n > 0)
                {
                    result = FibonacciPositive(n, a, b);
                }
                else // in case of the input n is minus value
                {
                    result = FibonacciPositive(n * -1, a, b);

                    //shift the positive (n*-1) 1 bit right, then 1 bit left, to check is odd or even
                    //if the n is even, return the minus value.
                    if ((((n * -1) >> 1) << 1) == (n * -1))
                    {
                        result = result * -1;
                    }
                }

                return result;
            }
        }


        private long FibonacciPositive(long n, long a, long b)
        {
            long data = a;
            for (int i = 0; i < n; i++)
            {
                long temp = data;
                data = b;
                b = temp + b;
            }
            return data;
        }
    }


}
