
// This file has been generated by the GUI designer. Do not modify.
namespace Integrativa
{
	public partial class Agregar
	{
		private global::Gtk.Fixed fixed3;

		private global::Gtk.Button button2;

		private global::Gtk.Button button4;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entry2;

		private global::Gtk.Label label3;

		private global::Gtk.Entry entry3;

		private global::Gtk.Entry entry1;

		private global::Gtk.Label label1;

		private global::Gtk.Label label4;

		private global::Gtk.Entry entry4;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Integrativa.Agregar
			this.Name = "Integrativa.Agregar";
			this.Title = global::Mono.Unix.Catalog.GetString("Agregar");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Integrativa.Agregar.Gtk.Container+ContainerChild
			this.fixed3 = new global::Gtk.Fixed();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("Agregar");
			this.fixed3.Add(this.button2);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.button2]));
			w1.X = 26;
			w1.Y = 396;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.button4 = new global::Gtk.Button();
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString("Cancelar");
			this.fixed3.Add(this.button4);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.button4]));
			w2.X = 200;
			w2.Y = 397;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("ID");
			this.fixed3.Add(this.label2);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.label2]));
			w3.X = 20;
			w3.Y = 88;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.entry2 = new global::Gtk.Entry();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.InvisibleChar = '•';
			this.fixed3.Add(this.entry2);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.entry2]));
			w4.X = 18;
			w4.Y = 116;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Precio");
			this.fixed3.Add(this.label3);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.label3]));
			w5.X = 24;
			w5.Y = 162;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.entry3 = new global::Gtk.Entry();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '•';
			this.fixed3.Add(this.entry3);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.entry3]));
			w6.X = 18;
			w6.Y = 189;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.WidthRequest = 300;
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.fixed3.Add(this.entry1);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.entry1]));
			w7.X = 21;
			w7.Y = 48;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre Producto");
			this.fixed3.Add(this.label1);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.label1]));
			w8.X = 26;
			w8.Y = 21;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Cantidad");
			this.fixed3.Add(this.label4);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.label4]));
			w9.X = 25;
			w9.Y = 232;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.entry4 = new global::Gtk.Entry();
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.InvisibleChar = '•';
			this.fixed3.Add(this.entry4);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.entry4]));
			w10.X = 15;
			w10.Y = 266;
			this.Add(this.fixed3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 329;
			this.DefaultHeight = 449;
			this.Show();
			this.button2.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
			this.button4.Clicked += new global::System.EventHandler(this.OnButton4Clicked);
		}
	}
}