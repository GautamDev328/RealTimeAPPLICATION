using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;



using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<EmployeeDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DataConnection")));



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();


//builder.Services.AddTransient<IStateRepository, StateRepository>();

//builder.Services.AddScoped<StateRepository>();

builder.Services.AddScoped<EmployeeProfileRepository>();
builder.Services.AddScoped<StateRepository>();

builder.Services.AddScoped<CustomerPricesRespository>();
//builder.Services.AddScoped<AdminLoginRepository>();
builder.Services.AddScoped<CountryRepository>();
builder.Services.AddScoped<CityRepository>();
builder.Services.AddScoped<DepartmentRepository>();
builder.Services.AddScoped<DesignationRepository>();
//builder.Services.AddScoped<EmployeeLoginRepository>();
builder.Services.AddScoped<EmployeeQueryRepository>();
builder.Services.AddScoped<GenderRepository>();
//builder.Services.AddScoped<HRLOGINRESPOROTY>();
builder.Services.AddScoped<RELATIONREPOSITORY>();
builder.Services.AddScoped<ROLEWISEREPSITORY>();
builder.Services.AddScoped<RolewiseonlyemployeeRepository>();
builder.Services.AddScoped<UserTrailRepositroy>();
builder.Services.AddScoped<AdminLoginRepository>();
builder.Services.AddScoped<PartnerLoginRepositroy>();

builder.Services.AddHttpContextAccessor();
//builder.Services.AddControllersWithViews();

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
//app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
