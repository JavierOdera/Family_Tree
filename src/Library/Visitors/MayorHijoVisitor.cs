using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class MayorHijo :Visitor<Persona>
    {
        public int edad;
        public override void Visit(Node<Persona> nodo)
        {
            if (nodo.Children.Count == 0)
            {
                if (nodo.Value.Edad > edad)
                {
                    edad = nodo.Value.Edad;
                }
            }
            foreach (Node<Persona> hijo in nodo.Children)
            {
                hijo.Accept(this);
            }
        }
    }
}