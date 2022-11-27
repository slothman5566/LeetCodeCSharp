using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{

    public enum HeapType
    {
        Min,Max
    }
    public class Heap<T>
    {
        private readonly List<T> _Elements;
        private int _Size;
        protected HeapType _HeapType;
        private Func<T, T, bool> _CompareFunc;
        protected Comparer<T> _Comparer { get; private set; } = Comparer<T>.Default;
        public Heap( Comparer<T> comparer, HeapType type=HeapType.Min)
        {
           
            _Elements = new List<T>();
            _HeapType = type;
            _Comparer = comparer;
            switch (_HeapType)
            {
                case HeapType.Min:
                    _CompareFunc = (T left, T right) => _Comparer.Compare(left , right)<0;
                    break;
                case HeapType.Max:
                    _CompareFunc = (T left, T right) => _Comparer.Compare(left , right)>0;
                    break;
               
            }
        }

        private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
        private int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

        private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < _Size;
        private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < _Size;
        private bool IsRoot(int elementIndex) => elementIndex == 0;

        private T GetLeftChild(int elementIndex) => _Elements[GetLeftChildIndex(elementIndex)];
        private T GetRightChild(int elementIndex) => _Elements[GetRightChildIndex(elementIndex)];
        private T GetParent(int elementIndex) => _Elements[GetParentIndex(elementIndex)];

        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = _Elements[firstIndex];
            _Elements[firstIndex] = _Elements[secondIndex];
            _Elements[secondIndex] = temp;
        }

        public bool IsEmpty()
        {
            return _Size == 0;
        }

        public T Peek()
        {
            if (_Size == 0)
                throw new IndexOutOfRangeException();

            return _Elements[0];
        }

        public T Pop()
        {
            if (_Size == 0)
                throw new IndexOutOfRangeException();

            var result = _Elements[0];
            _Elements[0] = _Elements[_Size - 1];
            _Size--;

            ReCalculateDown();

            return result;
        }


        public void Add(T element)
        {
            _Elements.Add(element);
        
            _Size++;

            ReCalculateUp();
        }

        private void ReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && _CompareFunc(GetRightChild(index) , GetLeftChild(index)))
                {
                    smallerIndex = GetRightChildIndex(index);
                }

                if (!_CompareFunc(_Elements[smallerIndex] , _Elements[index]))
                {
                    break;
                }

                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }

        private void ReCalculateUp()
        {
            var index = _Size - 1;
            while (!IsRoot(index) && _CompareFunc( _Elements[index] , GetParent(index)))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        public int Count()
        {
            return _Size;
        }
    
    }
}
