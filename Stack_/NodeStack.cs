using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack_ {
    public class NodeStack<T> : IEnumerable<T> {
        private Node<T> head;
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

        public void Push(T item) {
            var node = new Node<T>(item);
            node.Next = head;
            head = node;
            count++;
        }

        public T Pop() {
            if (IsEmpty) {
                throw new InvalidOperationException("Стек пуст");
            }
            Node<T> temp = head;
            head = head.Next;
            count--;
            return temp.Data;
        }

        public T Peek() {
            if (IsEmpty) {
                throw new InvalidOperationException("Стек пуст");
            }
            return head.Data;
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
