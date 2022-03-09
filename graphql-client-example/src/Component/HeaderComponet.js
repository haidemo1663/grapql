import { gql, useQuery } from '@apollo/client';
import React,{useEffect, useState} from 'react';
const GET_CATEGORY = gql`
query {
  categories {
    id,
    name
  }
}
`;
export default function PostHeader({changeID}){
    const { loading, error, data } = useQuery(GET_CATEGORY)
      if (loading) return null;
      if (error) return `Error! ${error}`;
      return (
        <header>
            <div className='menu' style={{"display" :"flex","width":"100%", "margin-bottom":"8px"}}>
                {data.categories.map(p =>
                    <button key={p.id} className='menu-item' style={{"width" : "40%","height":"20px","padding":"4px"}} onClick ={changeID(p.id)}>
                        {p.name}
                    </button>
                    )}
            </div>
        </header>
      );
}