export const Category = {
    posts : async ({id}, args ,{posts}) =>{
        var result = await posts();
      return result.filter(p=>p.category === id)
    }
}