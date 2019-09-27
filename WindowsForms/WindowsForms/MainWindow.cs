using System;
using Gtk;

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


    protected void OnButton9Clicked(object sender, EventArgs e)
    {
        int valor1 = int.Parse(entry1.Text);
        int valor2 = int.Parse(entry2.Text);
        int suma = valor1 + valor2;
        label4.Text = suma.ToString();

    }
}
