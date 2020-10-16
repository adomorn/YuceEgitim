using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YuceEgitim.Web.Classes
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseTicket(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TicketMiddleware>();
        }
    }
}
