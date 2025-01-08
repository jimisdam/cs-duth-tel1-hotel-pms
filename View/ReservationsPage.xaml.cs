using System.Data;
using System.Windows;
using TachyDev.Window;
using TachyDev.Model;
using TachyDev.Utility;
using TachyDev.ViewModel;
using WPF = System.Windows;


namespace TachyDev.View;


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

    private void NewReservationButton_Click(object sender, RoutedEventArgs e)
    {
        var status = (new NewReservationWindow()).ShowDialog();
        //MessageBox.Show($"Status: {status}");
    }
}
