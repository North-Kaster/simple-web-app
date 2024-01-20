using MathService;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "The factorial of 5 is: " + FactorialService.getFactorialOf(5));

app.Run();
