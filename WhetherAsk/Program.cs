using System.Text.Json;
class Program
{
    static HttpClient httpClient = new HttpClient();
 
    static async Task Main()
    {
        Config conf = new Config();
        // определяем данные запроса
        using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, conf.GetRequestInfo());
        // получаем ответ
        using HttpResponseMessage response = await httpClient.SendAsync(request);
        // содержимое ответа
        string json = await response.Content.ReadAsStringAsync();
        // Console.WriteLine(content);

        // string json = @"{""coord"":{""lon"":-0.1278,""lat"":51.5074},""weather"":[{""id"":803,""main"":""Clouds"",""description"":""broken clouds"",""icon"":""04n""}],""base"":""stations"",""main"":{""temp"":284.82,""feels_like"":284.16,""temp_min"":283.75,""temp_max"":285.47,""pressure"":1005,""humidity"":81},""visibility"":10000,""wind"":{""speed"":8.75,""deg"":260},""clouds"":{""all"":75},""dt"":1703131966,""sys"":{""type"":2,""id"":2075535,""country"":""GB"",""sunrise"":1703145818,""sunset"":1703173987},""timezone"":0,""id"":2643743,""name"":""London"",""cod"":200}";
        ParseData data = JsonSerializer.Deserialize<ParseData>(json);

        
        Console.WriteLine($"temperature: {data.main.temp} C");
        Console.WriteLine($"description: {data.weather[0].description}");
        Console.WriteLine($"speed wind: {data.wind.speed} m/s");

    }
}