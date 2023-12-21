public class Config{
    private const string ADRESS = "https://api.openweathermap.org/data/2.5/weather?";
    private const string TOKEN = "095013fbfdec555a78dfffb6689c49e8";
    private string latitude_ = "51.508";
    private string longitude_ = "-0.126";
    private string units_ = "metric";
    private string language_ = "ru";
    public string GetRequestInfo() { return ADRESS + "lat=" + latitude_ + "&lon=" +longitude_  + "&appid="+ TOKEN + "&units=" + units_ + "&lang=" + language_;}

}