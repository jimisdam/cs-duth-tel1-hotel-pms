using System.Data;
using System.Windows;
using TachyDev1.Model;
using TachyDev1.Utility;
using TachyDev1.ViewModel;
using WPF = System.Windows;


namespace TachyDev1.View;


public partial class ReservationsPage : WPF.Controls.Page
{
    public ReservationsPage()
    {
        InitializeComponent();
    }

    private void ReservationsGrid_SelectionChanged(object sender, WPF.Controls.SelectionChangedEventArgs e)
    {
        if (this.DataContext is not ReservationsVM vm) return;
        vm.OnReservationSelection();
    }
}
