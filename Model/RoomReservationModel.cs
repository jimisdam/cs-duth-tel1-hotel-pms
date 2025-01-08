
using System.Data;

namespace TachyDev.Model;

internal class RoomReservationModel
{
    //public Guid? Id { get; set; }
    public Guid? ReservationId { get; set; }
    public string? RoomCode { get; set; }
    public Guid? GuestId { get; set; }

    //public ReservationModel? Reservation { get; set; }
    //public RoomModel? Room { get; set; }
    //public GuestModel? Guest { get; set; }

    public static RoomReservationModel? FromDataRow(DataRow row)
    {
        return new RoomReservationModel()
        {
            //Id = Guid.Parse(row["ID"].ToString()),
            ReservationId = Guid.Parse(row["Reservation"].ToString()),
            RoomCode = row["Room"].ToString(),
            GuestId = Guid.Parse(row["Tenant"].ToString()),
        };
    }
}
