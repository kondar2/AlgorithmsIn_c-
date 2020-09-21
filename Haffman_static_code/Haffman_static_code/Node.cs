using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haffman_static_code
{
    class Node : IComparable<Node>  
    {
        public string symbol;
        public double frequency;
        public string code = "";
        public Node parentNode;
        public List<Node> _children;

        public Node (string symbol, double frequency)
        {
            this.symbol = symbol;
            this.frequency = frequency;
            _children = new List<Node>();
        }

        public override string ToString()
        {
            return symbol + ", " + frequency.ToString() + "," + code; 
        }
        
        
        
        public int CompareTo(Node other)  //создание интерфейса для сортировки объектов класса
        {
            var result = -this.frequency.CompareTo(other.frequency);
            if (result == 0)
            {
                return this.symbol[0].CompareTo(other.symbol[0]);
            }
            return result;
        }
        
        // The example displays the following output:
        //       Comparing 16325 and 0: 1 (GreaterThan).
        //       Comparing 16325 and 16325: 0 (Equal).
        //       Comparing 16325 and -1934: 1 (GreaterThan).
        //       Comparing 16325 and 903624: -1 (LessThan).

        public string GetCode()
        {
            var res = "";
            if (parentNode != null)
            {
                res += parentNode.GetCode();
            }
            return res + code;
        }










    }
}
