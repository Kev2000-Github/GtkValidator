using System;
using Gtk;
using GtkValidation;
public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnChanged(object sender, EventArgs e)
    {
        Validacion.ValidarNroDecimal(entry1);
    }
}
