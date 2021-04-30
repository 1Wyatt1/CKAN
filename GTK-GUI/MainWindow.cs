using System;
using Gtk;
using CKAN;

public partial class MainWindow : Gtk.Window
{
    public MainWindow () : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent (object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnLaunchGameClicked (object sender, EventArgs e)
    {
        Console.WriteLine("Person Clicked LaunchGame Button");
    }

    protected void OnRefreshClicked (object sender, EventArgs e)
    {
        Console.WriteLine("Person Clicked Refresh Button");
    }

    protected void OnAddAvailableUpdatesClicked (object sender, EventArgs e)
    {
        PopColormap();
        Console.WriteLine("Person Clicked Add Available Updates Button");
    }

    protected void OnApplyChangesClicked (object sender, EventArgs e)
    {
        Console.WriteLine("Person Clicked Apply Changes Button");
    }

    protected void OnManageGameInstancesActionActivated (object sender, EventArgs e)
    {
        ManageGameInstances win2 = new ManageGameInstances();
        win2.Show();
    }

    protected void OnExitCtrlQActionActivated (object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void OnOpenGameDirectoryActionActivated (object sender, EventArgs e)
    {
        OpenGameDirectory win2 = new OpenGameDirectory();
        win2.Show();
    }

    protected void OnInstallFromCkanActionActivated (object sender, EventArgs e)
    {
        InstallFromCkan win2 = new InstallFromCkan();
        win2.Show();
    }
}
