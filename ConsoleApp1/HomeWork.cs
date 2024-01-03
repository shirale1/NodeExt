using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HomeWork
    {
        public int ReturnRetzf(Node<int> lst,int x) 
        {
            int counter = 0;
            while(lst != null && lst.HasNext())
            {
                if (lst.GetValue() == x && lst.GetNext().GetValue()!=x)
                {
                    counter++;
                }
                while(lst.GetValue()==x)
                {
                    if (lst.GetNext().GetValue() != x)
                    {
                        counter++;
                    }
                }
                lst=lst.GetNext();
            }
            if (lst.GetValue() == x)
                return counter + 1;
            return counter;
        }
    }
}
