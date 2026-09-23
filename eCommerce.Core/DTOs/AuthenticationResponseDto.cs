namespace eCommerce.Core.DTOs
{
    public record AuthenticationResponseDto(
        Guid UserID,
        string? Email,
        string? PersonName,
        string? Gender,
        string? Token,
        bool Success
        );
}
