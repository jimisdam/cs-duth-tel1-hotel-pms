using System.Data;
using TachyDev.Utility;
using TachyDev.ViewModel;
using WPF = System.Windows;


namespace TachyDev.View;


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
