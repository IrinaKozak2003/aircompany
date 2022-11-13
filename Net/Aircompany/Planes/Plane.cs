using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string _model;
        public int _maxSpeed;
        public int _maxFlightDistance;
        public int _maxLoadCapacity;


        public string Model
        {
            get => _model;
        }

        public int MaxSpeed
        {
            get => _maxSpeed;
        }

        public int MaxFlightDistance
        {
            get => _maxFlightDistance;
        }

        public int MaxLoadCapacity
        {
            get => _maxLoadCapacity;
        }


        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            _model = model;
            _maxSpeed = maxSpeed;
            _maxFlightDistance = maxFlightDistance;
            _maxLoadCapacity = maxLoadCapacity;
        }

      

        public override string ToString()
        {
            return "Plane{" +
                "model='" + Model + '\'' +
                ", maxSpeed=" + MaxSpeed +
                ", maxFlightDistance=" + MaxFlightDistance +
                ", maxLoadCapacity=" + MaxLoadCapacity +
                '}';
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   Model == plane.Model &&
                   MaxSpeed == plane.MaxSpeed &&
                   MaxFlightDistance == plane.MaxFlightDistance &&
                   MaxLoadCapacity == plane.MaxLoadCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = hashCode * -1521134295 + MaxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxLoadCapacity.GetHashCode();
            return hashCode;
        }        

    }
}
