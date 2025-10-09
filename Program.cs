using System.Numerics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Route: /msultana25799_gmail_com
app.MapGet("/msultana25799_gmail_com", (string? x, string? y) =>
{
    if (!BigInteger.TryParse(x, out var num1) || num1 <= 0 ||
        !BigInteger.TryParse(y, out var num2) || num2 <= 0)
    {
        return Results.Text("NaN", "text/plain");
    }

    BigInteger gcd = BigInteger.GreatestCommonDivisor(num1, num2);
    BigInteger lcm = (num1 * num2) / gcd;
    return Results.Text(lcm.ToString(), "text/plain");
});

app.Run();
