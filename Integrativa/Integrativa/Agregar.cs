using System;
using Gtk;
using MySql.Data.MySqlClient;


namespace Integrativa
{
    public partial class Agregar : Gtk.Window
    {
        public Agregar() :
                base(Gtk.WindowType.Toplevel) => this.Build();

        protected void OnButton4Clicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnButton2Clicked(object sender, EventArgs e)
        {
            string query = null;
            string connectionString = null;
            MySqlConnection connection1;
            connectionString = "server=localhost;database=TIENDA_ABARROTES;uid=root;pwd=root;";
            connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            query = "insert into tbProductos (ID, Nombre, Precio, Cantidad)values('"+Int32.Parse(this.entry2.Text) 
            +"','"+ this.entry1.Text + "','"+ Int32.Parse(this.entry4.Text)
            + "','"+ Int32.Parse(this.entry3.Text) + "');";
            MySqlDataReader MyReader2;
            MySqlCommand MyCommand2 = new MySqlCommand(query, connection1);
            MyReader2 = MyCommand2.ExecuteReader();
            connection1.Close();

            MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent,
                MessageType.Info,
                ButtonsType.Ok, "Producto Agregado");
            md.Run();
            md.Destroy();

        }
    }
}
