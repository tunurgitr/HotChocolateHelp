using HotChocolate.Types;
using Posts.API.Models;

namespace Posts.API.Types
{
    public class PostType : ObjectType<Post>
    {
        protected override void Configure(IObjectTypeDescriptor<Post> descriptor)
        {
            base.Configure(descriptor);
        }
    }
}
