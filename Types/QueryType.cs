﻿using HotChocolate.Types;
using Posts.API.Query;
using System;

namespace Posts.API.Types
{
    public class QueryType : ObjectType<PostsQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<PostsQuery> descriptor)
        {
            descriptor.Field(p => p.GetPosts())
                .Name("posts");

            descriptor.Field(p => p.GetUserPosts(default(Guid)))
                .Name("user_posts");

            descriptor.Field(p => p.GetPostById(default(Guid)))
                .Name("get_post_by_id");
        }
    }
}
