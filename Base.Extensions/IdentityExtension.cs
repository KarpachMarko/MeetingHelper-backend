﻿using System.ComponentModel;
using System.Security.Claims;

namespace Base.Extensions;

public static class IdentityExtension
{
    public static Guid GetUserId(this ClaimsPrincipal user) => GetUserId<Guid>(user);

    public static TKeyType GetUserId<TKeyType>(this ClaimsPrincipal user)
    {
        var idClaim = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
        if (idClaim == null)
        {
            throw new NullReferenceException("NameIdentifier claim not found");
        }

        var res = (TKeyType?) TypeDescriptor
            .GetConverter(typeof(TKeyType))
            .ConvertFromInvariantString(idClaim.Value);

        if (res == null)
        {
            throw new NullReferenceException("User id conversion failed");
        }

        return res;
    }
}