using System;
using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos;
using Mapster;

namespace ApiEcommerce.Mapping;

public static class CategoryMappingConfig
{
    public static void Register()
    {
        TypeAdapterConfig<Category, CategoryDto>.NewConfig().TwoWays();
        TypeAdapterConfig<Category, CreateCategoryDto>.NewConfig().TwoWays();
    }
}
