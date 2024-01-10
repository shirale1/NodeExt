﻿using System;
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
        public static int WhichBigger(Node<int> lst1,Node<int> lst2) 
            //כתוב פעולה חיצונית המקבלת שתי רשימות  כל רשימה מייצגת מספר שלם גדול מאוד.
            // מספר שלם גדול מאוד יוצג ברשימה באופן הבא: כל חולייה ברשימה מכילה ספרה של המספר
            //הספרה האחרונה ברשימה היא ספרת האחדות
            //על הפעולה להחזיר 1 אם המספר המיוצג ברשימה הראשונה גדול יותר, 2 אם המספר השני גדול יותר
            //ו0 אם המספרים שווים
        {
            int count1 = 0;
            int count2 = 0;
            Node<int> head1 = lst1;
            Node<int> head2 = lst2;
            while(lst1!= null)
            {
                count1++;
                lst1 = lst1.GetNext();
            }
            lst1 = head1;
            while (lst2 != null)
            {
                count2++;
                lst2 = lst2.GetNext();
            }
            lst2 = head2;
            if (count1 > count2)
            {
                return 1;
            }
            if(count1 < count2)
            {
                return 2;
            }
           
            
                while (lst1!= null)
                {
                    if (lst1.GetValue() > lst2.GetValue())
                    {
                        return 1;
                    }
                    else if (lst1.GetValue() < lst2.GetValue())
                    {
                        return 2;
                    }
                    lst1 = lst1.GetNext();
                    lst2 = lst2.GetNext();
                }
                return 0;
             
            
        }
    }
}
