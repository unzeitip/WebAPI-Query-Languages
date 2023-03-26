using JsonApi.Models;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Queries.Expressions;
using JsonApiDotNetCore.Resources;
using System.ComponentModel;

namespace JsonApi.Definitions
{
    public class DirectorsGenreDefinition : JsonApiResourceDefinition<DirectorsGenre, dynamic>
    {
        public DirectorsGenreDefinition(IResourceGraph resourceGraph)
            : base(resourceGraph)
        {
        }

        public override SortExpression OnApplySort(SortExpression? existingSort)
        {
            if (existingSort != null)
            {
                return existingSort;
            }

            return CreateSortExpressionFromLambda(new PropertySortOrder
            {
                (resource => resource.Genre, ListSortDirection.Ascending),
            });
        }
    }
}