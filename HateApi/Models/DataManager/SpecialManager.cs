using HateApi.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace HateApi.Models.DataManager
{
    public class SpecialManager : IDataRepository<Special>
    {
        readonly HateContext _hateContext;

        public SpecialManager(HateContext context)
        {
            _hateContext = context;
        }

        public IEnumerable<Special> GetAll()
        {
            return _hateContext.Specials.ToList();
        }

        public Special Get(long id)
        {
            return _hateContext.Specials
                  .FirstOrDefault(e => e.SpecialId == id);
        }

        public void Add(Special entity)
        {
            _hateContext.Add(entity);
            _hateContext.SaveChanges();
        }

        public void Update(Special special, Special entity)
        {
            special.Name = entity.Name;
            special.Description = entity.Description;

            _hateContext.SaveChanges();
        }

        public void Delete(Special special)
        {
            _hateContext.Remove(special);
            _hateContext.SaveChanges();
        }1
    }
}
