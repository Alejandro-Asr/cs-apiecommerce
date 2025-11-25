using System;
using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos;
using Mapster;

namespace ApiEcommerce.Mapping;

public static class ProductMappingConfig
{
    public static void Register()
    {
        TypeAdapterConfig<Product, ProductDto>.NewConfig()
            .Map(dest => dest.CategoryName, src => src.Category != null ? src.Category.Name : null).TwoWays();
        TypeAdapterConfig<Product, CreateProductDto>.NewConfig().TwoWays();
        TypeAdapterConfig<Product, UpdateProductDto>.NewConfig().TwoWays();
    }
}
