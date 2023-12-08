using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.DependencyResolver;
using Core.Entities.Concrete;
using Core.Extensions;
using Core.Utilities.IoC;
using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using ERPWebAPI.BL.DependencyResolvers.Autofac;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureDefaults(args).UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutoFacBusinessModule());
    });


// Add services to the container.
DbConnectionInfo dbConnectionInfos = builder.Configuration.GetSection("ErpConnectionOptions").Get<DbConnectionInfo>();
ApiDbConnectionInfo apiDbConnectionInfos = builder.Configuration.GetSection("ApiConnectionOptions").Get<ApiDbConnectionInfo>();

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

//ConfigurationManager ss = new ConfigurationManager();
//var creds = ss.GetSection("ApiCredentials") as NameValueCollection;

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.WithOrigins("http://localhost"));
});

var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidAudience = tokenOptions.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
        };
    });

builder.Services.AddAuthorization();//options =>
//{
//    options.AddPolicy("NeedHrPolicy", policy => policy.RequireClaim("Module", )
//        );
//});

builder.Services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSingleton(new CoreModule());

#pragma warning disable CS1022 // Type or namespace definition, or end-of-file expected
#pragma warning disable CS1003 // Syntax error, ',' expected
#pragma warning disable CS1031 // Type expected
#pragma warning disable CS1002 // ; expected
//builder.Services.AddScoped<IHR_BloodTypeService,>

var app = builder.Build();
#pragma warning restore CS1002 // ; expected
#pragma warning restore CS1031 // Type expected
#pragma warning restore CS1003 // Syntax error, ',' expected
#pragma warning restore CS1022 // Type or namespace definition, or end-of-file expected

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapDefaultControllerRoute();
//});


app.MapControllers();


//.ConfigureWebHostDefaults(webBuilder =>
//{
//    webBuilder.UseStartup();
//});

app.Run();

