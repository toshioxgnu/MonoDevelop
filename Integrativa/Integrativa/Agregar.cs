using System;
using Gtk;

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
            MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent,
                MessageType.Info,
                ButtonsType.Ok, "Producto Agregado");
            md.Run();
            md.Destroy();

        }
    }
}
