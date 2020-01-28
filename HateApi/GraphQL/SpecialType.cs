using GraphQL.Types;
using HateApi.Models;

namespace HateApi.GraphQL
{
    public class SpecialType : ObjectGraphType<Special>
    {
        public SpecialType()
        {
            Name = "Special";

            Field(x => x.SpecialId, type: typeof(IdGraphType)).Description("The ID of the Special.");
            Field(x => x.Name).Description("The name of the Special");
            Field(x => x.Description).Description("The description of the Special");
        }
    }
}