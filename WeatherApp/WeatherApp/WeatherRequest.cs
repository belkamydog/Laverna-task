using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace WindowsFormsApp2
{
    class WeatherRequest
    {
        private HttpClient httpClient = new HttpClient();
        private Config conf_;
        
        private string temp_;
        private string desc_;
        private string wing_;

        // Геттеры для основных полей
        public string GetTemp() { return temp_; } 
        public string GetDesc() { return desc_; }
        public string GetWing() { return wing_; }

        // Конструктор задаем объект конфигурации и выполняем функции
        public WeatherRequest(Config c)
        {
           conf_ = c;
           GetWeather();
        }

        private void GetWeather()
        {
            // определяем данные запроса
            var request = (HttpWebRequest)WebRequest.Create(conf_.GetRequestInfo());
            // получаем ответ
            var response = (HttpWebResponse)request.GetResponse();
            // содержимое ответа
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            // Десериализация из json в поля класса
            ParseData data = JsonConvert.DeserializeObject<ParseData>(responseString);
            // заполняем поля данными из класса ParseData
            temp_ = $"температура: {data.main.temp} C";
            desc_ = $"описание: {data.weather[0].description}";
            wing_ = $"скорость ветра: {data.wind.speed} м/c";
        }
    }
}
