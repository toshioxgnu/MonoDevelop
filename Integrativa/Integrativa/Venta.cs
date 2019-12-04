using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace Integrativa
{
    public partial class Venta : Gtk.Window
    {
        int preciofinal;
        int nuevoStock;
        int stock, cantidad;
        public Venta() :
                base(WindowType.Toplevel) => Build();

        protected void OnButton4Clicked(object sender, EventArgs e)
        {
            Integrativa.ConsultarProducto consulta = new Integrativa.ConsultarProducto();
            consulta.Show();
        }

        protected void OnButtonAgregarClicked(object sender, EventArgs e)
        {
            string query = null;
            string connectionString = null;
            MySqlConnection connection1;
            connectionString = "server=localhost;database=TIENDA_ABARROTES;uid=root;pwd=root;";
            connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            query = "select ID, Nombre,Precio,Cantidad from tbProductos where ID='"+ this.entry1.Text+"';";
            MySqlCommand MyCommand2 = new MySqlCommand(query, connection1);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            ListStore tipoListado;
            tipoListado = new ListStore(typeof(string), typeof(string), typeof(string), typeof(string));
            nodeview1.AppendColumn("ID", new CellRendererText(), "text", 0);
            nodeview1.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            nodeview1.AppendColumn("Precio", new CellRendererText(), "text", 2);
            nodeview1.Model = tipoListado;


            while (MyReader2.Read())
            {

                string id = (string)MyReader2["ID"];
                string nombre = (string)MyReader2["Nombre"];
                stock = Convert.ToInt32(MyReader2["Cantidad"]);
                int precio = Convert.ToInt32(MyReader2["Precio"]);
                cantidad = Convert.ToInt32(entry6.Text);
                tipoListado.AppendValues(id, nombre, precio.ToString());
                preciofinal = precio * cantidad;

                nodeview1.EnableGridLines = TreeViewGridLines.Horizontal;


            }


            connection1.Close();
        }

        protected void OnButton3Clicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnButton2Clicked(object sender, EventArgs e)
        {
            string connectionString = null;
            MySqlConnection connection1;
            connectionString = "server=localhost;database=TIENDA_ABARROTES;uid=root;pwd=root;";
            connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            nuevoStock = stock - cantidad;
            string query2 = "update tbProductos set Cantidad='" + nuevoStock.ToString() +"' where ID = '" + this.entry1.Text + "';";
            MySqlCommand MyCommand3 = new MySqlCommand(query2, connection1);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand3.ExecuteReader();
            this.entry7.Text = preciofinal.ToString();
            connection1.Close();

        }
    }
}
