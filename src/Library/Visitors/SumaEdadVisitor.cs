using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class SumaEdad :Visitor<Persona>
    {
        public int suma = 0;
        public override void Visit(Node<Persona> nodo)
        {
            suma = suma + nodo.Value.Edad;
            foreach (Node<Persona> hijo in nodo.Children)
            {
                hijo.Accept(this);
            }

        }
    }
}