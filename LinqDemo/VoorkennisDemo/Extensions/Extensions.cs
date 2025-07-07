using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorkennisDemo.Extensions;

static class Extensions
{
    public static string ToPrettyString(this DateTime date)
    {
        return $"{date.ToString("d MMM yyyy")}";
    }
}
