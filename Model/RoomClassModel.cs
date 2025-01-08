
using System.Data;

namespace TachyDev.Model;

internal class RoomClassModel
{
    public string? Name { get; set; }
    public int? Beds { get; set; }
    //public DateTime? CreatedAt { get; set; }

    public static RoomClassModel? FromDataRow(DataRow row)
    {
        return new RoomClassModel()
        {
            Name = row["Name"].ToString(),
            Beds = int.Parse(row["Beds"].ToString()),
            //CreatedAt = DateTime.Parse(row["CreatedAt"].ToString()),
        };
    }
}
