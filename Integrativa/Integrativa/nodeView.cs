using System;
using Gtk;
using Integrativa;

namespace Integrativa
{
    [Gtk.TreeNode(ListOnly = true)]
    public class MyTreeNode : Gtk.TreeNode
    {
         

        [Gtk.TreeNodeValue(Column = 0)]
        public string id;

        [Gtk.TreeNodeValue(Column = 1)]
        public string Nombre;

        [Gtk.TreeNodeValue(Column = 2)]
        public string Precio;

        [Gtk.TreeNodeValue(Column = 3)]
        public string Cantidad;

        public MyTreeNode(string id, string nombre, string precio, string cantidad)
        {
            this.id = id;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}


