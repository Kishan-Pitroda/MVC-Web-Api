using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Extensions
{
    public class CorsMiddlewareExtensions
    {
        public static void AddCorsExtension(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("PolicyOne",
                    builder =>
                    {
                        builder.WithOrigins("http://example.com",
                                            "http://www.contoso.com");
                    });

                options.AddPolicy("PolicyTwo",
                    builder =>
                    {
                        builder.WithOrigins("http://www.contoso.com")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
            });

        }
    }
}
