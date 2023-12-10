
using ATFAL360.DTOs;
using ATFAL360.Entities;
using ATFAL360.Interfaces.Repositories;
using ATFAL360.Interfaces.Services;

namespace ATFAL360.Implementations.Services
{
    public class AtfalMemberServices : IAtfalMemberServices
    {
        private readonly IAtfalMemberRepository _atfalMemberRepository;
       
        public AtfalMemberServices(IAtfalMemberRepository atfalMemberRepository)
        {
            _atfalMemberRepository = atfalMemberRepository;
        


        }
        public bool CreateAtfalMember(CreateAtfalMemberRequestModel model)
        {
            var atfalMember = new AtfalMember
            {
                Name = model.Name,
                Dila = model.Dila,
                State = model.State,
                Age = model.Age,
                Muqami = model.Muqami,
                Region = model.Region,

            };
            _atfalMemberRepository.CreateAtfalMember(atfalMember);
            return true;

        }

        public void DeleteAtfalMember(int id)
        {
            var atfalMember = _atfalMemberRepository.GetAtfalMember(id);
            _atfalMemberRepository.Delete(atfalMember);
        }

        public AtfalMemberDto GetAtfalMember(int id)
        {
            var atfalMember = _atfalMemberRepository.GetAtfalMember(id);
            return new AtfalMemberDto
            {
                Name = atfalMember.Name,
                Dila = atfalMember.Dila,
                State = atfalMember.State,
                Age = atfalMember.Age,
                Muqami = atfalMember.Muqami,
                Region = atfalMember.Region,

            };
        }

        public IList<AtfalMemberDto> GetAllAtfalMember()
        {
            return _atfalMemberRepository.GetAllAtfalMember().Select(n => new AtfalMemberDto
            {
                Id = n.Id,
                Muqami = n.Muqami,
                Dila = n.Dila,
                State = n.State,
                Age= n.Age,
                Name = n.Name,
                Region = n.Region,
                
            }).ToList();
        }

        public bool UpdateAtfalMember(int id, UpdateAtfalMemberRequestModel model)
        {
            var atfalMember = _atfalMemberRepository.GetAtfalMember(id);
            atfalMember.Name = model.Name;
            atfalMember.Age = model.Age;
            atfalMember.Dila = model.Dila;
            atfalMember.State = model.State;
            atfalMember.Region = model.Region;
            atfalMember.Muqami = model.Muqami;



            _atfalMemberRepository.UpdateAtfalMember(atfalMember);
            return true;
        }

     
    }
}
