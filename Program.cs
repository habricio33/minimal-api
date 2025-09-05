var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World on !");

app.MapPost("/login", ( minimal_api.Dominio.DTOs.LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "admin@teste.com.br" && loginDTO.Senha == "123456")
    {
        return Results.Ok("Login realizado com suceso");
    }
    else
    {
        return Results.Unauthorized();
    }

});


app.Run();

 