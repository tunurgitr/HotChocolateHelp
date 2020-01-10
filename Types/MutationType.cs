using HotChocolate.Types;
using Posts.API.Mutation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Posts.API.Types
{
    public class MutationType : ObjectType<PostsMutation>
    {
        protected override void Configure(IObjectTypeDescriptor<PostsMutation> descriptor)
        {
        }
    }
}
