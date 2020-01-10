using HotChocolate.Types;
using Posts.API.Models;

namespace Posts.API.Types
{
    public class PostInputType : InputObjectType<Post>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Post> descriptor)
        {
            descriptor.Field(p => p.Id)
                .Type<StringType>();

            descriptor.Field(p => p.UserId)
                .Type<StringType>();

            descriptor.Field(p => p.Title)
                .Type<StringType>();

            descriptor.Field(p => p.Description)
                .Type<StringType>();

            descriptor.Field(p => p.Status)
                .Type<StringType>();
        }
    }
}
