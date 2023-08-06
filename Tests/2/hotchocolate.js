import http from 'k6/http';

export default function () {
  let query = `
  query {
    actors(
        where: { roles: { some:
            { movie: { year: { eq: 2000 } } }
         } },
        take: 10000
    ) {
        items {
        id
        firstName
        lastName
        gender
        roles {
            id
            roleName
            movie {
                id
                name
                year
                rank
          }
        }
      }
    }
  }`;

  const headers = {
    'Content-Type': 'application/json',
  };
  
  http.post('http://localhost:36976/api', JSON.stringify({ query: query }), { headers: headers });
}
