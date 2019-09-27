using System;
using Gtk;
using System.Text;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton10Clicked(object sender, EventArgs e)
    {
        Title = "";
        if (checkbutton2.Active == true)
        {
            Title = Title + "(Frances)";
        }

    }
}