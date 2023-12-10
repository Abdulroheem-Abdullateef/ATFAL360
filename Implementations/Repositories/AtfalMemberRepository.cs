

using ATFAL360.Context;
using ATFAL360.Entities;
using ATFAL360.Interfaces.Repositories;

namespace ATFAL360.Implementations.Repositories
{
    public class AtfalMemberRepository : IAtfalMemberRepository
    {

        private readonly ApplicationContext _context;

        public AtfalMemberRepository(ApplicationContext context)
        {
            _context = context;
        }

        public bool AtfalExists(string atfalMember)
        {
            _context.Atfals.Find(atfalMember);
            return true;
        }


        public AtfalMember CreateAtfalMember(AtfalMember atfalMember)
        {
            _context.Atfals.Add(atfalMember);
            _context.SaveChanges();
            return atfalMember;
        }

        public void Delete(AtfalMember atfalMember)
        {
            _context.Atfals.Remove(atfalMember);
            _context.SaveChanges();
        }

        public List<AtfalMember> GetAllAtfalMember()
        {
           return  _context.Atfals.ToList();
        }

      

        public AtfalMember GetAtfalMember(int id)
        {
            return _context.Atfals.Find(id);
        }

        public AtfalMember GetByCourseName(string atfalMemberName)
        {
            return _context.Atfals.Find(atfalMemberName);
        }

        public IEnumerable<AtfalMember> GetSelectedAtfal(IList<string> names)
        {
            return _context.Atfals.Where(a => names.Contains(a.Name)).ToList();
        }


        public AtfalMember UpdateAtfalMember(AtfalMember atfalMember)
        {
            _context.Atfals.Update(atfalMember);
            _context.SaveChanges();
            return atfalMember;
        }

    }
}
