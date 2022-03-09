import { gql, useQuery } from '@apollo/client';

const GET_Post = gql`
query{
  posts {
    id,
    name,
    url,
    category
  }
}
`;
export default function Post(){
    const { loading, error, data } = useQuery(GET_Post)
      if (loading) return null;
      if (error) return `Error! ${error}`;

      return (
        data.posts.map(p => 
            <img key={p.id} src={p.url} style={{ height: 100, width: 100 }} />
        )
      );
}
