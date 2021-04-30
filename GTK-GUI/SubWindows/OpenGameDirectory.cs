using System;
namespace CKAN
{
    public partial class OpenGameDirectory : Gtk.Window
    {
        public OpenGameDirectory () :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
