using WPF = System.Windows;

namespace TachyDev1.Model;

[Flags]
public enum RoomStatus
{
    Free = 0,
    Clean = 1,
    Occupied = 2,
    Dirty = 4,
    Damaged = 8,
    Unavailable = RoomStatus.Occupied | RoomStatus.Dirty | RoomStatus.Damaged,
    Available = RoomStatus.Free,
}

internal class RoomModel
{
    public string? Id { get; set; }
    public string? ClassId{ get; set; }
    public RoomStatus? Status { get; set; }
    public DateOnly? CreatedAt { get; set; }


    // from ClassId
    public RoomClassModel? Class { get; set; }
}
