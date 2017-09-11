using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class LinkedList : ICollection, IEnumerable, IList
    {
        private LinkNode first;
        private LinkNode last;

        private int count = 0;

        /// <summary>
        /// Creates an empty LinkedList.
        /// </summary>
        public LinkedList()
        {}

        /// <summary>
        /// Creates a LinkedList that starts with every element in the given value.
        /// If copying is null or has no elements, this will create an empty list.
        /// </summary>
        /// <param name="copying">An IEnumerable to copy values from</param>
        public LinkedList(IEnumerable copying)
        {
            if(copying != null)
                foreach (Object val in copying)
                    AddLast(val);
        }

        public Object First
        {
            get
            {
                return first.Val;
            }
            set
            {
                first.Val = value;
            }
        }
        public Object Last
        {
            get
            {
                return last.Val;
            }
            set
            {
                last.Val = value;
            }
        }

        
        public object this[int index]
        {
            get
            {
                return Node(index).Val;
            }
            set
            {
                Node(index).Val = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => false;

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public int Add(object value)
        {
            return AddLast(value);
        }

        public int AddFirst(object value)
        {
            if (count == 0)
            {
                LinkNode node = new LinkNode(value);
                first = node;
                last = node;
            }
            else
            {
                LinkNode newFirst = new LinkNode(value, null, first);
                first.Previous = newFirst;
                first = newFirst;
            }
            count++;
            return 0;
        }
        public int AddLast(object value)
        {
            if (count == 0)
            {
                LinkNode node = new LinkNode(value);
                first = node;
                last = node;
            }
            else
            {
                LinkNode newLast = new LinkNode(value, last, null);
                last.Next = newLast;
                last = newLast;
            }
            count++;

            return count - 1;//index of new last element
        }

        public void Insert(int index, object value)
        {
            InsertBefore(index, value);
        }
        public void InsertBefore(Object index, Object value)
        {
            LinkNode node = Node(index);

            if (node == null) throw new IndexOutOfRangeException("Object not in list.");
            
            //create node and shift pointers
            LinkNode newNode = new LinkNode(value, node.Previous, node);

            node.Previous.Next = newNode;
            node.Previous = newNode;
        }
        public void InsertAfter(Object index, Object value)
        {
            LinkNode node = Node(index);

            if (node == null) throw new IndexOutOfRangeException("Object not in list.");

            //create node and shift pointers
            LinkNode newNode = new LinkNode(value, node, node.Next);

            node.Next.Previous = newNode;
            node.Next = newNode;
        }
        public void InsertBefore(int index, Object value)
        {
            if (index >= count) throw new IndexOutOfRangeException();

            LinkNode node = Node(index);

            //create node and shift pointers
            LinkNode newNode = new LinkNode(value, node.Previous, node);

            node.Previous.Next = newNode;
            node.Previous = newNode;
        }
        public void InsertAfter(int index, Object value)
        {
            if(index == count) { AddLast(value); return; }

            LinkNode node = Node(index);

            //create node and shift pointers
            LinkNode newNode = new LinkNode(value, node, node.Next);

            node.Next.Previous = newNode;
            node.Next = newNode;
        }
        
        public void Remove(object value)
        {
            if (count == 0) return;

            LinkNode node = Node(value);

            if (node == null)//value not found
            {
                return;
            }
            else if (node == first)//first node
            {
                first = node.Next;
                first.Previous = null;
                return;
            }
            else if (node == last)//last node
            {
                last = last.Previous;
                last.Next = null;
                return;
            }

            //move around pointers
            LinkNode prev = node.Previous;
            LinkNode next = node.Next;
            prev.Next = next;
            next.Previous = prev;
        }

        public void RemoveAt(int index)
        {
            LinkNode node = Node(index);

            //move around pointers
            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
        }

        public void Clear()
        {
            first = null;
            last = null;
            count = 0;
        }

        public bool Contains(object value)
        {
            return Node(value) == null;
        }

        public void CopyTo(Array array, int index)
        {
            LinkNode node = first;
            for (int i = index; i < array.Length && i - index < count; i++)
            {
                array.SetValue(node.Val, i);
                node = node.Next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new LinkedListIterator(this);
        }

        public int IndexOf(object value)
        {
            LinkNode node = first;
            int i = 0;
            //keep going down list as long as you have not found the end or a matching node
            while(node != null && !(node.Val == null ? value == null : node.Val.Equals(value)))
            {
                node = node.Next;
                i++;
            }

            if (node == null) return -1;//reached end without a match
            else return i;
        }
        
        private LinkNode Node(int index)
        {
            if (index >= count || index < 0) throw new IndexOutOfRangeException();

            //save time/processing by iterating from closest end
            if (index < count / 2)
            {
                LinkNode node = first;
                int i = 0;
                while (i < index)
                {
                    i++;
                    node = node.Next;
                }
                return node;
            }
            else
            {
                LinkNode node = last;
                int i = count - 1;
                while (i > index)
                {
                    i--;
                    node = node.Previous;
                }
                return node;
            }
        }

        private LinkNode Node(Object val)
        {
            LinkNode node = first;
            //goes down list until it finds end or finds a match
            /*
             * if the node is null, you're at the end. object not found.
             * 
             * matching deconstructed:
             * 
             * if node value is null:
             *   return true if val is also null
             * else
             *   return true if they are equal (Equals method checks if val is null)
             */
            while (node != null && !(node.Val == null ? val == null : node.Val.Equals(val)))
            {
                node = node.Next;
            }
            return node;
        }


        class LinkNode
        {
            public LinkNode Previous;
            public LinkNode Next;
            public Object Val;

            public LinkNode(Object obj) : this(obj, null, null) { }
            public LinkNode(Object obj, LinkNode previous, LinkNode next)
            {
                Val = obj;
                Previous = previous;
                Next = next;
            }

        }

        class LinkedListIterator : IEnumerator
        {
            private LinkedList underlying;
            private LinkNode current;
            bool started = false;

            public LinkedListIterator(LinkedList underlying)
            {
                this.underlying = underlying;
                current = underlying.first;
            }

            //should this throw an exception if the node is null?
            public object Current => current?.Val;

            public bool MoveNext()
            {
                if(!started)
                {
                    Reset();
                    started = true;
                    return current != null;
                }

                current = current?.Next;
                return current != null;
            }
            
            public void Reset()
            {
                current = underlying.first;
            }
        }//class(LinkedListIterator)
    }//class(LinkedList)

    public static class MyUtils
    {
        public static object Next(this IEnumerator e)
        {
            e.MoveNext();
            return e.Current;
        }
    }
}//namespace
