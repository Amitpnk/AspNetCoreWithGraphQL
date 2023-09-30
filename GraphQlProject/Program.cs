using GraphQL;
using GraphQL.Types;
using GraphQlProject.Graphql.Query;
using GraphQlProject.Graphql.Schema;
using GraphQlProject.Graphql.Type;
using GraphQlProject.Interfaces;
using GraphQlProject.Services;
using Microsoft.AspNetCore.Builder;
using GraphiQl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IMenuRepository, MenuRepository>();

builder.Services.AddTransient<MenuType>();
builder.Services.AddTransient<MenuQuery>();
builder.Services.AddTransient<ISchema, MenuSchema>();

builder.Services.AddGraphQL(g => g.AddAutoSchema<ISchema>().AddSystemTextJson());


var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.UseAuthorization();

app.MapControllers();

app.Run();
