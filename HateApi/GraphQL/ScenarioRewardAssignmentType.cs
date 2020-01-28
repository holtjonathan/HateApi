using GraphQL.Types;
using HateApi.Models;

namespace HateApi.GraphQL
{
    public class ScenarioRewardAssignmentType : ObjectGraphType<ScenarioRewardAssignment>
    {
        public ScenarioRewardAssignmentType()
        {
            Name = "ScenarioRewardAssignment";

            Field(x => x.ScenarioRewardAssignmentId, type: typeof(IdGraphType)).Description("The ID of the ScenarioReward.");
            Field(x => x.RewardId).Description("The reward that this scenarioreward gets");
            Field(x => x.ScenarioId).Description("The scenario that this scenarioreward gets");
            Field(x => x.Reward, type: typeof(RewardType)).Description("The reward");
            Field(x => x.Scenario, type: typeof(ScenarioType)).Description("The scenario");
        }
    }
}