using System.Collections.ObjectModel;
using System.Data;
using TachyDev.Utility;

namespace TachyDev.ViewModel;

internal class RoomsVM : BaseViewModel
{
    public ObservableCollection<Model.RoomModel> RoomsCollection { get; set; }
    public ObservableCollection<Model.RoomClassAccessoryModel> RoomAccessoriesCollection { get; set; }

    private Model.RoomModel? _SelectedRoom;
    public Model.RoomModel? SelectedRoom
    {
        get { return _SelectedRoom; }
        set { _SelectedRoom = value; this.OnPropertyChanged(); }
    }


    public RoomsVM()
    {
        this.RoomsCollection = [];
        this.RoomAccessoriesCollection = [];

        this.FetchAllRooms();
    }

    public bool OnRoomSelection()
    {
        if (this.SelectedRoom == null) return false;
        if (ACCESSor.LoadTable("RoomCategoryAccessory") is not DataTable roomReservationsTable) return false;

        this.RoomAccessoriesCollection.Clear();
        foreach (DataRow roomReservationRow in roomReservationsTable.Rows)
        {
            if (Model.RoomClassAccessoryModel.FromDataRow(roomReservationRow) is not Model.RoomClassAccessoryModel roomClassAccessory) continue;
            if (roomClassAccessory.RoomClassName != this.SelectedRoom.ClassName) continue;

            this.RoomAccessoriesCollection.Add(roomClassAccessory);
        }

        return true;
    }

    public bool FetchAllRooms()
    {
        if (ACCESSor.LoadTable("Room") is not DataTable roomsTable) return false;

        this.RoomsCollection.Clear();
        foreach (DataRow roomRow in roomsTable.Rows)
        {
            if (Model.RoomModel.FromDataRow(roomRow) is not Model.RoomModel room) continue;

            this.RoomsCollection.Add(room);
        }

        return true;
    }



}
