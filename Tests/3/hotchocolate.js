import http from 'k6/http';

export default function () {
  let query = `
  query {
    actors(where: {
      roles: {
        some: {
          movie: {
            and: [
              { rank: { gt: 9 } },
              { moviesGenres: { some: { genre: { eq: "Horror" } } } },
              { directors: { some: { directorsGenres: { some: { genre: { eq: "Comedy" } } } } }
            ]
          }
        }
      }
    }) {
      items {
        id
        firstName
        lastName
        gender
      }
    }
  }`;

  const headers = {
    'Content-Type': 'application/json',
  };
  
  http.post('http://localhost:36976/api', JSON.stringify({ query: query }), { headers: headers });
}
