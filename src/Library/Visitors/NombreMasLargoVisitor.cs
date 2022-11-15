using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NombreMasLargo :Visitor<Persona>
    {
        public int Largo = 0;
        public string Nombre;
        public override void Visit(Node<Persona> nodo)
        {
            if (nodo.Value.Nombre.Length > Largo)
            {
                Largo = nodo.Value.Nombre.Length;
                Nombre= nodo.Value.Nombre;
            }
            foreach (Node<Persona> hijo in nodo.Children)
            {
                hijo.Accept(this);
            }

        }
    }
}