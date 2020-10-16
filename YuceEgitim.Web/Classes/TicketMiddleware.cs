using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YuceEgitim.Web.Classes
{
    public class TicketMiddleware
    {

        private readonly RequestDelegate _next;

        public TicketMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ITicket ticket) {

            ticket.IPAddress = context.Connection.RemoteIpAddress.ToString();
            ticket.Path = context.Request.Path;
            ticket.Method = context.Request.Method;

            await _next(context);
        }
    }
}
