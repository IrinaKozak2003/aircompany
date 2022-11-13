using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType _planeType;

        public MilitaryType PlaneType
        {
            get => _planeType;
            set => _planeType = value;
        }


        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            _planeType = type;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return _planeType == PlaneType;
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + PlaneType.GetHashCode();
            return hashCode;
        }

        


        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + PlaneType +
                    '}');
        }        
    }
}
