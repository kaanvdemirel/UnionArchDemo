using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<IProductService, ProductManager>();
builder.Services.AddSingleton<IProductDal, EfProductDal>();
builder.Services.AddSingleton<ICustomerService,CustomerManager > ();
builder.Services.AddSingleton<ICustomerDal, EfCustomerDal>();
builder.Services.AddSingleton<IOrderService,OrderManager>();
builder.Services.AddSingleton<IOrderDal,EfOrderDal>();

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

// Enable serving static files
app.UseStaticFiles(); // Make sure this is present to serve static files like index.html

// Redirect root to index.html
app.MapGet("/", (HttpContext context) =>
{
    context.Response.Redirect("/pages/index.html");
});

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();