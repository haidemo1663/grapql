import {gql} from 'apollo-server'
export const typeDefs = gql`
#This "Book" type defines the queryable fields for every book in our data source.
#The "Query" type is special: it lists all of the available queries that
# clients can execute, along with the return type for each.
type Query {
posts : [Post],
post(id : ID!): Post,
categories : [Category],
category(id: ID!) : Category
DeletePost(id : ID!) : [Post]
}
type Post {
id : String,
name : String,
url : String,
category: String
}
type Category{
id : String
name : String,
posts : [Post]
}
input PostDTO {
    Name: String,
    Url: String,
    Category : String
}
type Mutation{
    CreatePost(input: PostDTO) : [Post]
    UpdatePost(id: ID!, input: PostDTO): [Post]
}

`;