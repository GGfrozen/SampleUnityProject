using NUnit.Framework;
using Unity.PerformanceTesting;
using UnityEngine;

namespace Tests
{
    public class NewTestScript 
    {
        [Test, Performance]
        public void TestDistance()
        {
            Measure.Method(() => distance())
                .WarmupCount(10)
                .MeasurementCount(1000).Run();
        }

        [Test, Performance]
        public void TestSqrMagnitude()
        {
            Measure.Method(() => sqrmag())
                .WarmupCount(10)
                .MeasurementCount(1000).Run();
        }

        private static float distance()
        {
            return Vector3.Distance(v2, v1);
        }

        private static float sqrmag()
        {
            return Vector3.SqrMagnitude(v2 - v1);
        }
        private static Vector3 v1 = new Vector3(Random.value,Random.value,Random.value);
        private static Vector3 v2 = new Vector3(Random.value,Random.value,Random.value);
    }
}
