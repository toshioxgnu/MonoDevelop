using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace Integrativa
{
    public partial class Modificar : Gtk.Window
    {


        public Modificar() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBotonModificarClicked(object sender, EventArgs e)
        {
            string query = null;
            string connectionString = null;
            MySqlConnection connection1;
            connectionString = "server=localhost;database=TIENDA_ABARROTES;uid=root;pwd=root;";
            connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            query = "update tbProductos set ID='" + this.entry5.Text + "', Nombre='"+this.entry2.Text+"', Precio='"+this.entry3.Text
            +"', Cantidad = '"+this.entry4.Text+"' where ID = '"+this.entry1.Text+"';";
            MySqlDataReader MyReader2;
            MySqlCommand MyCommand2 = new MySqlCommand(query, connection1);
            MyReader2 = MyCommand2.ExecuteReader();
            connection1.Close();

            MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent,
                MessageType.Info,
                ButtonsType.Ok, "Producto Actualizado");
            md.Run();
            md.Destroy();
        }

        protected void OnBotonBuscaClicked(object sender, EventArgs e)
        {
            Integrativa.ConsultarProducto consultar = new Integrativa.ConsultarProducto();
            consultar.Show();
        }

        protected void OnBotonCancelarClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
