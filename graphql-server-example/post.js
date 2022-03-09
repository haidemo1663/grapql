import axios from "axios";
const URL = "http://localhost:5000/api/post";
export const GetAllPost = async ()=>{
  return (await axios.get(URL)).data;
}
export const GetPostById = async (id)=>{
  return (await axios.get(URL +`/${id}`)).data
}
export const CreatePost = async (post)=>{
  return (await axios.post(URL,post)).data
}
export const UpdatePost = async(id,post) =>{
  return (await axios.post(URL+`/${id}`,post)).data
}
export const DeletePost = async (id) => {
  return (await axios.delete(URL+`/${id}`,)).data
}