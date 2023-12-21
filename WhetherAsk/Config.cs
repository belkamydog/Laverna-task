// Класс конфигурации и настроек приложения
public class Config{
    // Основной ресурс
    private const string ADRESS = "https://api.openweathermap.org/data/2.5/weather?";
    // Токен для доступа
    private const string TOKEN = "095013fbfdec555a78dfffb6689c49e8";
    // Широта (координата в десятичных градуса)
    private string latitude_ = "51.508";
    // Долгота (координата в десятичных градуса)
    private string longitude_ = "-0.126";
    // Система исчисления
    private string units_ = "metric";
    // Язык
    private string language_ = "ru";
    // Строка с готовым запросом
    public string GetRequestInfo() { return ADRESS + "lat=" + latitude_ + "&lon=" +longitude_  + "&appid="+ TOKEN + "&units=" + units_ + "&lang=" + language_;}

}