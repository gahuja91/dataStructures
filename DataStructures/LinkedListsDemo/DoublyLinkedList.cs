using System.Collections;
using System.Collections.Generic;

namespace LinkedListsDemo
{
    public class DoublyLinkedList<T> : ICollection<T>
    {
        #region ICollection
        public int Count => throw new System.NotImplementedException();

        public bool IsReadOnly => throw new System.NotImplementedException();

        public void Add(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
        #endregion

        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }

        public void AddHead(T value)
        {
            DoublyLinkedListNode<T> newHead = new DoublyLinkedListNode<T>(value);

            if (Head != null)
            {
                Head.Previous = newHead;
                newHead.Next = Head;
            }

            Head = newHead;

            if (Tail == null)
                Tail = Head;

            Count++;
        }
        //public bool GetHead(out T value) { }
        //public bool GetTail(out T value) { }
    }
}
