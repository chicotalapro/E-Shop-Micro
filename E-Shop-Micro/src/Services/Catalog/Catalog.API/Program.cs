var builder = WebApplication.CreateBuilder(args);
//Add service DI

var app = builder.Build();
//Configure HTTP pineline
app.Run();
