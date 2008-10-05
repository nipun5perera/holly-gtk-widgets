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
    
    
    public partial class HColorPickerWidget {
        
        private Gtk.HBox hbox1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox2;
        
        private HollyLibrary.ColorPanel ColorWell;
        
        private HollyLibrary.VerticalColorSlider Slider;
        
        private Gtk.HBox hbox3;
        
        private Gtk.RadioButton ChkR1;
        
        private Gtk.SpinButton TxtRed;
        
        private Gtk.RadioButton ChkG;
        
        private Gtk.SpinButton TxtGreen;
        
        private Gtk.RadioButton CkkB;
        
        private Gtk.SpinButton TxtBlue;
        
        private Gtk.VBox vbox1;
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment GtkAlignment;
        
        private Gtk.DrawingArea Preview;
        
        private Gtk.Label GtkLabel3;
        
        private Gtk.Table table1;
        
        private Gtk.RadioButton chkB;
        
        private Gtk.RadioButton chkH;
        
        private Gtk.RadioButton chkS;
        
        private Gtk.Label label2;
        
        private Gtk.Label label5;
        
        private Gtk.Label label6;
        
        private Gtk.Label label7;
        
        private Gtk.SpinButton TxtB;
        
        private Gtk.SpinButton TxtC;
        
        private Gtk.SpinButton TxtH;
        
        private Gtk.SpinButton TxtK;
        
        private Gtk.SpinButton TxtM;
        
        private Gtk.SpinButton TxtS;
        
        private Gtk.SpinButton TxtY;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Label label1;
        
        private HollyLibrary.HRegExEntry TxtHexa;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget HollyLibrary.HColorPickerWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "HollyLibrary.HColorPickerWidget";
            // Container child HollyLibrary.HColorPickerWidget.Gtk.Container+ContainerChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 7;
            this.hbox2.BorderWidth = ((uint)(6));
            // Container child hbox2.Gtk.Box+BoxChild
            this.ColorWell = new HollyLibrary.ColorPanel();
            this.ColorWell.WidthRequest = 250;
            this.ColorWell.HeightRequest = 200;
            this.ColorWell.Name = "ColorWell";
            this.hbox2.Add(this.ColorWell);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox2[this.ColorWell]));
            w1.Position = 1;
            w1.Expand = false;
            w1.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.Slider = new HollyLibrary.VerticalColorSlider();
            this.Slider.WidthRequest = 50;
            this.Slider.Name = "Slider";
            this.hbox2.Add(this.Slider);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox2[this.Slider]));
            w2.Position = 2;
            w2.Expand = false;
            w2.Fill = false;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.ChkR1 = new Gtk.RadioButton("R:");
            this.ChkR1.CanFocus = true;
            this.ChkR1.Name = "ChkR1";
            this.ChkR1.Active = true;
            this.ChkR1.DrawIndicator = true;
            this.ChkR1.UseUnderline = true;
            this.ChkR1.Group = new GLib.SList(System.IntPtr.Zero);
            this.hbox3.Add(this.ChkR1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox3[this.ChkR1]));
            w4.Position = 0;
            // Container child hbox3.Gtk.Box+BoxChild
            this.TxtRed = new Gtk.SpinButton(0, 255, 1);
            this.TxtRed.CanFocus = true;
            this.TxtRed.Name = "TxtRed";
            this.TxtRed.Adjustment.PageIncrement = 10;
            this.TxtRed.ClimbRate = 1;
            this.TxtRed.Numeric = true;
            this.hbox3.Add(this.TxtRed);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox3[this.TxtRed]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.ChkG = new Gtk.RadioButton("G:");
            this.ChkG.CanFocus = true;
            this.ChkG.Name = "ChkG";
            this.ChkG.DrawIndicator = true;
            this.ChkG.UseUnderline = true;
            this.ChkG.Group = this.ChkR1.Group;
            this.hbox3.Add(this.ChkG);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox3[this.ChkG]));
            w6.Position = 2;
            // Container child hbox3.Gtk.Box+BoxChild
            this.TxtGreen = new Gtk.SpinButton(0, 255, 1);
            this.TxtGreen.CanFocus = true;
            this.TxtGreen.Name = "TxtGreen";
            this.TxtGreen.Adjustment.PageIncrement = 10;
            this.TxtGreen.ClimbRate = 1;
            this.TxtGreen.Numeric = true;
            this.hbox3.Add(this.TxtGreen);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox3[this.TxtGreen]));
            w7.Position = 3;
            w7.Expand = false;
            w7.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.CkkB = new Gtk.RadioButton("B:");
            this.CkkB.CanFocus = true;
            this.CkkB.Name = "CkkB";
            this.CkkB.DrawIndicator = true;
            this.CkkB.UseUnderline = true;
            this.CkkB.Group = this.ChkR1.Group;
            this.hbox3.Add(this.CkkB);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox3[this.CkkB]));
            w8.Position = 4;
            // Container child hbox3.Gtk.Box+BoxChild
            this.TxtBlue = new Gtk.SpinButton(0, 255, 1);
            this.TxtBlue.CanFocus = true;
            this.TxtBlue.Name = "TxtBlue";
            this.TxtBlue.Adjustment.PageIncrement = 10;
            this.TxtBlue.ClimbRate = 1;
            this.TxtBlue.Numeric = true;
            this.hbox3.Add(this.TxtBlue);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox3[this.TxtBlue]));
            w9.Position = 5;
            w9.Expand = false;
            w9.Fill = false;
            this.vbox2.Add(this.hbox3);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
            w10.Position = 1;
            w10.Expand = false;
            w10.Fill = false;
            this.hbox1.Add(this.vbox2);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
            w11.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child frame1.Gtk.Container+ContainerChild
            this.GtkAlignment = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment.Name = "GtkAlignment";
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            this.Preview = new Gtk.DrawingArea();
            this.Preview.WidthRequest = 100;
            this.Preview.HeightRequest = 100;
            this.Preview.Name = "Preview";
            this.GtkAlignment.Add(this.Preview);
            this.frame1.Add(this.GtkAlignment);
            this.GtkLabel3 = new Gtk.Label();
            this.GtkLabel3.Name = "GtkLabel3";
            this.GtkLabel3.LabelProp = "<b>Preview</b>";
            this.GtkLabel3.UseMarkup = true;
            this.frame1.LabelWidget = this.GtkLabel3;
            this.vbox1.Add(this.frame1);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox1[this.frame1]));
            w14.Position = 0;
            w14.Expand = false;
            w14.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(4)), ((uint)(4)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.chkB = new Gtk.RadioButton("B:");
            this.chkB.CanFocus = true;
            this.chkB.Name = "chkB";
            this.chkB.DrawIndicator = true;
            this.chkB.UseUnderline = true;
            this.chkB.Group = this.ChkR1.Group;
            this.table1.Add(this.chkB);
            Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table1[this.chkB]));
            w15.TopAttach = ((uint)(2));
            w15.BottomAttach = ((uint)(3));
            w15.XOptions = ((Gtk.AttachOptions)(4));
            w15.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.chkH = new Gtk.RadioButton("H:");
            this.chkH.CanFocus = true;
            this.chkH.Name = "chkH";
            this.chkH.DrawIndicator = true;
            this.chkH.UseUnderline = true;
            this.chkH.Group = this.ChkR1.Group;
            this.table1.Add(this.chkH);
            Gtk.Table.TableChild w16 = ((Gtk.Table.TableChild)(this.table1[this.chkH]));
            w16.XOptions = ((Gtk.AttachOptions)(4));
            w16.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.chkS = new Gtk.RadioButton("S:");
            this.chkS.CanFocus = true;
            this.chkS.Name = "chkS";
            this.chkS.DrawIndicator = true;
            this.chkS.UseUnderline = true;
            this.chkS.Group = this.ChkR1.Group;
            this.table1.Add(this.chkS);
            Gtk.Table.TableChild w17 = ((Gtk.Table.TableChild)(this.table1[this.chkS]));
            w17.TopAttach = ((uint)(1));
            w17.BottomAttach = ((uint)(2));
            w17.XOptions = ((Gtk.AttachOptions)(4));
            w17.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = "K:";
            this.table1.Add(this.label2);
            Gtk.Table.TableChild w18 = ((Gtk.Table.TableChild)(this.table1[this.label2]));
            w18.TopAttach = ((uint)(3));
            w18.BottomAttach = ((uint)(4));
            w18.LeftAttach = ((uint)(2));
            w18.RightAttach = ((uint)(3));
            w18.XOptions = ((Gtk.AttachOptions)(4));
            w18.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = "C:";
            this.table1.Add(this.label5);
            Gtk.Table.TableChild w19 = ((Gtk.Table.TableChild)(this.table1[this.label5]));
            w19.LeftAttach = ((uint)(2));
            w19.RightAttach = ((uint)(3));
            w19.XOptions = ((Gtk.AttachOptions)(4));
            w19.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = "M:";
            this.table1.Add(this.label6);
            Gtk.Table.TableChild w20 = ((Gtk.Table.TableChild)(this.table1[this.label6]));
            w20.TopAttach = ((uint)(1));
            w20.BottomAttach = ((uint)(2));
            w20.LeftAttach = ((uint)(2));
            w20.RightAttach = ((uint)(3));
            w20.XOptions = ((Gtk.AttachOptions)(4));
            w20.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.LabelProp = "Y:";
            this.table1.Add(this.label7);
            Gtk.Table.TableChild w21 = ((Gtk.Table.TableChild)(this.table1[this.label7]));
            w21.TopAttach = ((uint)(2));
            w21.BottomAttach = ((uint)(3));
            w21.LeftAttach = ((uint)(2));
            w21.RightAttach = ((uint)(3));
            w21.XOptions = ((Gtk.AttachOptions)(4));
            w21.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.TxtB = new Gtk.SpinButton(0, 100, 1);
            this.TxtB.CanFocus = true;
            this.TxtB.Name = "TxtB";
            this.TxtB.Adjustment.PageIncrement = 10;
            this.TxtB.ClimbRate = 1;
            this.TxtB.Numeric = true;
            this.table1.Add(this.TxtB);
            Gtk.Table.TableChild w22 = ((Gtk.Table.TableChild)(this.table1[this.TxtB]));
            w22.TopAttach = ((uint)(2));
            w22.BottomAttach = ((uint)(3));
            w22.LeftAttach = ((uint)(1));
            w22.RightAttach = ((uint)(2));
            w22.XOptions = ((Gtk.AttachOptions)(4));
            w22.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.TxtC = new Gtk.SpinButton(0, 100, 1);
            this.TxtC.CanFocus = true;
            this.TxtC.Name = "TxtC";
            this.TxtC.Adjustment.PageIncrement = 10;
            this.TxtC.ClimbRate = 1;
            this.TxtC.Numeric = true;
            this.table1.Add(this.TxtC);
            Gtk.Table.TableChild w23 = ((Gtk.Table.TableChild)(this.table1[this.TxtC]));
            w23.LeftAttach = ((uint)(3));
            w23.RightAttach = ((uint)(4));
            w23.XOptions = ((Gtk.AttachOptions)(4));
            w23.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.TxtH = new Gtk.SpinButton(0, 360, 1);
            this.TxtH.CanFocus = true;
            this.TxtH.Name = "TxtH";
            this.TxtH.Adjustment.PageIncrement = 10;
            this.TxtH.ClimbRate = 1;
            this.TxtH.Numeric = true;
            this.table1.Add(this.TxtH);
            Gtk.Table.TableChild w24 = ((Gtk.Table.TableChild)(this.table1[this.TxtH]));
            w24.LeftAttach = ((uint)(1));
            w24.RightAttach = ((uint)(2));
            w24.XOptions = ((Gtk.AttachOptions)(4));
            w24.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.TxtK = new Gtk.SpinButton(0, 100, 1);
            this.TxtK.CanFocus = true;
            this.TxtK.Name = "TxtK";
            this.TxtK.Adjustment.PageIncrement = 10;
            this.TxtK.ClimbRate = 1;
            this.TxtK.Numeric = true;
            this.TxtK.Value = 1;
            this.table1.Add(this.TxtK);
            Gtk.Table.TableChild w25 = ((Gtk.Table.TableChild)(this.table1[this.TxtK]));
            w25.TopAttach = ((uint)(3));
            w25.BottomAttach = ((uint)(4));
            w25.LeftAttach = ((uint)(3));
            w25.RightAttach = ((uint)(4));
            w25.XOptions = ((Gtk.AttachOptions)(4));
            w25.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.TxtM = new Gtk.SpinButton(0, 100, 1);
            this.TxtM.CanFocus = true;
            this.TxtM.Name = "TxtM";
            this.TxtM.Adjustment.PageIncrement = 10;
            this.TxtM.ClimbRate = 1;
            this.TxtM.Numeric = true;
            this.table1.Add(this.TxtM);
            Gtk.Table.TableChild w26 = ((Gtk.Table.TableChild)(this.table1[this.TxtM]));
            w26.TopAttach = ((uint)(1));
            w26.BottomAttach = ((uint)(2));
            w26.LeftAttach = ((uint)(3));
            w26.RightAttach = ((uint)(4));
            w26.XOptions = ((Gtk.AttachOptions)(4));
            w26.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.TxtS = new Gtk.SpinButton(0, 100, 1);
            this.TxtS.CanFocus = true;
            this.TxtS.Name = "TxtS";
            this.TxtS.Adjustment.PageIncrement = 10;
            this.TxtS.ClimbRate = 1;
            this.TxtS.Numeric = true;
            this.table1.Add(this.TxtS);
            Gtk.Table.TableChild w27 = ((Gtk.Table.TableChild)(this.table1[this.TxtS]));
            w27.TopAttach = ((uint)(1));
            w27.BottomAttach = ((uint)(2));
            w27.LeftAttach = ((uint)(1));
            w27.RightAttach = ((uint)(2));
            w27.XOptions = ((Gtk.AttachOptions)(4));
            w27.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.TxtY = new Gtk.SpinButton(0, 100, 1);
            this.TxtY.CanFocus = true;
            this.TxtY.Name = "TxtY";
            this.TxtY.Adjustment.PageIncrement = 10;
            this.TxtY.ClimbRate = 1;
            this.TxtY.Numeric = true;
            this.table1.Add(this.TxtY);
            Gtk.Table.TableChild w28 = ((Gtk.Table.TableChild)(this.table1[this.TxtY]));
            w28.TopAttach = ((uint)(2));
            w28.BottomAttach = ((uint)(3));
            w28.LeftAttach = ((uint)(3));
            w28.RightAttach = ((uint)(4));
            w28.XOptions = ((Gtk.AttachOptions)(4));
            w28.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox1.Add(this.table1);
            Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(this.vbox1[this.table1]));
            w29.Position = 1;
            w29.Expand = false;
            w29.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = "#";
            this.hbox4.Add(this.label1);
            Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(this.hbox4[this.label1]));
            w30.Position = 0;
            w30.Expand = false;
            w30.Fill = false;
            // Container child hbox4.Gtk.Box+BoxChild
            this.TxtHexa = new HollyLibrary.HRegExEntry();
            this.TxtHexa.Events = ((Gdk.EventMask)(256));
            this.TxtHexa.Name = "TxtHexa";
            this.TxtHexa.RegularExpression = "^?[0-9A-F]{6}$";
            this.TxtHexa.OkMessage = "Color hexa code is correct";
            this.TxtHexa.ErrorMessage = "Error in color code !";
            this.hbox4.Add(this.TxtHexa);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.hbox4[this.TxtHexa]));
            w31.Position = 1;
            this.vbox1.Add(this.hbox4);
            Gtk.Box.BoxChild w32 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
            w32.PackType = ((Gtk.PackType)(1));
            w32.Position = 2;
            w32.Expand = false;
            w32.Fill = false;
            this.hbox1.Add(this.vbox1);
            Gtk.Box.BoxChild w33 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
            w33.Position = 1;
            this.Add(this.hbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
            this.ColorWell.Scroll += new System.EventHandler(this.OnColorWellScroll);
            this.Slider.Scroll += new System.EventHandler(this.OnSliderScroll);
            this.ChkR1.Toggled += new System.EventHandler(this.OnChkRToggled);
            this.TxtRed.ValueChanged += new System.EventHandler(this.OnTxtRedValueChanged);
            this.ChkG.Toggled += new System.EventHandler(this.OnChkGToggled);
            this.TxtGreen.ValueChanged += new System.EventHandler(this.OnTxtGreenValueChanged);
            this.CkkB.Toggled += new System.EventHandler(this.OnCkkBToggled);
            this.TxtBlue.ValueChanged += new System.EventHandler(this.OnTxtBlueValueChanged);
            this.Preview.ExposeEvent += new Gtk.ExposeEventHandler(this.OnPreviewExposeEvent);
            this.TxtY.ValueChanged += new System.EventHandler(this.OnTxtYValueChanged);
            this.TxtS.ValueChanged += new System.EventHandler(this.OnTxtSValueChanged);
            this.TxtM.ValueChanged += new System.EventHandler(this.OnTxtMValueChanged);
            this.TxtK.ValueChanged += new System.EventHandler(this.OnTxtKValueChanged);
            this.TxtH.ValueChanged += new System.EventHandler(this.OnTxtHValueChanged);
            this.TxtC.ValueChanged += new System.EventHandler(this.OnTxtCValueChanged);
            this.TxtB.ValueChanged += new System.EventHandler(this.OnTxtBValueChanged);
            this.chkS.Toggled += new System.EventHandler(this.OnChkSToggled);
            this.chkH.Toggled += new System.EventHandler(this.OnChkHToggled);
            this.chkB.Toggled += new System.EventHandler(this.OnChkBToggled);
            this.TxtHexa.Changed += new System.EventHandler(this.OnTxtHexaChanged);
        }
    }
}