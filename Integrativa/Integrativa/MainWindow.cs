using System;
using Gtk;


public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel) => Build();

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        Integrativa.Agregar agrega = new Integrativa.Agregar();
        agrega.Show();
    }

    protected void OnBotonEliminaClicked(object sender, EventArgs e)
    {
        Integrativa.Eliminar elimina = new Integrativa.Eliminar();
        elimina.Show();

    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void OnBttnConsultarClicked(object sender, EventArgs e)
    {
        Integrativa.ConsultarProducto consulta = new Integrativa.ConsultarProducto();
        consulta.Show();
    }

    protected void OnButton26Clicked(object sender, EventArgs e)
    {
        Integrativa.Modificar modificar = new Integrativa.Modificar();
        modificar.Show();
    }
}
