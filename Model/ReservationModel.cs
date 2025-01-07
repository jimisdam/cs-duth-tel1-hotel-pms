using System.Data;

namespace TachyDev1.Model;

internal class ReservationModel
{
    public Guid? Id { get; set; }
    public string? Type { get; set; }
    public string? GuestsType { get; set; }
    public string? Status { get; set; }
    public double? DepositAmount { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }

    public static ReservationModel? FromDataRow(DataRow row)
    {
        return new ReservationModel()
        {
            Id = Guid.Parse(row["ID"].ToString()),
            Type = row["Type"] as string,
            GuestsType = row["GuestType"] as string,
            Status = row["Status"] as string,
            DepositAmount = 0,
            //ArrivalDate = DateTime.Parse(reservationRow["CheckInDate"] as string),
            //DepartureDate = DateTime.Parse(reservationRow["CheckOutDate"] as string),
        };
    }

}
