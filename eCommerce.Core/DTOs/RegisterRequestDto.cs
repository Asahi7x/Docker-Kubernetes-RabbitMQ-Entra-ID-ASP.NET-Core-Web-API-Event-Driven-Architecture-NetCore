namespace eCommerce.Core.DTOs
{
    public record RegisterRequestDto(
        string? Email,
        string? Password,
        string? PersonName,
        GenderOptions Gender
        );
    
}
