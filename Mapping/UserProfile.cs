using System;
using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos;
using Mapster;

namespace ApiEcommerce.Mapping;

public static class UserMappingConfig
{
    public static void Register()
    {
        TypeAdapterConfig<User, UserDto>.NewConfig().TwoWays();
        TypeAdapterConfig<User, CreateUserDto>.NewConfig().TwoWays();
        TypeAdapterConfig<User, UserLoginDto>.NewConfig().TwoWays();
        TypeAdapterConfig<User, UserLoginResponseDto>.NewConfig().TwoWays();
        TypeAdapterConfig<ApplicationUser, UserDataDto>.NewConfig().TwoWays();
        TypeAdapterConfig<ApplicationUser, UserDto>.NewConfig().TwoWays();
    }
}
