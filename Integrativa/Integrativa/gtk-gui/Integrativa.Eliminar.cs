
// This file has been generated by the GUI designer. Do not modify.
namespace Integrativa
{
	public partial class Eliminar
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Button button1;

		private global::Gtk.Button button3;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Integrativa.Eliminar
			this.Name = "Integrativa.Eliminar";
			this.Title = global::Mono.Unix.Catalog.GetString("Eliminar");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Integrativa.Eliminar.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Cancelar");
			this.fixed1.Add(this.button1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
			w1.X = 152;
			w1.Y = 353;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button3 = new global::Gtk.Button();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("Eliminar");
			this.fixed1.Add(this.button3);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button3]));
			w2.X = 51;
			w2.Y = 353;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 280;
			this.DefaultHeight = 414;
			this.Show();
			this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
		}
	}
}
