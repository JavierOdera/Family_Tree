using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class MayorHijo :Visitor<Persona>
    {
        public int Edad;
        public string Nombre;
        public override void Visit(Node<Persona> nodo)
        {
            if (nodo.Children.Count == 0)
            {
                if (nodo.Value.Edad > Edad)
                {
                    Edad = nodo.Value.Edad;
                    Nombre = nodo.Value.Nombre;
                }
            }
            foreach (Node<Persona> hijo in nodo.Children)
            {
                hijo.Accept(this);
            }
        }
    }
}