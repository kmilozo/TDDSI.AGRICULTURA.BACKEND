﻿using Microsoft.AspNetCore.Http;
using TDDSI.AGRICULTURA.BACKEND.Domain.Ports;

namespace TDDSI.AGRICULTURA.BACKEND.Infrastructure.PostgreSql.Adapters;
internal sealed class AuditContexService : IAuditContex {
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuditContexService( IHttpContextAccessor httpContextAccessor ) {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? GetUserFromRecord() {
        string? name = _httpContextAccessor?.HttpContext?.User?.Identity?.Name;
        return name;
    }
}