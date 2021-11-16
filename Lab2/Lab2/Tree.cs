using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Tree<T>
        where T: IComparable, IComparable<T>
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }
        public void Add(T data)
        {
            if(Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }
            Root.Add(data);
            Count++;
        }
        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();
            if(node != null)
            {
                list.Add(node.Data);
                if(node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }
                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }
            return list;
        }
        public List<T> Preorder()
        {
            if(Root == null)
            {
                return new List<T>();
            }
            return Preorder(Root);
        }
    }
    public class TreeEnumerator : IEnumerable
    {     
       public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
