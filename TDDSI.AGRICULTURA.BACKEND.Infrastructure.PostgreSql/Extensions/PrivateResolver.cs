﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace TDDSI.AGRICULTURA.BACKEND.Infrastructure.PostgreSql.Extensions;
internal class PrivateResolver : DefaultContractResolver {

    protected override JsonProperty CreateProperty(
        MemberInfo member
        , MemberSerialization memberSerialization
    ) {
        JsonProperty prop = base.CreateProperty(
            member
            , memberSerialization
        );

        if (!prop.Writable) {
            PropertyInfo? property = member as PropertyInfo;
            bool hasPrivateSetter = property?.GetSetMethod( true ) != null;
            prop.Writable = hasPrivateSetter;
        }

        return prop;
    }
}
