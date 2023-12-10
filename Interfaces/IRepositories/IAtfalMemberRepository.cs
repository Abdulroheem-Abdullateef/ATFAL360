
using ATFAL360.Entities;

namespace ATFAL360.Interfaces.Repositories
{
    public interface IAtfalMemberRepository
    {
        AtfalMember CreateAtfalMember(AtfalMember atfalMember);
        AtfalMember UpdateAtfalMember(AtfalMember atfalMember);
        AtfalMember GetAtfalMember(int id);
        List<AtfalMember> GetAllAtfalMember();
        void Delete(AtfalMember atfalMember);
        AtfalMember GetByCourseName(string atfalMemberName);
        bool AtfalExists(string atfalMember);
        IEnumerable<AtfalMember> GetSelectedAtfal(IList<string> name);
      
    }
}
