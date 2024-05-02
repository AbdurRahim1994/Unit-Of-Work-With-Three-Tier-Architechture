using DataAccessLayer.Data;
using DataAccessLayer.IRepositories.Memorandum;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Repositories.Memorandum;
using BusinessAccessLayer.Interface.Memorandum;
using BusinessAccessLayer.Services.Memorandum;
using BusinessAccessLayer.UnitOfWork.Interface;
using BusinessAccessLayer.UnitOfWork.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Database Connection
var ConnectionString = string.Empty;
ConnectionString = builder.Configuration.GetConnectionString("Development");
builder.Services.AddDbContext<MemorandumDbContext>(option=>option.UseSqlServer(ConnectionString));
#endregion

#region Interface Implementation
builder.Services.AddTransient<IMemorandumRepository, MemorandumRepository>();
builder.Services.AddTransient<IMemorandumService, MemorandumService>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
#endregion

var app = builder.Build();

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
