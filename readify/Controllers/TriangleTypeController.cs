using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace readify.Controllers
{
    public class TriangleTypeController : ApiController
    {
        
        // GET api/<controller>/5
        public string Get(int a,int b,int c)
        {
            if (AllSidesAreEqual(a, b, c))
            {
                return ("Equilateral");
            }
            else if (AtLeastTwoSideAreEqual(a, b, c))
            {
                return ("Isoceles");
            }
            else
            {
                return ("Scalene");
            }
        }

        private static bool AllSidesAreEqual(int side1, int side2, int side3)
        {
            return (side1 == side2)
                && (side2 == side3);
        }

        private static bool AtLeastTwoSideAreEqual(int side1, int side2, int side3)
        {
            return (side1 == side2)
                || (side2 == side3)
                || (side1 == side3);
        }

    }
}