using System;
using System.Collections.Generic;

namespace Dimitrije
{
    public class Stack<T>
    {
        private readonly List<T> _list = new List<T>();

        public int Count = 0;

        public void Push(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException();
            
            _list.Add(obj);
        }

        public T Pop()
        {
            
            var result = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);

            return result; 
        }


        public T Peek()
        {
            if (_list.Count < 1)
                throw new InvalidOperationException();

            return _list[_list.Count - 1];
        }
    }
}