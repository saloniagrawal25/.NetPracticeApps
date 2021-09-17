using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack
    {
        object Obj
        {
            get;set;
        }
        ArrayList ObjList
        {
            get; set;
        }

        public Stack()
        {
            ObjList = new ArrayList();
        }
        
        public void Push(object obj)
        {
            if (obj != null)
            {
                this.Obj = obj;
                ObjList.Add(obj);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public object Pop()
        {
            if(ObjList!=null && ObjList.Count > 0) 
            {
                Obj = ObjList[ObjList.Count - 1];
                ObjList.Remove(Obj);
            }
            else
            {
                throw new InvalidOperationException();
            }
            return Obj;
        }

        public void Clear()
        {
            if(ObjList!=null)
            {
                ObjList.Clear();
            }
        }
    }
}
