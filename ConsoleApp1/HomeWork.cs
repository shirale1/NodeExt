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
        //נתונות שתי רשימות. נתון שהרשימה השנייה  מוכלת ברצף ברשימה הראשונה פעם אחת בלבד
        //כתוב פעולה חיצונית המקבלת את שתי הרשימות ומבטלת את הרשימה השנייה המופיעה ברצף ברשימה הראשונה 
        //הרשימה השנייה תישאר ללא שינוי
        public static Node<int> Delete2From1(Node<int> lst1, Node<int> lst2)
        {
            //הערה
            Node<int> head1 = lst1;
            Node<int> head2 = lst2;
            while(lst1!= null)
            {
                if(lst1.GetValue() == lst2.GetValue()) { }
            }
            //לעשות פעולת עזר שמחזירה את המיקום בחוליה הגדולה של תחילת החולייה הקטנה 
            //לנתק את כל הרצף
            //לסיים את הפעולה
        }
        public static Node<T> Merge<T>(Node<T> lst1, Node<T> lst2)
            //n אורך השרשרת lst1
            //m אורך השרשרת lst2
            //o(min(m/n)) +0(|m-n|) 
            //o(max(n,m))
            //  אפשר גם להגדיר את אורך הקלט לאורך השרשרת הגדולה                             

        {
           Node<T> head= new Node<T>(lst1.GetValue());
              lst1=lst1.GetNext();
            Node<T> current = head;
            while(lst2!= null && lst1 != null)
            {
                current.SetNext(new Node<T>(lst2.GetValue())); 
                current = current.GetNext();
                current.SetNext(new Node<T>(lst1.GetValue()));
                current = current.GetNext();
                lst1 = lst1.GetNext();
                lst2 = lst2.GetNext();
            }
            while(lst1!= null)
            {
                current.SetNext(new Node<T>(lst1.GetValue())); 
                current = current.GetNext();
                lst1 = lst1.GetNext();
            }
            while (lst2 != null)
            {
                current.SetNext(new Node<T>(lst2.GetValue()));
                current = current.GetNext();
                lst2 = lst2.GetNext();
            }
            return head;
        }

    }
}
