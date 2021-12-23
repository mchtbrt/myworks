using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._12
{
    class RandomTc
    {
        Random rnd = new Random();
        int ran = 0;
    public int SayiTut(int sayi)
        {
            if (sayi == 1)
            {
                 ran = rnd.Next(1, 100);
                if (ran %2 == 0)
                {
                    ran += 1;
                }
            }

            else if (sayi ==2)
            {
                 ran = rnd.Next(1, 100);
                if (ran % 2 == 1)
                {
                    ran += 1;
                }
            }

            return ran;

        }
    
    
    
    }
}
