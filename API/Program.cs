using API;
using API.Extensions;
using Entity.Context;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Infrastructure;
using Repository.Implementations;
using Repository.Interfaces;
using Service.Implementations;
using Service.Interfaces;
using System.Text.Json.Serialization;
using Utilities.Email.Implement;
using Utilities.Email.Interfaces;
using Utilities.JwtAuthentication;




var builder = WebApplication.CreateBuilder(args);


// SQL Server
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// PostgreSQL (habilítalo si lo necesitas)
builder.Services.AddDbContext<ApplicationContextPostgres>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

// MySQL (deshabilitado por ahora)
/*
builder.Services.AddDbContext<ApplicationContextMySQL>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MysqlConnetion"),
        new MySqlServerVersion(new Version(8, 0, 36))
    ));
*/


builder.Services.AddControllers().AddJsonOptions(options =>
{
    // Evitar referencias cíclicas
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<SupabaseStorageService>();

builder.Services.AddCustomSwagger();

ServiceExtensions.AddCustomServices(builder.Services);

QuestPDF.Settings.License = LicenseType.Community;



// Añadir autenticación personalizada
AuthenticationConfiguration.AddCustomAuthentication(builder.Services, builder.Configuration);

MapperExtension.ConfigureAutoMapper(builder.Services);





//  SERVICIO DE EMAIL

builder.Services.AddTransient<Utilities.Email.Interfaces.IEmailService, Utilities.Email.Implements.EmailService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IBrevoEmailService, BrevoEmailService>();


builder.Services.AddScoped<AccountNotificationService>();




// CONFIGURACIÓN DE CORS (permite acceso desde frontend)

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


// CONSTRUCCIÓN DE LA APLICACIÓN
var app = builder.Build();


//  MIGRACIONES AUTOMÁTICAS (opcional)

using (var scope = app.Services.CreateScope())
{
    var sqlServerContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
    sqlServerContext.Database.Migrate();

    // Si deseas aplicar también las migraciones de otros motores, descomenta:

    // var postgresContext = scope.ServiceProvider.GetRequiredService<ApplicationContextPostgres>();
    //  postgresContext.Database.Migrate();

    //    var mySqlContext = scope.ServiceProvider.GetRequiredService<ApplicationContextMySQL>();
    //  mySqlContext.Database.Migrate();

}


//  CONFIGURACIÓN DEL PIPELINE HTTP
app.UseStaticFiles();
app.UseCustomSwagger();


// CORS global
app.UseCors("AllowAll");

// HTTPS Redirection
app.UseHttpsRedirection();

// Autenticación y Autorización
app.UseAuthentication();
app.UseAuthorization();

// Mapear controladores
app.MapControllers();

// Ejecutar aplicación
app.Run();
