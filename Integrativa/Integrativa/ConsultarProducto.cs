using System;
using MySql.Data.MySqlClient;
using Gtk;
using System.Data;

namespace Integrativa
{

    public partial class ConsultarProducto : Gtk.Window
    {


        public ConsultarProducto() :

                base(Gtk.WindowType.Toplevel) => this.Build();



        protected void OnBuscarBotonClicked(object sender, EventArgs e)
        {

            string query = null;
            string connectionString = null;
            MySqlConnection connection1;
            connectionString = "server=localhost;database=TIENDA_ABARROTES;uid=root;pwd=root;";
            connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            query = "select * from tbProductos where Nombre = '" + this.entry1.Text + "';";
            MySqlCommand MyCommand2 = new MySqlCommand(query, connection1);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            ListStore tipoListado;
            tipoListado = new ListStore(typeof(string), typeof(string), typeof(string), typeof(string));
            nodeview2.AppendColumn("ID", new CellRendererText(), "text", 0);
            nodeview2.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            nodeview2.AppendColumn("Precio", new CellRendererText(), "text", 2);
            nodeview2.AppendColumn("Cantidad", new CellRendererText(), "text", 3);
            nodeview2.Model = tipoListado;

            while (MyReader2.Read())
            {

                string id = (string)MyReader2["ID"];
                string nombre = (string)MyReader2["Nombre"];
                string precio = (string)MyReader2["Precio"];
                string cant = (string)MyReader2["Cantidad"];
                tipoListado.AppendValues(id,nombre,precio,cant);

                nodeview2.EnableGridLines = TreeViewGridLines.Horizontal;

            }
            connection1.Close();

        }

        protected void OnButton2Clicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnButton3Clicked(object sender, EventArgs e)
        {
            string query = null;
            string connectionString = null;
            MySqlConnection connection1;
            connectionString = "server=localhost;database=TIENDA_ABARROTES;uid=root;pwd=root;";
            connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            query = "select * from tbProductos;";
            MySqlCommand MyCommand2 = new MySqlCommand(query, connection1);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            ListStore tipoListado;
            tipoListado = new ListStore(typeof(string), typeof(string), typeof(string), typeof(string));
            nodeview2.AppendColumn("ID", new CellRendererText(), "text", 0);
            nodeview2.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            nodeview2.AppendColumn("Precio", new CellRendererText(), "text", 2);
            nodeview2.AppendColumn("Cantidad", new CellRendererText(), "text", 3);
            nodeview2.Model = tipoListado;

            while (MyReader2.Read())
            {

                string id = (string)MyReader2["ID"];
                string nombre = (string)MyReader2["Nombre"];
                string precio = (string)MyReader2["Precio"];
                string cant = (string)MyReader2["Cantidad"];
                tipoListado.AppendValues(id, nombre, "$ "+precio, cant);

                nodeview2.EnableGridLines = TreeViewGridLines.Horizontal;

            }
            connection1.Close();

        }
    }


}