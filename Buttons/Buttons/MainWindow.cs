using System;
using Gtk;

public partial class MainWindow : Gtk.Window {
    public MainWindow () : base (Gtk.WindowType.Toplevel) {
        Build ();
    }

    protected void OnDeleteEvent (object sender, DeleteEventArgs a) {
        Application.Quit ();
        a.RetVal = true;
    }

    protected void OnButton4Clicked (object sender, EventArgs e) {
        Title = "1";
    }

    protected void OnButton5Clicked (object sender, EventArgs e) {
        Title = "2";
    }

    protected void OnButton6Clicked (object sender, EventArgs e) {
        Title = "3";
    }
}