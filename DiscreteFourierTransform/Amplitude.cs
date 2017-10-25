using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteFourierTransform
{
    public class Amplitude
    {
        public double SinComponent
        {
            get
            {
                double sum = 0;

                for (int i = 0; i < _signal.N; i++)
                {
                    sum += _signal.GetValue(i) * Math.Sin(2 * Math.PI * _signal.J * i / _signal.N);
                }

                return 2 * sum / _signal.N;
            }
        }

        public double CosComponent
        {
            get
            {
                double sum = 0;

                for (int i = 0; i < _signal.N; i++)
                {
                    sum += _signal.GetValue(i) * Math.Cos(2 * Math.PI * _signal.J * i / _signal.N);
                }

                return 2 * sum / _signal.N;
            }
        }

        public double Value => Math.Sqrt(Sqr(SinComponent) + Sqr(CosComponent));

        public double Phase => Math.Atan(SinComponent / CosComponent);

        private readonly Signal _signal;
        public Amplitude(Signal signal)
        {
            if (signal == null)
                throw new ArgumentNullException(nameof(signal));

            _signal = signal;
        }

        

        public static double GetPhase()
        {
            
        }

        private static double Sqr(double d) => d * d;
    }
}
