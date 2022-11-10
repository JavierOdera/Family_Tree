using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        
        public T Value {get; set;}
        public Persona Persona;

        private List<Node<T>> children = new List<Node<T>>();

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T t)
        {
            this.Value = t;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor<T> v)
        {
            v.Visit(this);
        }
    }
}
