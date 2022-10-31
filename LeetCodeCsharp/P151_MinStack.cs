using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P151_MinStack
{
    public class MinStack
    {
        protected Stack<int> _data = new Stack<int>();
        protected Stack<int> _min = new Stack<int>();
        public MinStack()
        {

        }

        public void Push(int val)
        {
            _data.Push(val);
            if(_min.Count==0 || _min.Peek() > val)
            {
                _min.Push(val);
            }
            else
            {
                _min.Push(_min.Peek());
            }
        }

        public void Pop()
        {
            _data.Pop();
            _min.Pop();
        }

        public int Top()
        {
            return _data.Peek();
        }

        public int GetMin()
        {
           return _min.Peek();
        }
    }
}
