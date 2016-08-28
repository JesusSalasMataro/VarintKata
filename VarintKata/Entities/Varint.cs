using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarintKata.Entities
{
    public class Varint
    {
        public string ConvertIntToVarint(int number)
        {
            string varint = "";
            string lessSignificantBits = "";
            string moreSignificantBits = "";

            string binaryRepresentation = ConvertIntToBinary(number);
            int binaryRepresentationLength = binaryRepresentation.Length;

            if (binaryRepresentationLength > 8)
            {
                lessSignificantBits = binaryRepresentation.Substring(binaryRepresentationLength - 7, 7);
                moreSignificantBits = binaryRepresentation.Substring(0, binaryRepresentationLength - 7);

                varint = "1" + lessSignificantBits + " 0" + moreSignificantBits.PadLeft(7, '0');
            }
            else
            {
                varint = binaryRepresentation;
            }

            return varint;
        }

        private string ConvertIntToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
