using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.JsonWebTokens;

namespace HospitalManager.API;

public static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers()
            .AddJsonOptions(configure => configure.JsonSerializerOptions.PropertyNamingPolicy = null);

        builder.Services.AddHttpContextAccessor();

        builder.Services.AddSwaggerGen();

        // var oracleDbConnectionString = builder.Configuration.GetValue<string>("ORACLE_DB_CONNECTION_STRING");
        // builder.Services.AddDbContext<AppDbContext>(options => options.UseOracle(oracleDbConnectionString));

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        JsonWebTokenHandler.DefaultInboundClaimTypeMap.Clear();

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = "http://hm_idp:5001/";
                options.Audience = "hospitalmanagerapi";
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new()
                {
                    NameClaimType = "given_name",
                    RoleClaimType = "role",
                    ValidTypes = new [] {"at+jwt"}
                };
            });

        builder.Services.AddAuthorization(options =>
        {
            // Add policies
        });

        return builder.Build();
    }
    
    public static WebApplication ConfigurePipeline(this WebApplication app)
    { 
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();
        
        return app;
    }
}