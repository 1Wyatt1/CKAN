using System;
namespace CKAN
{
    public partial class ManageGameInstances : Gtk.Window
    {
        public ManageGameInstances () :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
