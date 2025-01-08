using System.Collections.ObjectModel;
using System.Data;
using TachyDev.Utility;

namespace TachyDev.ViewModel;

internal class ReservationsVM : BaseViewModel
{
    public ObservableCollection<Model.ReservationModel> ReservationsCollection { get; set; }
    public ObservableCollection<Model.RoomReservationModel> RoomReservationsCollection { get; set; }

    private Model.ReservationModel? _SelectedReservation;
    public Model.ReservationModel? SelectedReservation
    {
        get { return _SelectedReservation; }
        set { _SelectedReservation = value; this.OnPropertyChanged(); }
    }


    public ReservationsVM()
    {
        this.ReservationsCollection = [];
        this.RoomReservationsCollection = [];

        this.FetchAllReservations();
    }

    public bool OnReservationSelection()
    {
        if (this.SelectedReservation == null) return false;
        if (ACCESSor.LoadTable("RoomReservation") is not DataTable roomReservationsTable) return false;

        this.RoomReservationsCollection.Clear();
        foreach (DataRow roomReservationRow in roomReservationsTable.Rows)
        {
            if (Model.RoomReservationModel.FromDataRow(roomReservationRow) is not Model.RoomReservationModel roomReservation) continue;
            if (roomReservation.ReservationId != this.SelectedReservation.Id) continue;

            this.RoomReservationsCollection.Add(roomReservation);
        }

        return true;
    }

    public bool FetchAllReservations()
    {
        if (ACCESSor.LoadTable("Reservation") is not DataTable reservationsTable) return false;

        this.ReservationsCollection.Clear();
        foreach (DataRow reservationRow in reservationsTable.Rows)
        {
            if (Model.ReservationModel.FromDataRow(reservationRow) is not Model.ReservationModel reservation) continue;

            this.ReservationsCollection.Add(reservation);
        }

        return true;
    }



}
