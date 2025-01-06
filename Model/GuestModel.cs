
namespace TachyDev1.Model;

internal class GuestModel
{
    public string? Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public Uri? Email { get; set; }
    public Uri? Phone { get; set; }
    public string? Country { get; set; }
    public string? LegalId { get; set; }
    public DateOnly? BirthDate { get; set; }
}
