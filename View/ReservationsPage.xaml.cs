using System.Data;
using TachyDev1.Model;
using TachyDev1.Utility;
using WPF = System.Windows;


namespace TachyDev1.View;


public partial class ReservationsPage : WPF.Controls.Page
{
    public ReservationsPage()
    {
        InitializeComponent();


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
}
