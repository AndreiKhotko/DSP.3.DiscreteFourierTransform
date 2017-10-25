using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteFourierTransform
{
    public class Signal
    {
        public Amplitude Amplitude => _amplitude ?? new Amplitude(this);

        public int N
        {
            get { return _N; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"N = {value} is less or equals to zero");

                _N = value;
            }
        }

        public int J
        {
            get { return _j; }
            set
            {
                if (value < 0)
                    throw new ArgumentException($"J = {value} is less than zero");

                _j = value;
            }
        }

        private int _N;
        private int _j;
        private Amplitude _amplitude;
        public Signal(int N, int j)
        {
            this.N = N;
            J = j;
        }

        public double GetValue(int i) => 30 * Math.Cos(2 * Math.PI * i / N - 3 * Math.PI / 4);
        

    }
}
