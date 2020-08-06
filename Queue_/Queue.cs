using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Queue_ {
    public class Queue<T> : IEnumerable<T> {

        private Node<T> head;
        private Node<T> tail;
        private int count;

        public int Count {
            get {
                return count;
            }
        }

        public bool IsEmpty {
            get {
                return count == 0;
            }
        }

        public T First {
            get {
                if (IsEmpty) {
                    throw new InvalidOperationException("Очередь пуста");
                }
                return head.Data;
            }
        }

        public T Last {
            get {
                if (IsEmpty) {
                    throw new InvalidOperationException("Очередь пуста");
                }
                return tail.Data;
            }
        }

        public void Enqueue(T data) {
            var node = new Node<T>(data);
            Node<T> temp = tail;
            tail = node;

            if (IsEmpty) {
                head = tail;
            } else {
                temp.Next = tail;
            }
            count++;
        }

        public T Dequeue() {
            if (IsEmpty) {
                throw new InvalidOperationException("Очередь пуста");
            }

            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }

        public void Clear() {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data) {
            Node<T> current = head;
            while (current != null) {
                if (current.Data.Equals(data)) {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() {
            Node<T> current = head;
            while (current != null) {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
