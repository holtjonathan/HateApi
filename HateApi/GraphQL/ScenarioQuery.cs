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
              //.Include(a => a.)
              .FirstOrDefault(i => i.ScenarioId == id);
                  return scenario;
              });

            Field<ListGraphType<ScenarioType>>(
              "Scenarios",
              resolve: context =>
              {
                  var scenarios = db.Scenarios;//.Include(a => a.Books);
                  return scenarios;
              });

            Field<ListGraphType<RewardType>>(
              "Rewards",
              resolve: context =>
              {
                  var rewards = db.Rewards;//.Include(a => a.Books);
                  return rewards;
              });

            Field<ListGraphType<SpecialType>>(
              "Specials",
              resolve: context =>
              {
                  var specials = db.Specials;//.Include(a => a.Books);
                  return specials;
              });
        }
    }
}