using System;
using System.Collections.Generic;
using System.Text;

namespace PP_lLitmosAPI.LitmosAPI
{
    class LitmosAPI
    {
        // Returns json string (if were real)
        public string LitmosStuff()
        {

            string result = string.Empty;

            int num = RandomNumber(0, 2);
            switch (num)
            {
                case 0:
                    result = "First";

                    break;
                case 1:
                    result = "Second";

                    break;
                case 2:
                    result = "Third";

                    break;
                default:
                    result = "None";

                    break;
            }

            return result;

        }

        Random _random = new Random();

        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

    }

}
