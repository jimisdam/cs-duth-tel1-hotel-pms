using System.Data;
using WPF = System.Windows;

namespace TachyDev1.Model;

[Flags]
public enum RoomCondition
{
    Free = 0,
    Clean = 1,
    Occupied = 2,
    Dirty = 4,
    Damaged = 8,
    Unavailable = RoomCondition.Occupied | RoomCondition.Dirty | RoomCondition.Damaged,
    Available = RoomCondition.Free,
}

internal class RoomModel
{
    public string? Code { get; set; }
    public string? ClassName { get; set; }
    public string? Condition { get; set; }
    public DateTime? CreatedAt { get; set; }


    // from ClassId
    //public RoomClassModel? Class { get; set; }

    public static RoomModel? FromDataRow(DataRow row)
    {
        return new RoomModel()
        {
            //Id = Guid.Parse(row["ID"].ToString()),
            Code = row["Code"].ToString(),
            ClassName = row["Category"].ToString(),
            Condition = row["Condition"].ToString(),
            CreatedAt = DateTime.Parse(row["CreatedAt"].ToString()),
        };
    }
}
