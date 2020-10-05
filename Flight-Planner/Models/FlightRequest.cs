﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Flight_Planner.Core.Models;

namespace Flight_Planner.Models
{
    public class FlightRequest
    {
        public int Id { get; set; }
        public virtual AirportRequest To { get; set; }
        public virtual AirportRequest From { get; set; }
        public string Carrier { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }

    }
}