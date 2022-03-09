import { CreatePost, UpdatePost } from "../post.js"
export const Mutation ={
       CreatePost : async (_,{input},context)=>{
        return await CreatePost(input);
    },
       UpdatePost : async (_,{id, input})=>{
        return await UpdatePost(id,input);
    }
}
