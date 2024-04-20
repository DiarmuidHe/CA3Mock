using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT1
{
    internal class checker
    {

        public int intergerVerify
        {
            get; set;
        }
        public checker() 
        { 
            
        }
        public checker(string num)
        {
            int numOut;
            while (!int.TryParse(num, out numOut) || num == null )
            {
                Console.WriteLine("Invalid number please try again" );
            }
        }
    }
}
