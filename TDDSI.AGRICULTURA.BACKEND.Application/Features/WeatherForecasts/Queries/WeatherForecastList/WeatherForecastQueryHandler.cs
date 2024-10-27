using TDDSI.AGRICULTURA.BACKEND.Application.Messaging;
using TDDSI.AGRICULTURA.BACKEND.Domain.Abstractions;
using TDDSI.AGRICULTURA.BACKEND.Domain.WeatherForecasts;
using TDDSI.AGRICULTURA.BACKEND.Domain.WeatherForecasts.Dtos;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
internal sealed class WeatherForecastQueryHandler(
        WeatherForecastService forecastService
    ) : IQueryHandler<WeatherForecastQuery, WeatherForecastResponse> {

    public async Task<Result<WeatherForecastResponse>> Handle( WeatherForecastQuery request
        , CancellationToken cancellationToken
    ) {

        IEnumerable<WeatherForecastDto> weatherForecasts = await forecastService.WeatherForecastsAsync();
        return new WeatherForecastResponse( weatherForecasts );
    }
}
