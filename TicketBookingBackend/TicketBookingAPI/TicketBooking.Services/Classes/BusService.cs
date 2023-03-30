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

        public async Task<int> AddBus(BusModel busModel)
        {
            Bus bus = _mapper.Map<Bus>(busModel);
            bus.SourceCity = await _cityRepository.FindIdByName(bus.SourceCity.Name);
            bus.DestinationCity = await _cityRepository.FindIdByName(bus.DestinationCity.Name);
            _busRepository.Insert(bus);
            var inserted = await _busRepository.Save();
            return inserted;
        }

        public async Task<int> DeleteBus(int id)
        {
            await _busRepository.Delete(id);
            var deleted = await _busRepository.Save();
            return deleted;
        }

        public async Task<BusModel> GetBus(int id)
        {
            var bus = await _busRepository.Find(id);
            var busModel = _mapper.Map<BusModel>(bus);
            return busModel;
        }

        public async Task<IEnumerable<BusModel>> GetBuses()
        {
            var buses = await _busRepository.GetAll();
            var busModels = _mapper.Map<IEnumerable<BusModel>>(buses);
            return busModels;
        }

        public async Task<int> UpdateBus(BusModel busModel)
        {
            var bus = _mapper.Map<Bus>(busModel);
            bus.SourceCity = await _cityRepository.FindIdByName(bus.SourceCity.Name);
            bus.DestinationCity = await _cityRepository.FindIdByName(bus.DestinationCity.Name);
            _busRepository.Update(bus);
            var updated = await _busRepository.Save();
            return updated;
        }


        public async Task<IEnumerable<BusModel>> GetBuses(BusSearchInputModel busSearchInput)
        {
            var cities = await _busRepository.GetBuses(busSearchInput);
            return cities;
        }
    }
}
