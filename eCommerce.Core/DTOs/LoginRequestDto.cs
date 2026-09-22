namespace eCommerce.Core.DTOs
{
    public record LoginRequestDto(
        string? Email,
        string? Password
        );
}
