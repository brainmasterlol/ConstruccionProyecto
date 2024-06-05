using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Model.Entitys
{
    public class Route
    {
        private int routeId { get; set; }
        private string origin { get; set; }
        private string destination { get; set; }
        private double distance { get; set; }
        private TimeSpan travelDurationTime { get; set; }
        private double travelPrice { get; set; }

        public Route() { }

        public Route(int routeId, string origin, string destination, double distance, TimeSpan travelDurationTime, double travelPrice)
        {
            this.routeId = routeId;
            this.origin = origin;
            this.destination = destination;
            this.distance = distance;
            this.travelDurationTime = travelDurationTime;
            this.travelPrice = travelPrice;
        }
    }
}