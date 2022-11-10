using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class Visitor<T>
    {
        public abstract void Visit(Node<T> node);
    }
}