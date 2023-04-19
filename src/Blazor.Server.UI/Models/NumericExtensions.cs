﻿using System.Globalization;

namespace Blazor.Server.UI.Models;

public static class NumericExtensions
{
    public static string RoundedToString(this decimal? num)
    {
        if (num is null)
        {
            return "0";
        }
        if (num > 999999999 || num < -999999999)
        {
            return num.Value.ToString("0,,,.#B", CultureInfo.InvariantCulture);
        }
        else if (num > 999999 || num < -999999)
        {
            return num.Value.ToString("0,,.#M", CultureInfo.InvariantCulture);
        }
        else if (num > 9999 || num < -9999)
        {
            return num.Value.ToString("0,k", CultureInfo.InvariantCulture);
        }
        else if (num > 999 || num < -999)
        {
            return num.Value.ToString("0,.#k", CultureInfo.InvariantCulture);
        }
        else
        {
            return num.Value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
