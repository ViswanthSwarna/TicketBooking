using AutoMapper;
using TicketBooking.Domain;
using TicketBooking.Repository.Interfaces;
using TicketBooking.Services.Interfaces;
using TicketBooking.Models;

namespace TicketBooking.Services.Classes
{
    public class BusService: IBusService
    {
        private readonly IBusRepository _busRepository;
        private readonly IMapper _mapper;
        private ICityRepository _cityRepository;
        public BusService(IBusRepository busRepository, IMapper mapper, ICityRepository cityRepository)
        {
            _busRepository = busRepository;
            _mapper = mapper;
            _cityRepository = cityRepository;
        }

        public int AddBus(BusModel busModel)
        {
            Bus bus = _mapper.Map<Bus>(busModel);
            bus.SourceCity = _cityRepository.FindIdByName(bus.SourceCity.Name);
            bus.DestinationCity = _cityRepository.FindIdByName(bus.DestinationCity.Name);
            _busRepository.Insert(bus);
            var inserted = _busRepository.Save();
            return inserted;
        }

        public int DeleteBus(int id)
        {
            _busRepository.Delete(id);
            var deleted = _busRepository.Save();
            return deleted;
        }

        public BusModel GetBus(int id)
        {
            var bus = _busRepository.Find(id);
            var busModel = _mapper.Map<BusModel>(bus);
            return busModel;
        }

        public IEnumerable<BusModel> GetBuses()
        {
            var buses = _busRepository.GetAll();
            var busModels = _mapper.Map<IEnumerable<BusModel>>(buses);
            return busModels;
        }

        public int UpdateBus(BusModel busModel)
        {
            var bus = _mapper.Map<Bus>(busModel);
            bus.SourceCity = _cityRepository.FindIdByName(bus.SourceCity.Name);
            bus.DestinationCity = _cityRepository.FindIdByName(bus.DestinationCity.Name);
            _busRepository.Update(bus);
            var updated = _busRepository.Save();
            return updated;
        }
    }
}
