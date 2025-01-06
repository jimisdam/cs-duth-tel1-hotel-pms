
namespace TachyDev1.Model;

internal class ReservationModel
{
    public string? Id { get; set; }
    public string? Type { get; set; }
    public string? GuestsType { get; set; }
    public string? Status { get; set; }
    public double? DepositAmount { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
}
