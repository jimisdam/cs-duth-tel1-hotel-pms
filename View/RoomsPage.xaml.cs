using System.Data;
using TachyDev1.Utility;
using TachyDev1.ViewModel;
using WPF = System.Windows;


namespace TachyDev1.View;


public partial class RoomsPage : WPF.Controls.Page
{
    public RoomsPage()
    {
        InitializeComponent();
    }

    private void RoomsGrid_SelectionChanged(object sender, WPF.Controls.SelectionChangedEventArgs e)
    {
        if (this.DataContext is not RoomsVM vm) return;
        vm.OnRoomSelection();
    }
}
