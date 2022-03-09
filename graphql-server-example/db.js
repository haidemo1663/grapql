import {GetAllPost} from './post.js'
export const posts = async () => await GetAllPost();
export const categories =()=>[
    {
      "id" : "1",
      "name" : "For All",
    },
    {
      "id": "2",
      "name" : "For Men"
    }
  ]