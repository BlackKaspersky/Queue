using System.Collections;

namespace Queue
{
    public class Queue<T> : IEnumerable<T>
    { 
        int count;
        Node<T>? head;
        Node<T>? tail;


        public int Count { get { return count; } }
        
        public bool IsEmpty { get { return count == 0; } }


        public void Enqueue(T data)
        {
            var node = new Node<T>(data);
            if (head == null)
                head = node;
            else
                tail!.Next = node;
            tail = node;
            count++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new InvalidDataException();
            var headData = head!.Data;
            head = head.Next;
            count--;
            return headData;
        }

        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidDataException();
                return head!.Data;
            }
        }

        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidDataException();
                return tail!.Data;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contain(T data)
        {
            var current = head;
            while(current != null)
            {
                if(current.Data.Equals(data))
                    return true;

                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
