using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarintKata.Entities
{
    public class Varint
    {
        public string ConvertVarToInt(int number)
        {
            return ConvertIntToBinary(number);
        }

        private string ConvertIntToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
