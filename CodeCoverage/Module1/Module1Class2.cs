using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public class Module1Class2
    {
        public int Module1Class2Method1(int result)
        {
            int i = 9;
            if(i == 10) {
                return 10;
            }
            if(i == 9) {
                result = 9;
            }
            else if(result > 0)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            return 1;
        }
    }
}
