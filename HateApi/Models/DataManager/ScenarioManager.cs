using HateApi.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace HateApi.Models.DataManager
{
    public class ScenarioManager : IDataRepository<Scenario>
    {
        readonly HateContext _hateContext;

        public ScenarioManager(HateContext context)
        {
            _hateContext = context;
        }

        public IEnumerable<Scenario> GetAll()
        {
            return _hateContext.Scenarios.ToList();
        }

        public Scenario Get(long id)
        {
            return _hateContext.Scenarios
                  .FirstOrDefault(e => e.ScenarioId == id);
        }

        public void Add(Scenario entity)
        {
            _hateContext.Add(entity);
            _hateContext.SaveChanges();
        }

        public void Update(Scenario scenario, Scenario entity)
        {
            scenario.Name = entity.Name;
            scenario.Description = entity.Description;

            _hateContext.SaveChanges();
        }

        public void Delete(Scenario scenario)
        {
            _hateContext.Remove(scenario);
            _hateContext.SaveChanges();
        }
    }
}
