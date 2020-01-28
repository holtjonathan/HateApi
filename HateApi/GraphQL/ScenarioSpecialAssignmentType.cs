using GraphQL.Types;
using HateApi.Models;

namespace HateApi.GraphQL
{
    public class ScenarioSpecialAssignmentType : ObjectGraphType<ScenarioSpecialAssignment>
    {
        public ScenarioSpecialAssignmentType()
        {
            Name = "ScenarioSpecialAssignment";

            Field(x => x.ScenarioSpecialAssignmentId, type: typeof(IdGraphType)).Description("The ID of the ScenarioSpecial.");
            Field(x => x.SpecialId).Description("The special that this scenarioreward gets");
            Field(x => x.ScenarioId).Description("The scenario that this scenarioreward gets");
            Field(x => x.Special, type: typeof(SpecialType)).Description("The special");
            Field(x => x.Scenario, type: typeof(ScenarioType)).Description("The scenario");
        }
    }
}