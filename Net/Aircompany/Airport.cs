using Aircompany.Models;
using Aircompany.Planes;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        public List<Plane> Planes;

        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();
        }

        public List<PassengerPlane> GetPassengersPlanes()
        {
            List<PassengerPlane> passengerPlanes = new List<PassengerPlane>();
            foreach (PassengerPlane i in Planes.Where(plane => plane.GetType()==typeof(PassengerPlane)))
            {
                passengerPlanes.Add(i);
            }
            return passengerPlanes;
        }

        public List<MilitaryPlane> GetMilitaryPlanes()
        {
            List<MilitaryPlane> militaryPlanes = new List<MilitaryPlane>();
            foreach (MilitaryPlane i in Planes.Where(plane => plane.GetType() == typeof(MilitaryPlane) ))
            {
                militaryPlanes.Add(i);
            }
            return militaryPlanes;
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            return GetPassengersPlanes().OrderBy(plane =>plane._passengersCapacity ).Last();
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            return new List<MilitaryPlane>(GetMilitaryPlanes().Where(x=>x.PlaneType==MilitaryType.TRANSPORT));
        }

        public Airport SortByMaxDistance()
        {
            return new Airport(Planes.OrderBy(w => w.MaxFlightDistance));
        }

        public Airport SortByMaxSpeed()
        {
            return new Airport(Planes.OrderBy(w => w.MaxSpeed));
        }

        public Airport SortByMaxLoadCapacity()
        {
            return new Airport(Planes.OrderBy(w => w.MaxLoadCapacity));
        }


        public IEnumerable<Plane> GetPlanes()
        {
            return Planes;
        }

        public override string ToString()
        {
            return "Airport{" +
                    "planes=" + string.Join(", ", Planes.Select(x => x.Model)) +
                    '}';
        }
    }
}
