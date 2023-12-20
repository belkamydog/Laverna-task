class Program
{
    static HttpClient httpClient = new HttpClient();
 
    static async Task Main()
    {
        // Config conf = new Config();
        // // определяем данные запроса
        // using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, conf.GetRequestInfo());
        // // получаем ответ
        // using HttpResponseMessage response = await httpClient.SendAsync(request);
        // // содержимое ответа
        // string content = await response.Content.ReadAsStringAsync();
        // Console.WriteLine(content);

        string json = "{coord:{lon:-0.1278,lat:51.5074},weather:[{id:801,main:Clouds,description:few clouds,icon:02n}],base:stations,main:{temp:283.55,feels_like:282.76,temp_min:282.86,temp_max:284.36,pressure:1014,humidity:81},visibility:10000,wind:{speed:8.75,deg:250},clouds:{all:20},dt:1703101248,sys:{type:1,id:1414,country:GB,sunrise:1703059384,sunset:1703087563},timezone:0,id:2643743,name:London,cod:200}";
    }
}


/*
Content
{'coord':{'lon':-0.126,'lat':51.508},
'weather':[{'id':801,'main':'Clouds',
'description':'few clouds','icon':'02n'}],
'base':'stations',
'main':{'temp':283.6,
'feels_like':282.84,
'temp_min':282.84,
'temp_max':284.34,
'pressure':1014,'humidity':82},
'visibility':10000,
'wind':{'speed':8.75,
'deg':250},
'clouds':{'all':20},
'dt':1703101281,
'sys':{'type':2,'id':2006068,'country':'GB','sunrise':1703059384,'sunset':1703087562},
'timezone':0,'id':2643743,'name':'London','cod':200}
*/