import './App.css';
import PostHeader from './Component/HeaderComponet';
import Post from './Component/PostComponet';
import React, {useState} from 'react';

function App() {
  const [idCategory, setIDCategory]= useState("1");
  const SetIdCategory =(id)=>{
    setIDCategory(id);
    console.log(id);
}
  return (
    <div className="App">
      <h2>My first Apollo app 🚀</h2>
      <PostHeader changeID ={SetIdCategory}/>
      <Post/>
    </div>
  );
}

export default App;
