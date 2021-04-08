using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Ecomerce
{
    public class ProjMiddleware
    {
        private readonly RequestDelegate _next;
        public ProjMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //string request = context.Request.Host.Value;
            //Console.WriteLine("lógica de tratamento da requisição aplicada!" + request);
           
            await _next(context);

            //Console.WriteLine("retorno da requisição!");

        }
    }
}
