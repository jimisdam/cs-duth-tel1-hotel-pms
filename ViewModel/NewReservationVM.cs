
using System.Collections.ObjectModel;
using System.Data;
using TachyDev.Utility;

namespace TachyDev.ViewModel;

internal class NewReservationVM : BaseViewModel
{
    private Model.ReservationModel? _CurrentReservation;
    public Model.ReservationModel? CurrentReservation
    {
        get { return this._CurrentReservation; }
        set { this._CurrentReservation = value; this.OnPropertyChanged(); }
    }

    private Model.RoomClassModel? _SelectedRoomClass;
    public Model.RoomClassModel? SelectedRoomClass
    {
        get { return this._SelectedRoomClass; }
        set 
        { 
            this._SelectedRoomClass = value; 
            this.OnPropertyChanged();
            this.FetchRooms();
        }
    }

    private Model.RoomModel? _SelectedRoom;
    public Model.RoomModel? SelectedRoom
    {
        get { return this._SelectedRoom; }
        set { this._SelectedRoom = value; this.OnPropertyChanged(); }
    }

    public ObservableCollection<Model.RoomClassModel> RoomClassesCollection { get; set; }
    public ObservableCollection<Model.RoomModel> RoomsCollection { get; set; }
    public ObservableCollection<Model.GuestModel> GuestsCollection { get; set; }
    public ObservableCollection<Model.RoomReservationModel> RoomReservationsCollection { get; set; }

    public NewReservationVM()
    {
        this.GuestsCollection = [];
        this.RoomReservationsCollection = [];
        this.RoomClassesCollection = [];
        this.RoomsCollection = [];

        this.FetchRoomClasses();
    }

    public bool FetchRoomClasses()
    {
        if (ACCESSor.LoadTable("RoomCategory") is not DataTable roomClassesTable) return false;

        this.RoomClassesCollection.Clear();
        foreach (DataRow roomClassRow in roomClassesTable.Rows)
        {
            if (Model.RoomClassModel.FromDataRow(roomClassRow) is not Model.RoomClassModel roomClass) continue;
            this.RoomClassesCollection.Add(roomClass);
        }

        return true;
    }

    public bool FetchRooms()
    {
        if (ACCESSor.LoadTable("Room") is not DataTable roomsTable) return false;

        this.RoomsCollection.Clear();
        foreach (DataRow roomRow in roomsTable.Rows)
        {
            if (Model.RoomModel.FromDataRow(roomRow) is not Model.RoomModel room) continue;
            if (room.ClassName != this.SelectedRoomClass?.Name) continue;
            if (room.Condition != "Available") continue;
            this.RoomsCollection.Add(room);
        }

        return true;
    }
}
