using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PaymentSystem.Api.Extentions;
using PaymentSystem.Dal;


var builder = WebApplication.CreateBuilder(args);
builder.RegisterServices(typeof(Program));
var app = builder.Build();
app.RegisterPipelineComponents(typeof(Program));
app.Run();
