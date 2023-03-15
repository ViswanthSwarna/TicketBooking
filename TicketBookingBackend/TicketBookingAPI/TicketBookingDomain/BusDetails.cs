using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingDomain
{
    public class BusDetails
    {
        public int Id { get; set; }
        public string BusName { get; set; }
        public string Type { get; set; }
        public int SourceCityId { get; set; }
        public int DestinationCityId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        [ForeignKey(nameof(SourceCityId))]
        public CityDetails SourceCityDetails { get; set; }
        [ForeignKey(nameof(DestinationCityId))]
        public CityDetails DestinationCityDetails { get; set; }
    }
}
