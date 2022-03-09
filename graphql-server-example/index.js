import { ApolloServer } from 'apollo-server';
import {Query} from './Resolver/Query.js'
import {Category} from './Resolver/Category.js'
import {posts, categories} from './db.js'
import { typeDefs } from './schema.js';
import { Mutation } from './Mutations/mutation.js';
const server = new ApolloServer(
  { typeDefs,
    resolvers :{
      Query,
      Category,
      Mutation,
    },
    context : {
      posts,
      categories
    }
   });

// The `listen` method launches a web server.
server.listen().then(({ url }) => {
  console.log(`🚀  Server ready at ${url}`);
});
  