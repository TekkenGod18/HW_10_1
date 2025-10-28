using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10_1
{
    class Angle
    {
        public int gradus_;
        public int min_;
        public int sec_;

        public int Gradus
        {
            get { return gradus_; }
            set
            {
                if (value >= 0 && value <= 360)
                    gradus_ = value;
                else
                    throw new ArgumentOutOfRangeException("Градусы должны быть в диапазоне от 0 до 360");
            }
        }

        public int Min
        {
            get { return min_; }
            set
            {
                if (value >= 0 && value < 60)
                    min_ = value;
                else
                    throw new ArgumentOutOfRangeException("Минуты должны быть в диапазоне от 0 до 59");
            }
        }

        public int Sec
        {
            get { return sec_; }
            set
            {
                if (value >= 0 && value < 60)
                    sec_ = value;
                else
                    throw new ArgumentOutOfRangeException("Секунды должны быть в диапазоне от 0 до 59");
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public double ToRadians()
        {
            double totalDegrees = Gradus + Min / 60 + Sec / 3600;
            return totalDegrees * Math.PI / 180;
        }

        // Метод для отображения угла в понятном виде
        public override string ToString()
        {
            return $"{Gradus}° {Min}' {Sec}\"";
        }
    }
}
