using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores
{
    struct dados
    {
        public int[,]X;  
        // divisor para bi dimensional ou tri dimensional depende do  (,) exemplo [,]  bi dimensional
     



        public dados (int[,] x)
        {
            this.X = x;

        }
    }
}
