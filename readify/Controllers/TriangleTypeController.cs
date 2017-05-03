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
        [Serializable]
        public enum TriangleType : int
        {

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Error = 0,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Equilateral = 1,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Isosceles = 2,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Scalene = 3,
        }
        // GET api/<controller>/5
        public TriangleType Get(int a,int b,int c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || ((b + c) <= a) || ((a + c) <= b) || ((a + b) <= c))
            {
                return TriangleType.Error;
            }
            else
            {
                // hashset ignores the int value already exists in the set.
                HashSet<int> lines = new HashSet<int>();
                lines.Add(a);
                lines.Add(b);
                lines.Add(c);

                return lines.Count == 1 ? TriangleType.Equilateral : lines.Count == 2 ? TriangleType.Isosceles : TriangleType.Scalene;
            }
        }


    }
}