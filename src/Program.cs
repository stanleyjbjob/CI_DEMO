using CI_DEMO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
MyCalc myCalc = new MyCalc();
app.MapGet("/", () => "GoodNight!!Hello World!2022,2+3=" + myCalc.Add(2, 3).ToString());

app.Run();
