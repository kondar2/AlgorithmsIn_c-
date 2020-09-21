using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gilb_More
{
    class Element
    {
        public char symbol;
        public double frequency;  //частота
        public double qumulativeFrequency;  //кумулятивная частота
        public double sigma = 0;
        public string sigmaBinary = "";
        public double length = 0;
        public string code = "";


        public Element(char symbol, double frequency)
        {
            this.symbol = symbol;
            this.frequency = frequency;
        }
    }
}
