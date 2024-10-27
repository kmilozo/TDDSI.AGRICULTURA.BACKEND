﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TDDSI.AGRICULTURA.BACKEND.Domain.Primitives;
using TDDSI.AGRICULTURA.BACKEND.Domain.WeatherForecasts;

namespace TDDSI.AGRICULTURA.BACKEND.Infrastructure.PostgreSql.Configurations;
internal sealed class WeatherForecastConfiguration
    : IEntityTypeConfiguration<WeatherForecast> {
    public void Configure( EntityTypeBuilder<WeatherForecast> builder ) {
        builder.ToTable( "WeatherForecasts" );
        builder.HasKey( property => property.Id );
        builder.Property( property => property.Date );
        builder.Property( property => property.TemperatureC );
        builder.Property( property => property.Summary );

        builder
            .Property( property => property.Temperature )
            .HasConversion(
                conversion => conversion.Value
                , value => new Temperature( value ) );

        builder.Property( property => property.Enabled );
    }
}
