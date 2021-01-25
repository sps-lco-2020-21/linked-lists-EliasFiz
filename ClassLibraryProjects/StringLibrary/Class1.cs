using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample.Lib
{
    public class IntegerLinkedList
    {
        public IntegerNode _head;

        public IntegerLinkedList()
        {
        }

        public IntegerLinkedList(int v)
        {
            _head = new IntegerNode(v);
        }

        public int Count
        {
            get
            {
                if (_head == null)
                    return 0;
                else
                    return _head.Count;
            }
        }
        public int Sum
        {
            get
            {
                if (_head == null)
                    return 0;
                else
                    return _head.Sum;
            }

        }

        public void Append(int v)
        {
            if (_head == null)
                _head = new IntegerNode(v);
            else
            {
                _head.Append(v);
            }
        }

        public bool Delete(int v)
        {
            if (_head == null)
                return true;
            else if (_head._value == v) {
                _head = _head._next;
                return false;
            }
            return _head.Delete(v);
        }

        public string ToStr
        {
            get
            {
                string convertedString = _head._value.ToString();

                convertedString += _head._next.ToStr;

                return "{" + convertedString + "}";
            }

        }
    }
    public class IntegerNode
    {
        public int _value;
        public IntegerNode _next;

        public int Count
        {
            get
            {
                if (_next == null)
                    return 1;
                else
                    return 1 + _next.Count;
            }
        }

        public int Sum
        {
            get
            {
                if (_next == null)
                    return _value;
                else
                    return _value + _next.Sum;
            }
        }



        public IntegerNode(int v)
        {
            _value = v;
            _next = null;
        }

        public void Append(int v)
        {
            if (_next == null)
                _next = new IntegerNode(v);
            else
                _next.Append(v);
        }

        // To String method works, but clearly not the nicest way
        public string ToStr
        {
            get
            {
                string finalStr = "";
                if (_next == null)
                {
                    return finalStr + ", " + _value.ToString();
                }
                else
                {
                    return finalStr += ", " + _value.ToString() + _next.ToStr;
                }

            }
        }

        public bool Delete(int v)
        {
            if (_next == null)
                return false;
            else if (_next != null && _next._value == v)
            {
                _next = _next._next; // Here we are linking the nodes from either side of v
                return true;
            }
            return _next.Delete(v);
        }
    }
}