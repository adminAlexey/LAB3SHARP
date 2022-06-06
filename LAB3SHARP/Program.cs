/*Реализовать набор коллекций, реализующих стандартные интерфейсы по работе с коллекциями из пространства имен System.Collections.*/

namespace lab3;

interface IEnumerable
{

}

interface ICollection
{

}

interface IList
{

}

interface IDictinary
{

}

class MyList : List
{
    private object[] _contents = new object[8];
    private int _count;
    public void Clear()
    {
        _count = 0;
    }

    public int Add(object value)
    {
        if (_count < _contents.Length)
        {
            _contents[_count] = value;
            _count++;

            return (_count - 1);
        }

        return -1;
    }

    public int Count
    {
        get
        {
            return _count;
        }
    }

    public int IndexOf(object value)
    {
        
        for (int i = 0; i < Count; i++)
        {
            if (_contents[i] == value)
            {
                return i;
            }
        }
        return -1;
    }
}

class List : IList
{
    public string Name { get; set; }
}

class Queue : ICollection, IEnumerable
{
    public string Name { get; set; }
    public int Count { get; set; }
}

class Dictinary : IDictinary
{
    public string Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List list = new List();
        list.Name = "IamList";

        Queue queue = new Queue();
        queue.Name = "Q";
        queue.Count++;
        
        Dictinary dictinary = new Dictinary();
        dictinary.Name = "ddd";

        MyList list2 = new MyList();
        list2.Clear();
        list2.Add(3);
        list2.IndexOf(2);

    }

}