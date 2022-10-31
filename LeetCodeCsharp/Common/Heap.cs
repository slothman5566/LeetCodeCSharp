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
        private readonly List<T> _elements;
        private int _size;
        protected HeapType _HeapType;
        private Func<T, T, bool> _CompareFunc;
        protected Comparer<T> _Comparer { get; private set; } = Comparer<T>.Default;
        public Heap(int size, Comparer<T> comparer, HeapType type=HeapType.Min)
        {
           
            _elements = new List<T>();
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

        private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < _size;
        private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < _size;
        private bool IsRoot(int elementIndex) => elementIndex == 0;

        private T GetLeftChild(int elementIndex) => _elements[GetLeftChildIndex(elementIndex)];
        private T GetRightChild(int elementIndex) => _elements[GetRightChildIndex(elementIndex)];
        private T GetParent(int elementIndex) => _elements[GetParentIndex(elementIndex)];

        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = _elements[firstIndex];
            _elements[firstIndex] = _elements[secondIndex];
            _elements[secondIndex] = temp;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public T Peek()
        {
            if (_size == 0)
                throw new IndexOutOfRangeException();

            return _elements[0];
        }

        public T Pop()
        {
            if (_size == 0)
                throw new IndexOutOfRangeException();

            var result = _elements[0];
            _elements[0] = _elements[_size - 1];
            _size--;

            ReCalculateDown();

            return result;
        }


        public void Add(T element)
        {
            _elements.Add(element);
        
            _size++;

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

                if (!_CompareFunc(_elements[smallerIndex] , _elements[index]))
                {
                    break;
                }

                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }

        private void ReCalculateUp()
        {
            var index = _size - 1;
            while (!IsRoot(index) && _CompareFunc( _elements[index] , GetParent(index)))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

    
    }
}
