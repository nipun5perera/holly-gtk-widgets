// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace test {
    
    
    public partial class MainWin {
        
        private Gtk.VBox vbox1;
        
        private HollyLibrary.HSimpleComboBox hsimplecombobox1;
        
        private HollyLibrary.HFontPicker hfontpicker1;
        
        private HollyLibrary.HRegExEntry hregexentry1;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private HollyLibrary.HSimpleList hsimplelist1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget test.MainWin
            this.Name = "test.MainWin";
            this.Title = Mono.Unix.Catalog.GetString("MainWin");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child test.MainWin.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hsimplecombobox1 = new HollyLibrary.HSimpleComboBox();
            this.hsimplecombobox1.Events = ((Gdk.EventMask)(256));
            this.hsimplecombobox1.Name = "hsimplecombobox1";
            this.hsimplecombobox1.DropDownHeight = 0;
            this.hsimplecombobox1.IsEditable = false;
            this.vbox1.Add(this.hsimplecombobox1);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.hsimplecombobox1]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hfontpicker1 = new HollyLibrary.HFontPicker();
            this.hfontpicker1.Events = ((Gdk.EventMask)(256));
            this.hfontpicker1.Name = "hfontpicker1";
            this.vbox1.Add(this.hfontpicker1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.hfontpicker1]));
            w2.Position = 1;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hregexentry1 = new HollyLibrary.HRegExEntry();
            this.hregexentry1.Events = ((Gdk.EventMask)(256));
            this.hregexentry1.Name = "hregexentry1";
            this.vbox1.Add(this.hregexentry1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.hregexentry1]));
            w3.Position = 3;
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.hsimplelist1 = new HollyLibrary.HSimpleList();
            this.hsimplelist1.CanFocus = true;
            this.hsimplelist1.Name = "hsimplelist1";
            this.hsimplelist1.HeadersClickable = true;
            this.hsimplelist1.ItemHeight = 0;
            this.hsimplelist1.SelectedIndex = 0;
            this.hsimplelist1.OwnerDraw = false;
            this.GtkScrolledWindow.Add(this.hsimplelist1);
            this.vbox1.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
            w5.Position = 4;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 287;
            this.Show();
            this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        }
    }
}
