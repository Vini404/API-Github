using console_api;
using Newtonsoft.Json;
using RestSharp;

Console.Write("Nome do usuario: ");

var user = Console.ReadLine();

var userFromGithub = GetUserFromGithub(user);

var jsonToPrint = JsonConvert.SerializeObject(userFromGithub, Formatting.Indented);

Console.WriteLine(jsonToPrint);

GetUsersResponse GetUserFromGithub(string user)
{
    var api_url = $"https://api.github.com/users/{user}";
    var options = new RestClientOptions(api_url)
    {
        Timeout = 1000
    };

    var client = new RestClient(options);
    var request = new RestRequest();

    var response = client.Execute(request, cancellationToken: new CancellationToken());

    if (response.IsSuccessStatusCode)
        return System.Text.Json.JsonSerializer.Deserialize<GetUsersResponse>(response.Content);

    throw new Exception("Erro ao buscar usuario");
}