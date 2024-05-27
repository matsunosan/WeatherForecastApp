using System;

namespace PrecipitationSensor
{
    public class PrecipitationSensor
    {
        public int[] GetMockPrecipitationData()
        {
            // Generating mock precipitation data
            Random random = new Random();
            int[] precipitationData = new int[7]; // 7 days of data
            for (int i = 0; i < precipitationData.Length; i++)
            {
                precipitationData[i] = random.Next(0, 100); // Random precipitation values between 0 and 100
            }
            return precipitationData;
        }
    }
}
