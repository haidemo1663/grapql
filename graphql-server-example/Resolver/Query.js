import {GetAllPost,GetPostById,DeletePost} from '../post.js'
export const Query = {
    posts: async (_,args, {posts,categories}) =>{
      var result=  await posts();
      return result;
    },
    post : async (_,{id},{posts,categories})=>await GetPostById(id),

    DeletePost : async (_,{id}) => {
        return await DeletePost(id);
    },
    categories: (_,args, {categories}) => categories(),
    category : (_,{id},{categories}) =>{ 
     return categories().find(p=>p.id === id)
    }
}