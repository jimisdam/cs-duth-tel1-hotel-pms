using System.Data;
using System.Windows;
using TachyDev1.Utility;
using WPF = System.Windows;


namespace TachyDev1.View;


public partial class GuestsPage : WPF.Controls.Page
{
    public GuestsPage()
    {
        InitializeComponent();


        DataTable? guestsTable = ACCESSor.LoadTable("Tenant");
        if (guestsTable != null)
        {
            this.GuestsGrid.ItemsSource = guestsTable.DefaultView;
        }

        //MessageBox.Show(guestsTable.Rows[0].ItemArray[0].GetType().ToString());
    }
}
