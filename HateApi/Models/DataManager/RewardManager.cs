using HateApi.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace HateApi.Models.DataManager
{
    public class RewardManager : IDataRepository<Reward>
    {
        readonly HateContext _hateContext;

        public RewardManager(HateContext context)
        {
            _hateContext = context;
        }

        public IEnumerable<Reward> GetAll()
        {
            return _hateContext.Rewards.ToList();
        }

        public Reward Get(long id)
        {
            return _hateContext.Rewards
                  .FirstOrDefault(e => e.RewardId == id);
        }

        public void Add(Reward entity)
        {
            _hateContext.Add(entity);
            _hateContext.SaveChanges();
        }

        public void Update(Reward reward, Reward entity)
        {
            reward.Name = entity.Name;
            reward.Description = entity.Description;

            _hateContext.SaveChanges();
        }

        public void Delete(Reward reward)
        {
            _hateContext.Remove(reward);
            _hateContext.SaveChanges();
        }
    }
}
