using CI_DEMO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
MyCalc myCalc = new MyCalc();
app.MapGet("/", () => "GG!!Hello World!2022,2+3=" + myCalc.Add(2, 3).ToString());
SqlQuery SqlQuery = new SqlQuery("SELECT * FROM HCODE WHERE H_CODE = 'H0001'", "Data Source=192.168.1.12;Initial Catalog=TASAMENGHR;Persist Security Info=True;User ID=jb;Password^Hsx9bu5t@");
SqlQuery.GetData();
app.Run();
