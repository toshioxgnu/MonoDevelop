using System;
using System.Reflection.Emit;
using Atk;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private const string V = "Contraseña Correcta!";

    public bool UseSystemPasswordChar { get; set; }

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {

        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {

        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton7Clicked(object sender, EventArgs e)
    {
        if ((V != null) && (entry1.Text == "abc123"))
        {
            label4.Text = V;
        }
    }
}

namespace Table
{
    class UseSystemPasswordChar
    {
    }
}