using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace Integrativa
{
    public partial class Eliminar : Gtk.Window
    {
        public Eliminar() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnButton1Clicked(object sender, EventArgs e)
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
            query = "delete from tbProductos where ID like = '" + this.entry1.Text + "';";
            query = "delete from tbProductos where Nombre = '" + this.entry2.Text + "';";
            MySqlDataReader MyReader2;
            MySqlCommand MyCommand2 = new MySqlCommand(query, connection1);
            MyReader2 = MyCommand2.ExecuteReader();
            connection1.Close();

            MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent,
                MessageType.Info,
                ButtonsType.Ok, "Producto Eliminado");
            md.Run();
            md.Destroy();
        }
    }
}
