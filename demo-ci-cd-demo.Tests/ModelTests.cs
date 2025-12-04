namespace demo_ci_cd_demo.Tests
{
    public class ModelTests
    {
        [Fact]
        public void WeatherForecast_Test()
		{
			var date = DateOnly.FromDateTime(DateTime.Now);
            int temperatureC = 25;
            string summary = "Sunny";

            WeatherForecast weatherForecast = new(date, temperatureC, summary);
            
            Assert.Equal(date, weatherForecast.Date);
            Assert.Equal(temperatureC, weatherForecast.TemperatureC);
            Assert.Equal(summary, weatherForecast.Summary);

			Assert.Equal(32 + (int)(temperatureC / 0.5556), weatherForecast.TemperatureF);
		}
    }
}
