using GraphQL;
using GraphQL.Types;
using GraphQlProject.Graphql.Query;
using GraphQlProject.Graphql.Schema;
using GraphQlProject.Graphql.Type;
using Microsoft.AspNetCore.Builder;
using GraphiQl;
using GraphQlProject.Infrastructure.Repsositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Repository
builder.Services.AddTransient<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IReservationRepository, ReservationRepository>();

//Types
builder.Services.AddTransient<MenuType>();
builder.Services.AddTransient<CategoryType>();
builder.Services.AddTransient<ReservationType>();

//Query
builder.Services.AddTransient<MenuQuery>();
builder.Services.AddTransient<CategoryQuery>();
builder.Services.AddTransient<ReservationQuery>();
builder.Services.AddTransient<RootQuery>();

//Bind to RootSchema
builder.Services.AddTransient<ISchema, RootSchema>();

builder.Services.AddGraphQL(g => g.AddAutoSchema<ISchema>().AddSystemTextJson());


var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.UseAuthorization();

app.MapControllers();

app.Run();
