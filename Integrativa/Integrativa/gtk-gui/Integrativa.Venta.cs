
// This file has been generated by the GUI designer. Do not modify.
namespace Integrativa
{
	public partial class Venta
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Button button2;

		private global::Gtk.Label label1;

		private global::Gtk.Entry entry1;

		private global::Gtk.Button button4;

		private global::Gtk.Button button3;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.NodeView nodeview1;

		private global::Gtk.Button button5;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Integrativa.Venta
			this.Name = "Integrativa.Venta";
			this.Title = global::Mono.Unix.Catalog.GetString("Venta");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Integrativa.Venta.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button2 = new global::Gtk.Button();
			this.button2.WidthRequest = 100;
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("Venta");
			this.fixed1.Add(this.button2);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button2]));
			w1.X = 17;
			w1.Y = 413;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("ID");
			this.fixed1.Add(this.label1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
			w2.X = 26;
			w2.Y = 14;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.fixed1.Add(this.entry1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry1]));
			w3.X = 18;
			w3.Y = 31;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button4 = new global::Gtk.Button();
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString("Consultar ID");
			this.fixed1.Add(this.button4);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button4]));
			w4.X = 189;
			w4.Y = 29;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button3 = new global::Gtk.Button();
			this.button3.WidthRequest = 100;
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("Salir");
			this.fixed1.Add(this.button3);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button3]));
			w5.X = 150;
			w5.Y = 413;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.WidthRequest = 250;
			this.GtkScrolledWindow.HeightRequest = 250;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nodeview1 = new global::Gtk.NodeView();
			this.nodeview1.CanFocus = true;
			this.nodeview1.Name = "nodeview1";
			this.nodeview1.SearchColumn = 0;
			this.GtkScrolledWindow.Add(this.nodeview1);
			this.fixed1.Add(this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
			w7.X = 19;
			w7.Y = 74;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button5 = new global::Gtk.Button();
			this.button5.WidthRequest = 200;
			this.button5.CanFocus = true;
			this.button5.Name = "button5";
			this.button5.UseUnderline = true;
			this.button5.Label = global::Mono.Unix.Catalog.GetString("Agregar");
			this.fixed1.Add(this.button5);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button5]));
			w8.X = 19;
			w8.Y = 338;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 285;
			this.DefaultHeight = 470;
			this.Show();
			this.button4.Clicked += new global::System.EventHandler(this.OnButton4Clicked);
			this.button3.Clicked += new global::System.EventHandler(this.OnButton3Clicked);
			this.button5.Clicked += new global::System.EventHandler(this.OnButtonAgregarClicked);
		}
	}
}