// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow {
    private global::Gtk.Fixed fixed5;

    private global::Gtk.Label label3;

    private global::Gtk.Entry entry1;

    private global::Gtk.Button button7;

    private global::Gtk.Label label4;

    protected virtual void Build () {
        global::Stetic.Gui.Initialize (this);
        // Widget MainWindow
        this.Name = "MainWindow";
        this.Title = global::Mono.Unix.Catalog.GetString ("Contraseña");
        this.WindowPosition = ((global::Gtk.WindowPosition) (4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.fixed5 = new global::Gtk.Fixed ();
        this.fixed5.Name = "fixed5";
        this.fixed5.HasWindow = false;
        // Container child fixed5.Gtk.Fixed+FixedChild
        this.label3 = new global::Gtk.Label ();
        this.label3.Name = "label3";
        this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Ingrese Contraseña");
        this.fixed5.Add (this.label3);
        global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild) (this.fixed5[this.label3]));
        w1.X = 40;
        w1.Y = 39;
        // Container child fixed5.Gtk.Fixed+FixedChild
        this.entry1 = new global::Gtk.Entry ();
        this.entry1.CanFocus = true;
        this.entry1.Name = "entry1";
        this.entry1.IsEditable = true;
        this.entry1.Visibility = false;
        this.entry1.InvisibleChar = '•';
        this.fixed5.Add (this.entry1);
        global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild) (this.fixed5[this.entry1]));
        w2.X = 172;
        w2.Y = 24;
        // Container child fixed5.Gtk.Fixed+FixedChild
        this.button7 = new global::Gtk.Button ();
        this.button7.CanFocus = true;
        this.button7.Name = "button7";
        this.button7.UseUnderline = true;
        this.button7.Label = global::Mono.Unix.Catalog.GetString ("Comprobar");
        this.fixed5.Add (this.button7);
        global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild) (this.fixed5[this.button7]));
        w3.X = 211;
        w3.Y = 80;
        // Container child fixed5.Gtk.Fixed+FixedChild
        this.label4 = new global::Gtk.Label ();
        this.label4.Name = "label4";
        this.fixed5.Add (this.label4);
        global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild) (this.fixed5[this.label4]));
        w4.X = 352;
        w4.Y = 83;
        this.Add (this.fixed5);
        if ((this.Child != null)) {
            this.Child.ShowAll ();
        }
        this.DefaultWidth = 475;
        this.DefaultHeight = 145;
        this.Show ();
        this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
        this.button7.Clicked += new global::System.EventHandler (this.OnButton7Clicked);
    }
}