using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Compress
{
    public class Compress
    {
        public async Task<string> GetCompressedString(string uncompressed)
        {
            string result = "";

            var uncompressedChar = !string.IsNullOrEmpty(uncompressed) ? uncompressed.Trim().ToCharArray() : null;

            var initialChar = ' ';
            var initialCharCount = 0;


            for (var i = 0; i < uncompressedChar.Length; i++)
            {
                if (i == 0)
                {
                    initialChar = uncompressedChar[i];
                    initialCharCount++;
                }

                else if(uncompressedChar[i] == initialChar)
                {
                    initialCharCount++;
                }
                else
                {
                    result = result + initialChar + initialCharCount.ToString();
                    initialChar = uncompressedChar[i];
                    initialCharCount = 1;
                }
            }

            result = result + initialChar + initialCharCount.ToString();


            return result;

        }
    }
}
