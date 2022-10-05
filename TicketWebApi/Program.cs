using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TicketDb;
using TicketRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine(" ==========> " + connectionString);
builder.Services.AddDbContext<TicketContext>(o 
            => o.UseSqlServer(
                "Data Source=ACONTABLE14\\SQLSIGMAVER;Initial Catalog=Ticket;User Id=sa;Password=123456papichulo;MultipleActiveResultSets=True;"
            ));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();