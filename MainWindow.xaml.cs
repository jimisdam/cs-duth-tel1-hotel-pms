using System.Windows;
using System.Windows.Controls;
using TachyDev1.View;
using TachyDev1.ViewModel;

namespace TachyDev1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var navVM = (NavigationVM)this.Nav.DataContext;

        navVM.PropertyChanged += NavVM_PropertyChanged;
    }

    private void NavVM_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (sender is not NavigationVM navVM)
        {
            return;
        }

        var selected_page = navVM.ActivePage;
        Page? active_page = null;

        switch (selected_page)
        {
            case "AUTHORIZE":
                active_page = new AuthView();
                break;
            case "RESERVATIONS":
                active_page = new ReservationsPage();
                break;
            case "ARRIVALS":
                active_page = new ArrivalsPage();
                break;
            case "DEPARTURES":
                active_page = new DeparturesPage();
                break;
            case "GUESTS":
                active_page = new GuestsPage();
                break;
            case "ROOMS": 
                active_page = new RoomsPage();
                break;
            case "STATISTICS": 
                active_page = new StatisticsPage();
                break;
            default:
                break;
        };

        if (active_page == null)
        {
            return;
        }
        
        this.NavFrame.Navigate(active_page);
        this.TitleLabel.Content = active_page.Title;

        //MessageBox.Show(active_page);
    }
}