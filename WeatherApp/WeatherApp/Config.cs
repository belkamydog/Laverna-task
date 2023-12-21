using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Config
    {
        // Основной ресурс
        private const string ADRESS = "https://api.openweathermap.org/data/2.5/weather?";
        // Токен для доступа
        private const string TOKEN = "095013fbfdec555a78dfffb6689c49e8";
        // Широта (координата в десятичных градуса)
        private string latitude_;
        // Долгота (координата в десятичных градуса)
        private string longitude_;
        // Система исчисления
        private string units_ = "metric";
        // Язык
        private string language_ = "ru";
        // Строка с готовым запросом
        public string GetRequestInfo() { return ADRESS + "lat=" + latitude_ + "&lon=" + longitude_ + "&appid=" + TOKEN + "&units=" + units_ + "&lang=" + language_; }


        public void SetCountry(string countru)
        {
            switch (countru)
            {
                case "Казань":
                    latitude_ = "55.79";
                    longitude_ = "49.12";
                    break;
                case "Москва":
                    latitude_ = "55.75";
                    longitude_ = "37.62";
                    break;
                case "Санкт-Петербург":
                    latitude_ = "59.94";
                    longitude_ = "30.31";
                    break;
                case "Сочи":
                    latitude_ = "43.6";
                    longitude_ = "39.73";
                    break;
                case "Владивосток":
                    latitude_ = "43.11";
                    longitude_ = "131.87";
                    break;
                case "Екатеринбург":
                    latitude_ = "56.85";
                    longitude_ = "60.61";
                    break;
                default:
                    latitude_ = "55.79";
                    longitude_ = "49.12";
                    break;
            }
        }

    }
}
