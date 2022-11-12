using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NombreMasLargo :Visitor<Persona>
    {
        public int largo = 0;
        public override void Visit(Node<Persona> nodo)
        {
            if (nodo.Value.Nombre.Length > largo)
            {
                largo = nodo.Value.Nombre.Length;
            }
            foreach (Node<Persona> hijo in nodo.Children)
            {
                hijo.Accept(this);
            }

        }
    }
}