using WPF = System.Windows;
using TachyDev1.ViewModel;


namespace TachyDev1.Component;


public partial class Navigation : WPF.Controls.UserControl
{
    public Navigation()
    {
        InitializeComponent();
    }

    private void ActivePage_SelectionChanged(object sender, WPF.Controls.SelectionChangedEventArgs e)
    {
        var navList = (WPF.Controls.ListView)sender;
        var selectedItem = (WPF.Controls.ListViewItem)navList.SelectedItem;
        var page = selectedItem.Content.ToString();

        var navVM = (NavigationVM)this.DataContext;

        navVM.ActivePage = page;
    }
}
