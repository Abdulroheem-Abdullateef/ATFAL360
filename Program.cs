using ATFAL360.Context;
using ATFAL360.Implementations.Repositories;
using ATFAL360.Implementations.Services;
using ATFAL360.Interfaces.Repositories;
using ATFAL360.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationContext>(options =>
     options.UseMySQL(builder.Configuration.GetConnectionString("ConnectionContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAtfalMemberServices, AtfalMemberServices>();
builder.Services.AddScoped<IAtfalMemberRepository, AtfalMemberRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options => options.AddPolicy("Mypolicy", builder =>
{
    builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
}));


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "AFTAL360", Version = "v1" });
});


var app = builder.Build();

app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AFTAL360 v1"));
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
