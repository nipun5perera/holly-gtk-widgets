// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace HollyLibrary {
    
    
    public partial class HToolTip {
        
        private Gtk.VBox vbox4;
        
        private Gtk.Label Spacer;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Label SpacerLeft;
        
        private Gtk.VBox vbox5;
        
        private Gtk.Image ImgIcon;
        
        private Gtk.VBox vbox6;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Label LblTitle;
        
        private Gtk.HSeparator hseparator2;
        
        private Gtk.Label LblContent;
        
        private Gtk.Label SpacerRight;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget HollyLibrary.HToolTip
            this.Name = "HollyLibrary.HToolTip";
            this.Title = Mono.Unix.Catalog.GetString("HToolTip");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child HollyLibrary.HToolTip.Gtk.Container+ContainerChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.Spacer = new Gtk.Label();
            this.Spacer.Name = "Spacer";
            this.Spacer.LabelProp = "";
            this.vbox4.Add(this.Spacer);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox4[this.Spacer]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 2;
            this.hbox2.BorderWidth = ((uint)(8));
            // Container child hbox2.Gtk.Box+BoxChild
            this.SpacerLeft = new Gtk.Label();
            this.SpacerLeft.Name = "SpacerLeft";
            this.SpacerLeft.LabelProp = "";
            this.hbox2.Add(this.SpacerLeft);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox2[this.SpacerLeft]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            // Container child vbox5.Gtk.Box+BoxChild
            this.ImgIcon = new Gtk.Image();
            this.ImgIcon.Name = "ImgIcon";
            this.ImgIcon.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-info", Gtk.IconSize.Menu, 16);
            this.vbox5.Add(this.ImgIcon);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox5[this.ImgIcon]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            this.hbox2.Add(this.vbox5);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox5]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbox6 = new Gtk.VBox();
            this.vbox6.Name = "vbox6";
            this.vbox6.Spacing = 2;
            this.vbox6.BorderWidth = ((uint)(2));
            // Container child vbox6.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 1;
            // Container child hbox3.Gtk.Box+BoxChild
            this.LblTitle = new Gtk.Label();
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Xalign = 0F;
            this.LblTitle.Yalign = 0F;
            this.LblTitle.LabelProp = Mono.Unix.Catalog.GetString("<b>title</b>");
            this.LblTitle.UseMarkup = true;
            this.hbox3.Add(this.LblTitle);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox3[this.LblTitle]));
            w5.Position = 0;
            this.vbox6.Add(this.hbox3);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox6[this.hbox3]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.hseparator2 = new Gtk.HSeparator();
            this.hseparator2.Name = "hseparator2";
            this.vbox6.Add(this.hseparator2);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox6[this.hseparator2]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.LblContent = new Gtk.Label();
            this.LblContent.Name = "LblContent";
            this.LblContent.Xalign = 0F;
            this.LblContent.Yalign = 0F;
            this.LblContent.LabelProp = Mono.Unix.Catalog.GetString("    * HFontPicker - a office like font picker widget\n    * HDateEdit - a date-time picker supporting custom formatting options\n    * HColorPicker - a simple color picker drop-down ( office like ) \n\n");
            this.LblContent.Wrap = true;
            this.vbox6.Add(this.LblContent);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox6[this.LblContent]));
            w8.Position = 2;
            this.hbox2.Add(this.vbox6);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox6]));
            w9.Position = 2;
            // Container child hbox2.Gtk.Box+BoxChild
            this.SpacerRight = new Gtk.Label();
            this.SpacerRight.Name = "SpacerRight";
            this.SpacerRight.LabelProp = "";
            this.hbox2.Add(this.SpacerRight);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox2[this.SpacerRight]));
            w10.Position = 3;
            w10.Expand = false;
            w10.Fill = false;
            this.vbox4.Add(this.hbox2);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox4[this.hbox2]));
            w11.Position = 1;
            this.Add(this.vbox4);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 424;
            this.DefaultHeight = 215;
            this.Show();
            this.SizeAllocated += new Gtk.SizeAllocatedHandler(this.OnSizeAllocated);
        }
    }
}