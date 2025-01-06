using System.Data;
using System.Windows;
using TachyDev1.Model;
using TachyDev1.Utility;
using WPF = System.Windows;


namespace TachyDev1.View;


public partial class ReservationsPage : WPF.Controls.Page
{
    public ReservationsPage()
    {
        InitializeComponent();

        UpdateReservations();
    }

    private void UpdateReservations()
    {
        DataTable reservations = ACCESSor.LoadTable("Reservation")!;

        foreach (DataRow reservationRow in reservations.Rows)
        {

            this.ReservationsGrid.Items.Add(new ReservationModel()
            {
                Id = reservationRow["ID"].ToString(),
                Type = reservationRow["Type"] as string,
                GuestsType = reservationRow["GuestType"] as string,
                Status = reservationRow["Status"] as string,
                DepositAmount = 0,
                //ArrivalDate = DateTime.Parse(reservationRow["CheckInDate"] as string), 
                //DepartureDate = DateTime.Parse(reservationRow["CheckOutDate"] as string), 
            });
        }
    }

    private void ReservationsGrid_SelectionChanged(object sender, WPF.Controls.SelectionChangedEventArgs e)
    {
        if (this.ReservationsGrid.SelectedItem is not Model.ReservationModel selectedReservation) return;

        DataTable? roomReservationsTable = ACCESSor.LoadTable("RoomReservation");
        if (roomReservationsTable == null) return;

        var selRoomReservationsTable = roomReservationsTable.Clone();

        foreach (DataRow row in roomReservationsTable.Rows)
        {
            string? currReservationId = row["Reservation"].ToString();

            if (currReservationId != selectedReservation.Id) continue;

            selRoomReservationsTable.ImportRow(row);
        }

        this.RoomReservationsGrid.ItemsSource = selRoomReservationsTable.DefaultView;
    }
}
