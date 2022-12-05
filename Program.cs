using EmployeeAPI.Data;
using EmployeeAPI.GenericRepo;
using EmployeeAPI.GenericRepo.Repo;
using EmployeeAPI.GraphQL;
using EmployeeAPI.Model;
using GraphQL.Server;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
 
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConncetion"));
});

builder.Services.AddScoped<IGenericRepo<Employee>, EmployeeRepo>();
builder.Services.AddScoped<IGenericRepo<Department>, DepartmentRepo>();
builder.Services.AddScoped<GraphQLSchema>();

#pragma warning disable CS0612 // Type or member is obsolete
builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = true;
})
.AddGraphTypes(ServiceLifetime.Scoped)
.AddSystemTextJson();
#pragma warning restore CS0612 // Type or member is obsolete


builder.Services.AddCors(options =>
                               options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader()));
        
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseGraphQL<GraphQLSchema>();
    app.UseGraphQLPlayground();
    //new PlaygroundOptions { GraphQLEndPoint = "/graphql" }, "/ui/graphql"
}
app.UseHttpsRedirection();
app.Run();
