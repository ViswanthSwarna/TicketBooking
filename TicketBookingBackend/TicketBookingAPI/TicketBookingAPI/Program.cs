using Microsoft.EntityFrameworkCore;
using TicketBookingAPI.Repository;
using TicketBookingAPI.Services;
using TicketBooking.Data;
using Microsoft.AspNetCore.Diagnostics;
using TicketBookingAPI.Middleware;
using Microsoft.Extensions.Logging;
using TicketBookingAPI.Extensions;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<TicketManagemetContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("APIConnection"))
    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.AddDependencies();

var app = builder.Build();

app.UseAppException();

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
