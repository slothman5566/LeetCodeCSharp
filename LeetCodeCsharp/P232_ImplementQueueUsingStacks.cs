using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P232_ImplementQueueUsingStacks
{
    public class MyQueue
    {
        protected Stack<int> _First ;
        protected Stack<int> _Second ;

        public MyQueue()
        {
            _First = new Stack<int>();
            _Second = new Stack<int>();
        }

        public void Push(int x)
        {
            
            _First.Push(x);
        }

        public int Pop()
        {

            while (_First.Any())
            {
                _Second.Push(_First.Pop());
            }
          return  _Second.Pop();

        }

        public int Peek()
        {
            while (_First.Any())
            {
                _Second.Push(_First.Pop());
            }
            return _Second.Peek();
        }

        public bool Empty()
        {
            return !(_Second.Any() || _First.Any());
        }
    }
}
