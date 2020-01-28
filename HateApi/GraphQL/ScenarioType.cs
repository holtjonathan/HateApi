using GraphQL.Types;
using HateApi.Models;

namespace HateApi.GraphQL
{
    public class ScenarioType : ObjectGraphType<Scenario>
    {
        public ScenarioType()
        {
            Name = "Scenario";           

            Field(x => x.ScenarioId, type: typeof(IdGraphType)).Description("The ID of the Scenario.");
            Field(x => x.Name).Description("The name of the Scenario");
            Field(x => x.Description).Description("The description of the Scenario");
        }
    }
}