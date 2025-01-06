
namespace TachyDev1.Model;

internal class RoomReservationModel
{
    public string? Id { get; set; }
    public string? ReservationId { get; set; }
    public string? RoomId { get; set; }
    public string? GuestId { get; set; }

    public ReservationModel? Reservation { get; set; }
    public RoomModel? Room { get; set; }
    public GuestModel? Guest { get; set; }
}
