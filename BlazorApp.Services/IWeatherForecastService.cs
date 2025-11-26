using BlazorApp.Models;

namespace BlazorApp.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastsAsync();
    }
}
