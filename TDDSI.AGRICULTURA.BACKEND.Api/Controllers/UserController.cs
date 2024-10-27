﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using TDDSI.AGRICULTURA.BACKEND.Application.Features.Users.CreateUser;
using TDDSI.AGRICULTURA.BACKEND.Application.Messaging;
using TDDSI.AGRICULTURA.BACKEND.Domain.Abstractions;
using TDDSI.AGRICULTURA.BACKEND.Domain.Helpers;

namespace TDDSI.AGRICULTURA.BACKEND.Api.Controllers;
[Route( "api/v1/[controller]" )]
public class UserController(
    ILogger<UserController> logger,
    IDispatch dispatch
) : ControllerBase {

    [HttpPost()]
    public async Task<ActionResult<Result>> CreateWeatherForecastAsync(
        [FromBody] UserCommand request,
        CancellationToken cancellationToken
    ) {
        logger.LogInformation(
            "En la siguiente fecha {date} a las {time}, se llamo el endpoint {endpoint} de la clase {class}",
                DateTime.Now.ZoneByIdPacificStandardTime().ToString( "dd/MM/yyyy", provider: new CultureInfo( "es-CO" ) ),
                DateTime.Now.ZoneByIdPacificStandardTime().ToString( "hh:mm tt" ),
                "UserController",
                nameof( UserController )
        );

        return await dispatch.Send(
            request,
            cancellationToken
        );
    }
}
