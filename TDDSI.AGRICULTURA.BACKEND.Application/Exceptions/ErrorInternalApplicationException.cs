﻿namespace TDDSI.AGRICULTURA.BACKEND.Application.Exceptions;

public class ErrorInternalApplicationException : ApplicationException {
    public ErrorInternalApplicationException( string? message ) : base( message ) {

    }
}
