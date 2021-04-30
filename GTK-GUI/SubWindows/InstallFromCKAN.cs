using System;
namespace CKAN
{
    public partial class InstallFromCKAN : Gtk.Window
    {
        public InstallFromCKAN () :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
