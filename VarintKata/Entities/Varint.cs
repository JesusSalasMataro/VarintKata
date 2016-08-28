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
            List<string> bytes = new List<string>();

            string binaryRepresentation = ConvertIntToBinary(number);
            int binaryRepresentationLength = binaryRepresentation.Length;

            if (binaryRepresentationLength > 8)
            {
                for (int i = 0; i <= binaryRepresentationLength / 8; i++)
                {
                    if (IsLastByte(binaryRepresentationLength, i))
                    {
                        bytes.Add(binaryRepresentation.Substring(0, binaryRepresentationLength - 7 * i));                       
                    } 
                    else
                    {
                        bytes.Add(binaryRepresentation.Substring(binaryRepresentationLength - 7 * (i + 1), 7));
                    }                    
                }

                for (int i = 0; i < bytes.Count; i++)
                {
                    if (i == bytes.Count - 1)
                    {
                        varint = varint + " 0" + bytes[i].PadLeft(7, '0');
                    }
                    else
                    {
                        varint = varint + " 1" + bytes[i];
                    }                    
                }

                varint = varint.Trim();
            }
            else
            {
                varint = binaryRepresentation;
            }

            return varint;
        }

        private bool IsLastByte(int binaryRepresentationLength, int i)
        {
            return i == binaryRepresentationLength / 8;
        }

        private string ConvertIntToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
