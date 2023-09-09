using Microsoft.EntityFrameworkCore;
using teacher_crud.Interface;
using teacher_crud.Migrations;
using teacher_crud.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options=>{
    // options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

    options.UseInMemoryDatabase("teacherDb");
});

builder.Services.AddScoped<ITeacherService,TeacherService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
