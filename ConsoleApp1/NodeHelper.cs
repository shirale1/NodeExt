using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NodeHelper
    {
        //פעולה המקבלת מצביע לחוליה 
        //מחזירה אמת אם החוליות מסודרות בסדר עולה
        //ושקר אחרת
        //אורך הקלט n:גודל השרשרת
        //המקרה הגרוע:כל החוליות בשרשרת גדולות מהחוליות שלפניהן
        //הפעולה מתבצעת 1 ובכל סיבוב הלולאה מתבצעות n סיבובים מכאן שסיבוכיות הפעולה:(O(n

        public static bool IsAscending(Node<int> lst)
        {
            int n;
            Node<int> p = lst;
            if (p != null)
            {
                n = p.GetValue();

                while (p != null)
                {
                    if (n > p.GetValue())
                        return false;
                    n = p.GetValue();
                    p = p.GetNext();


                }
                return true;
            }

            throw new NotImplementedException("TO DO");
        }


        //אורך הקלט n: אורך השרשרת
        //המקרה הגרוע: כל החוליות בשרשרת גדולות מהחוליות שלפניהן
        //הפעולה מבצעת n  קריאות ובכל קריאה הלולאה מתבצעות 6 כאן שסיבוכיות הפעולה: (o(n

        //כמו קודם רק מימוש רקורסיבי
        public static bool IsAscendingRecursive(Node<int> lst)
        {
            if (lst == null)
            { return true; }
            if (lst.HasNext() == true)
            {
                if (lst.GetNext().GetValue() < lst.GetValue())
                    return false;
                return IsAscendingRecursive(lst.GetNext());

            }
            throw new NotImplementedException("TO DO");
        }
        //פעולה גנרית המחזירה אמת אם 
        //x 
        //קיים בשרשרת החוליות 
        //lst
        //ושקר אחחרת
        //שימו לב שבפעולה גנרית אין 
        //לא ניתן להשתמש ב
        //==
        //יש להתשמש בפעולה של
        //object
        //Equals

        //אורך הקלט n: כמות החוליות בשרשרת
        //המקרה הגרוע: הטיפוס המבוקש לא נמצא בכל החוליות ולכן צריך לעבור על כולן
        //הפעולה מתבצעת פעם אחת
        //ובכל סיבוב הלולאה מתבצעת n
        //מכאן שסיבוכיות הפעולה: o(n)
        public static bool IsExists<T>(Node<T> lst, T x)
        {

            while (lst.HasNext() == true)
            {
                if (lst.GetValue().Equals(x))
                {
                    return true;
                }

                lst = lst.GetNext();

            }
            return false;


        }
        //אורך הקלט n:
        //המקרה הגרוע: הטיפוס המבוקש לא נמצא בכל החוליות ולכן צריך לעבור על כולן
        //הפעולה מבצעת n
        //קריאות ובכל קריאה הלולאה מתבצעות....
        //מכאן שסיבוכיות הפעולה: o(n)

        public static bool IsExistsRecursive<T>(Node<T> lst, T x)
        {
            if (lst == null)
            {
                return false;
            }
            if (lst.GetValue().Equals(x))
            {
                return true;
            }
            else
            {
                IsExistsRecursive(lst.GetNext(), x);
            }
            throw new NotImplementedException("TO DO");
        }
        public static Node<T> AddToStart<T>(Node<T> newnode, Node<T> lst)//הוספת חולייה לתחילת השרשרת
        {
            newnode.SetNext(lst);
            return newnode;//החזרת הראש החדש
        }
        public static void AddToEnd<T>(Node<T> newnode, Node<T> lst)//הוספת חולייה לסוף השרשרת
        {
            while (lst.HasNext())
            {
                lst = lst.GetNext();
            }
            lst.SetNext(newnode);
        }
        public static void AddMiddle(Node<int> newnode, Node<int> lst)
        {
            while(lst.HasNext() && lst.GetNext().GetValue() < newnode.GetValue())// מגיעים למקום הרצוי, אחד לפני
            {
                lst = lst.GetNext();
            }
            //שלב שני נחבר את הנקסט של החדשה לחולייה הבאה
            newnode.SetNext(lst.GetNext());
            //מחברים את הנקסט  לחולייה החדשה
            lst.SetNext(newnode);
        }
        public static Node<int> Create(int from, int to, int quantity)//פעוך שמקבלת מספר מ- ועד וכמות ויוצרת שרשרת חוליות באורך הכמות שהמספרים בה הם בין הערכים שקיבלנו
        {
            Random random = new Random();
            Node<int> head = new Node<int>(random.Next(from, to + 1));

            for (int i = 0; i < quantity; i++)
            {
                head = new Node<int>(random.Next(from, to + 1), head);

            }
            return head;
        }
       public static Node<T> DeleteValue<T>(Node<T> lst, T value) //מחיקת חולייה בעלת הערך שהתקבל
        {
            Node<T> head = lst;
            if (lst == null)
            {
                return head;
            }
            if(lst.GetValue().Equals(value))
            {
                head = lst.GetNext();
                lst.SetNext(null);
                return head;
            }
            Node<T> next = lst.GetNext();
            while (lst.HasNext() && !next.GetValue().Equals(value))
            {
                lst = next;
                next = lst.GetNext();
            }
            lst.SetNext(next.GetNext());
            next.SetNext(null);
            return head;
        }
    }
}

