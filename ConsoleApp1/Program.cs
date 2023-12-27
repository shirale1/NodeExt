namespace ConsoleApp1
{

    public class Program
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
                Node<T> p = lst;
                while (lst.HasNext() == true)
                {
                    if (p.GetValue().Equals(x))
                    {
                        return true;
                    }
                    else
                    {
                        p = p.GetNext();
                    }
                }
                return false;
                throw new NotImplementedException("TO DO");

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
    }
    
 
    public static void Main()
    {
        Node<int> lst1 = new Node<int>(4, new Node<int>(5, new Node<int>(6, new Node<int>(7))));//[4, next]=>[5, next]=>[6, next]=>[7, next]=>null

        Console.WriteLine(IsAscending(lst1));//should print True
        Console.WriteLine(IsAscendingRecursive(lst1));//should print True
        Node<int> lst2 = new Node<int>(4, new Node<int>(5, new Node<int>(6, new Node<int>(2))));//[4, next]=>[5, next]=>[6, next]=>[2, next]=>null
        Console.WriteLine(IsAscending(lst2));//should print False
        Console.WriteLine(IsAscendingRecursive(lst2));//should print False
        Node<int> lst3 = new Node<int>(4, new Node<int>(5, new Node<int>(4, new Node<int>(9))));//[4, next]=>[5, next]=>[4, next]=>[9, next]=>null
        Console.WriteLine(IsAscending(lst3));//should print False
        Console.WriteLine(IsAscendingRecursive(lst3));//should print False

        Node<char> lst4 = new Node<char>('t', new Node<char>('A', new Node<char>('l', new Node<char>('s', new Node<char>('i')))));//['t', next]=>['a', next]=>['l', next]=>['s', next]=>['i', next]=>null
        Console.WriteLine(IsExists(lst1, 5));//should print True
        Console.WriteLine(IsExists(lst4, 'i'));//should print True
        Console.WriteLine(IsExists(lst4, 'I'));//should print False
        Console.WriteLine(IsExistsRecursive(lst1, 5));//should print True
        Console.WriteLine(IsExistsRecursive(lst4, 'i'));//should print True
        Console.WriteLine(IsExistsRecursive(lst4, 'I'));//should print False


    }


}


