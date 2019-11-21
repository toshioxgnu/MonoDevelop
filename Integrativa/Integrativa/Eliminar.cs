using System;
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
    }
}
