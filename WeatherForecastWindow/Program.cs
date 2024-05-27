namespace WeatherForecastWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            PrecipitationSensor.PrecipitationSensor sensor = new PrecipitationSensor.PrecipitationSensor(); // Use the class within the namespace
            int[] precipitationData = sensor.GetMockPrecipitationData();

            // Displaying the weather forecast
            Console.WriteLine("Weather Forecast:");
            for (int i = 0; i < precipitationData.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: Precipitation: {precipitationData[i]}%");
            }
        }
    }
}
