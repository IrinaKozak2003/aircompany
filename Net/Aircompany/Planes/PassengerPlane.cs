using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public int _passengersCapacity;

        public int PassengersCapacity
        {
            get => _passengersCapacity;
           
        }

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            _passengersCapacity = passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as PassengerPlane;
            return _passengersCapacity == plane.PassengersCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + PassengersCapacity.GetHashCode();
            return hashCode;
        }
        

       
        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + PassengersCapacity +
                    '}');
        }       
        
    }
}
