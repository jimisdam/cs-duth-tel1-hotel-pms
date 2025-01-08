
using System.Data;

namespace TachyDev.Model;

internal class RoomClassAccessoryModel
{
    public string? RoomClassName { get; set; }
    public string? AccessoryName { get; set; }

    public static RoomClassAccessoryModel? FromDataRow(DataRow row)
    {
        return new RoomClassAccessoryModel()
        {
            RoomClassName = row["RoomCategory"].ToString(),
            AccessoryName = row["Accessory"].ToString(),
        };
    }
}
