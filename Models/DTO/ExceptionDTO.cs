using System.Text.Json;

namespace webapi.Models.DTO;

public record ExceptionDTO
{
    public int Code { get; set; }
    public string[]? Messages { get; set; }
    public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
}