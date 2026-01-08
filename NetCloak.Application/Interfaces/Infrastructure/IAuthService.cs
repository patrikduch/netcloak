namespace NetCloak.Application.Interfaces.Infrastructure;

using NetCloak.Application.Dtos.Auth.Requests;
using NetCloak.Application.Dtos.Auth.Responses;

public interface IAuthService
{
    Task<LoginResponseDTO?> LoginAsync(LoginRequestDTO request);

    Task<LoginResponseDTO?> RefreshTokenAsync(string refreshToken);
}