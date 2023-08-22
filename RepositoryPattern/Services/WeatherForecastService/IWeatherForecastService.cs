namespace RepositoryPattern.Services.WeatherForecastService
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}
