using HospitalManager.API.DbContexts;
using HospitalManager.API.Repositories;
using HospitalManager.API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
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

        var oracleDbConnectionString = builder.Configuration.GetValue<string>("ORACLE_DB_CONNECTION_STRING");
        builder.Services.AddDbContext<ApiDbContext>(options => options.UseOracle(oracleDbConnectionString));

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        builder.Services.AddScoped<IMedicineRepository, MedicineRepository>();

        builder.Services.AddScoped<IMedicineService, MedicineService>();

        builder.Services.AddScoped<IInsuranceRepository, InsuranceRepository>();

        builder.Services.AddScoped<IPatientRepository, PatientRepository>();

        builder.Services.AddScoped<IPatientService, PatientService>();

        builder.Services.AddScoped<IPersonRepository, PersonRepository>();

        builder.Services.AddScoped<IAddressRepository, AddressRepository>();


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