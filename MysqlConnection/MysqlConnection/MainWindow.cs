using System;
using Gtk;
using MySql.Data.MySqlClient;

public partial class MainWindow : Gtk.Window {
    public MainWindow () : base (Gtk.WindowType.Toplevel) {
        Build ();
    }

    protected void OnDeleteEvent (object sender, DeleteEventArgs a) {
        Application.Quit ();
        a.RetVal = true;
    }

    protected void OnButton1Clicked (object sender, EventArgs e) {
        String connectionString = null;
        MySqlConnection connection1;
        connectionString = "server=localhost;database=Alumnos;uid=root;pwd=root;";
        connection1 = new MySqlConnection (connectionString);
        try {
            MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent,
                MessageType.Info,
                ButtonsType.Ok, "Connection Stablished");
            md.Run ();
            md.Destroy ();
        } catch (Exception ex) {
            MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent, MessageType.Info, ButtonsType.Ok, "No");
            md.Run ();
            md.Destroy ();

        }
    }

}