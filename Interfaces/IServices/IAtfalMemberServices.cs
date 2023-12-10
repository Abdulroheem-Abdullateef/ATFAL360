
using ATFAL360.DTOs;

namespace ATFAL360.Interfaces.Services
{
    public interface IAtfalMemberServices
    {
        bool CreateAtfalMember(CreateAtfalMemberRequestModel model);
        bool UpdateAtfalMember(int id, UpdateAtfalMemberRequestModel model);
        AtfalMemberDto GetAtfalMember(int id);

        IList<AtfalMemberDto> GetAllAtfalMember();

        void DeleteAtfalMember(int id);



    }
}
