using AkilliFitApp.Application.DTOs.EgzersizBilgi;
using AkilliFitApp.Application.Interfaces.IRepository;
using AkilliFitApp.Application.Interfaces.IService;
using AkilliFitApp.Application.Mapping;
using AkilliFitApp.Application.Services;
using AkilliFitApp.Infrastructure.Data;
using AkilliFitApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

var conn = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AkilliFitAppDbContext>(options =>
    options.UseSqlServer(conn));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);



builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IKullaniciRepository), typeof(KullaniciRepository));
builder.Services.AddScoped(typeof(IEgzersizBilgiRepository), typeof(EgzersizBilgiRepository));
builder.Services.AddScoped(typeof(IEgzersizProgramRepository), typeof(EgzersizProgramRepository));
builder.Services.AddScoped(typeof(IDiyetProgramRepository), typeof(DiyetProgramRepository));
builder.Services.AddScoped(typeof(IDiyetBesinRepository), typeof(DiyetBesinRepository));
builder.Services.AddScoped(typeof(IEgzersizNotRepository), typeof(EgzersizNotRepository));

builder.Services.AddScoped(typeof(IKullaniciService), typeof(KullaniciService));
builder.Services.AddScoped(typeof(IEgzersizBilgiService), typeof(EgzersizBilgiService));
builder.Services.AddScoped(typeof(IEgzersizProgramService), typeof(EgzersizProgramService));
builder.Services.AddScoped(typeof(IDiyetProgramService), typeof(DiyetProgramService));
builder.Services.AddScoped(typeof(IDiyetBesinService), typeof(DiyetBesinService));
builder.Services.AddScoped(typeof(IEgzersizNotService), typeof(EgzersizNotService));



var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AkilliFitAppDbContext>();

    db.Database.EnsureCreated();

    db.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
