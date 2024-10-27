using TDDSI.AGRICULTURA.BACKEND.Application.Messaging;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Features.WeatherForecastsHistories.WeatherForecastById;
public record WeatherForecastHistoryByIdQuery(
    Guid Id
) : IQuery<WeatherForecastHistoryByIdQueryResponse>;