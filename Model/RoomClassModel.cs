
namespace TachyDev1.Model;

internal class RoomClassModel
{
    public string? Id { get; set; }
    public string? DisplayName { get; set; }
    public double BasePrice { get; set; } = 0;
    public string? Description { get; set; }

    public DateOnly? CreatedAt { get; set; }
}
