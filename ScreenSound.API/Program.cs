using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Endpoints;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using System.Data.SqlTypes;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ScreenSoundContext>();
builder.Services.AddTransient<DAL<Artista>>();
builder.Services.AddTransient<DAL<Musica>>();

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

//app.MapGet("/", () =>
//{
//    var dal = new DAL<Artista>(new ScreenSoundContext());
//    return dal.Listar();
//});

app.AddEndPointsArtistas();
app.AddEndPointsMusicas();
app.AddEndPointGeneros();


app.UseSwagger();
app.UseSwaggerUI();


app.Run();
