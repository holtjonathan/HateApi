using System.Linq;
using GraphQL.Types;
using HateApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HateApi.GraphQL
{
    public class ScenarioQuery : ObjectGraphType
    {
        public ScenarioQuery(HateContext db)
        {
            Field<ScenarioType>(
              "Scenario",
              arguments: new QueryArguments(
                new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the Scenario." }),
              resolve: context =>
              {
                  var id = context.GetArgument<int>("id");
                  var scenario = db
              .Scenarios
              .Include(a => a.ScenarioRewardAssignments).ThenInclude(f => f.Reward)
              .Include(a => a.ScenarioSpecialAssignments).ThenInclude(f => f.Special)
              .FirstOrDefault(i => i.ScenarioId == id);
                  return scenario;
              });

            Field<ListGraphType<ScenarioType>>(
              "Scenarios",
              resolve: context =>
              {
                  var scenarios = db
                  .Scenarios
                  .Include(a => a.ScenarioRewardAssignments).ThenInclude(f => f.Reward)
                  .Include(a => a.ScenarioSpecialAssignments).ThenInclude(f => f.Special);
                  return scenarios;
              });

            Field<ListGraphType<RewardType>>(
              "Rewards",
              resolve: context =>
              {
                  var rewards = db.Rewards;
                  return rewards;
              });

            Field<ListGraphType<SpecialType>>(
              "Specials",
              resolve: context =>
              {
                  var specials = db.Specials;
                  return specials;
              });
        }
    }
}