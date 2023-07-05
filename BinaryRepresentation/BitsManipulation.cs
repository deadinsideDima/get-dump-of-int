using System;

namespace BinaryRepresentation
{
    public static class BitsManipulation
    {
        /// <summary>
        /// Get binary memory representation of signed long integer.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Binary memory representation of signed long integer.</returns>
        public static string GetMemoryDumpOf(long number)
        {
            string str = string.Empty;
            bool b = false;
            if (number < 0)
            {
                b = true;
                number = ~number;
            }

            while (number != 0)
            {
                str = (number & 1) + str;
                number >>= 1;
            }

            while (str.Length < 64)
            {
                str = '0' + str;
            }

            if (b)
            {
                string sTemp = string.Empty;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '0')
                    {
                        sTemp = new string(sTemp + '1');
                    }
                    else
                    {
                        sTemp = new string(sTemp + '0');
                    }
                }

                str = sTemp;
            }

            return str;
        }
    }
}
