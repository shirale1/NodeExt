
namespace ConsoleApp1
{

    public class Program
    { 
  


        public static void Main()
        {
            Node<int> lst1 = new Node<int>(4, new Node<int>(5, new Node<int>(6, new Node<int>(7))));//[4, next]=>[5, next]=>[6, next]=>[7, next]=>null

            Console.WriteLine(NodeHelper.IsAscending(lst1));//should print True
            Console.WriteLine(NodeHelper.IsAscendingRecursive(lst1));//should print True
            Node<int> lst2 = new Node<int>(4, new Node<int>(5, new Node<int>(6, new Node<int>(2))));//[4, next]=>[5, next]=>[6, next]=>[2, next]=>null
            Console.WriteLine(NodeHelper.IsAscending(lst2));//should print False
            Console.WriteLine(NodeHelper.IsAscendingRecursive(lst2));//should print False
            Node<int> lst3 = new Node<int>(4, new Node<int>(5, new Node<int>(4, new Node<int>(9))));//[4, next]=>[5, next]=>[4, next]=>[9, next]=>null
            Console.WriteLine(NodeHelper.IsAscending(lst3));//should print False
            Console.WriteLine(NodeHelper.IsAscendingRecursive(lst3));//should print False

            Node<char> lst4 = new Node<char>('t', new Node<char>('A', new Node<char>('l', new Node<char>('s', new Node<char>('i')))));//['t', next]=>['a', next]=>['l', next]=>['s', next]=>['i', next]=>null
            Console.WriteLine(NodeHelper.IsExists(lst1, 5));//should print True
            Console.WriteLine(NodeHelper.IsExists(lst4, 'i'));//should print True
            Console.WriteLine(NodeHelper.IsExists(lst4, 'I'));//should print False
            Console.WriteLine(NodeHelper.IsExistsRecursive(lst1, 5));//should print True
            Console.WriteLine(NodeHelper.IsExistsRecursive(lst4, 'i'));//should print True
            Console.WriteLine(NodeHelper.IsExistsRecursive(lst4, 'I'));//should print False


        }
    }
}


