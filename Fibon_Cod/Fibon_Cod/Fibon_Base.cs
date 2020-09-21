using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibon_Cod
{
    class Fibon_Base
    {

        public int Radix { get; set; }

        public Fibon_Base()
        {
            Radix = 1;
        }

        public void ResetRadix()
        {
            Radix = 1;
        }

        public int GetFibMember(int position)
        {
            if (position == 1)
            {
                return 1;
            }

            if (position == 2)
            {
                return 2;
            }

            return GetFibMember(position - 1) + GetFibMember(position - 2);
        }

        public int CalculateBiggestRadixForNumber(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            int iterator = 1;

            while (number - GetFibMember(iterator) >= 0)
            {
                iterator++;
            }
            return GetFibMember(iterator - 1);
        }

        public int FindMemberPosition(int member)
        {
            int i = 1;

            while (member >= GetFibMember(i))
            {
                if (member == GetFibMember(i))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

       
        


    }
}
