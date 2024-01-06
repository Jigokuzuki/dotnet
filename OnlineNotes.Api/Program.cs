using OnlineNotes.Api.Endpoints;
using OnlineNotes.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<INotesRepository, InMemNotesRepository>();

var conString = builder.Configuration.GetConnectionString("OnlineNotesContext");

var app = builder.Build();

app.MapNotesEndpoints();

app.Run();
