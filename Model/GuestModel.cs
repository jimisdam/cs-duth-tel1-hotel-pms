
using System.Data;

namespace TachyDev.Model;

internal class GuestModel
{
    public string? Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public Uri? Email { get; set; }
    //public Uri? Phone { get; set; }
    public string? Country { get; set; }
    public string? LegalId { get; set; }
    public DateTime? BirthDate { get; set; }

    public static GuestModel? FromDataRow(DataRow row)
    {
        return new GuestModel()
        {
            Id = row["Id"].ToString(),
            LastName = row["LastName"].ToString(),
            FirstName = row["FirstName"].ToString(),
            Email = new Uri($"mailto:{row["EmailAddress"]}"),
            //Phone = new Uri($"tel:{row["Phone"]}"),
            Country = row["Country"].ToString(),
            LegalId = row["LegalId"].ToString(),
            BirthDate = DateTime.Parse(row["BirthDate"].ToString()),
        };
    }
}
