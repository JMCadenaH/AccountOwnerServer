﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities;

public static class IEntityExtensions
{
    public static bool IsObjectNull(this IEntity entity)
    {
        return entity == null;
    }

    public static bool IsEmptyObject(this IEntity entity)
    {
        return entity.Id.Equals(Guid.Empty);
    }
}