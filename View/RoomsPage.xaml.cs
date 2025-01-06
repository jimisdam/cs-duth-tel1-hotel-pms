using System.Data;
using TachyDev1.Utility;
using WPF = System.Windows;


namespace TachyDev1.View;


public partial class RoomsPage : WPF.Controls.Page
{
    public RoomsPage()
    {
        InitializeComponent();

        DataTable? roomsTable = ACCESSor.LoadTable("Room");
        if (roomsTable != null)
        {
            this.RoomsGrid.ItemsSource = roomsTable.DefaultView;
        }
    }

    private void RoomsGrid_SelectionChanged(object sender, WPF.Controls.SelectionChangedEventArgs e)
    {
        if (this.RoomsGrid.SelectedItem is not DataRowView selectedRoom) return;
        if ((selectedRoom["Category"] as string) is not string selectedRoomCategory) return;

        DataTable? accessoriesTable = ACCESSor.LoadTable("RoomCategoryAccessory");
        if (accessoriesTable == null) return;

        var roomAccessoriesTable = accessoriesTable.Clone();

        foreach (DataRow row in accessoriesTable.Rows)
        {
            string? currRoomCategory = row["RoomCategory"] as string;

            if (currRoomCategory! != selectedRoomCategory) continue;

            roomAccessoriesTable.ImportRow(row);
        }

        //var lala = new DataTable();

        //lala.

        this.RoomAccessoriesGrid.ItemsSource = roomAccessoriesTable.DefaultView;
    }
}
