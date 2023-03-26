using JsonApi.Models;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Queries.Expressions;
using JsonApiDotNetCore.Resources;
using System.ComponentModel;

namespace JsonApi.Definitions
{
    public class MoviesGenreDefinition : JsonApiResourceDefinition<MoviesGenre, dynamic>
    {
        public MoviesGenreDefinition(IResourceGraph resourceGraph)
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
                (resource => resource.Genre , ListSortDirection.Ascending),
            });
        }
    }
}