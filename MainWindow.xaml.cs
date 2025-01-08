using WPF = System.Windows;
using TachyDev.View;
using TachyDev.ViewModel;

namespace TachyDev;

public partial class MainWindow : WPF.Window
{
    public MainWindow()
    {
        InitializeComponent();

        var navVM = (NavigationVM)this.Nav.DataContext;

        navVM.PropertyChanged += NavVM_PropertyChanged;
    }

    private void NavVM_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (sender is not NavigationVM navVM) return;
        if (navVM.SelectedPageName is not string selectedPageName) return;

        WPF.Controls.Page? activePage = null;

        switch (selectedPageName)
        {
            case "AUTHORIZE":
                activePage = new AuthView();
                break;
            case "RESERVATIONS":
                activePage = new ReservationsPage();
                break;
            case "ARRIVALS":
                activePage = new ArrivalsPage();
                break;
            case "DEPARTURES":
                activePage = new DeparturesPage();
                break;
            case "GUESTS":
                activePage = new GuestsPage();
                break;
            case "ROOMS": 
                activePage = new RoomsPage();
                break;
            case "STATISTICS": 
                activePage = new StatisticsPage();
                break;
            default:
                break;
        };

        if (activePage == null) return;
        
        this.NavFrame.Navigate(activePage);
        this.TitleLabel.Content = activePage.Title;

        //MessageBox.Show(active_page);
    }
}