using System.Collections.ObjectModel;
using System.Data;
using TachyDev.Utility;

namespace TachyDev.ViewModel;

internal class GuestsVM : BaseViewModel
{
    public ObservableCollection<Model.GuestModel> GuestsCollection { get; set; }

    private Model.GuestModel? _SelectedGuest;
    public Model.GuestModel? SelectedGuest
    {
        get { return _SelectedGuest; }
        set { _SelectedGuest = value; this.OnPropertyChanged(); }
    }


    public GuestsVM()
    {
        this.GuestsCollection = [];

        this.FetchAllGuests();
    }

    public bool FetchAllGuests()
    {
        if (ACCESSor.LoadTable("Tenant") is not DataTable guestsTable) return false;

        this.GuestsCollection.Clear();
        foreach (DataRow guestRow in guestsTable.Rows)
        {
            if (Model.GuestModel.FromDataRow(guestRow) is not Model.GuestModel guest) continue;

            this.GuestsCollection.Add(guest);
        }

        return true;
    }



}
