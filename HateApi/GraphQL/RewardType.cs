using GraphQL.Types;
using HateApi.Models;

namespace HateApi.GraphQL
{
    public class RewardType : ObjectGraphType<Reward>
    {
        public RewardType()
        {
            Name = "Reward";

            Field(x => x.RewardId, type: typeof(IdGraphType)).Description("The ID of the Reward.");
            Field(x => x.Name).Description("The name of the Reward");
            Field(x => x.Description).Description("The description of the Reward");
            Field(x => x.HateReward).Description("The amount of Hate earned for this Reward");
            Field(x => x.ResourceReward).Description("The amount of Resources earned for this Reward");
            Field(x => x.RewardType).Description("The Type of this Reward");
            Field(x => x.UnitUpgrade, type: typeof(StringGraphType)).Description("The Unit Upgrade of this Reward");
        }
    }
}