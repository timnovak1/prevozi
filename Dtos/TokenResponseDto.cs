using Prevozi.WebApi.Models;

namespace Prevozi.WebApi.Dtos;

public record TokenResponseDto(string Token, UserDto UserDto);