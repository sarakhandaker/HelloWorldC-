using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Stack
    {
        public List<object> ClassStack{ get; private set; }

        public Stack()
        {
            this.ClassStack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj==null)
            {
                throw new InvalidOperationException("Object is Null");
            }

            this.ClassStack.Add(obj);

        }
        public object Pop()
        {
            if (this.ClassStack.Count==0)
            {
                
            }
            var removed = this.ClassStack[ClassStack.Count - 1];
            this.ClassStack.RemoveAt(ClassStack.Count - 1);
            return removed;
        }

        public void Clear()
        {
            this.ClassStack = new List<object>();
        }
    }
}