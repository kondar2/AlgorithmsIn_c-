using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FACT_code
{
    class FACT_base
    {
        public int Radix { get; set; }  // инициализируем сис счисл

        public FACT_base()
        {
            Radix = 2;  //основание сис счисл по умолчанию
        }

        public void ResetRadix()
        {
            Radix = 2;
        }

    }
}
