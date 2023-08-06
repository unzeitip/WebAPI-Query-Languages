import http from 'k6/http';

export default function () {
  let query = `
query {
    directors(
        where: { and: [
            { firstName: { eq: "Steven" } },
            { lastName: { eq: "Spielberg" } }
        ] }
    ) {
        items {
            movies {
                id
                name
                year
                rank
            }
        }
    }
}`;

  const headers = {
    'Content-Type': 'application/json',
  };
  
  http.post('http://localhost:36976/api', JSON.stringify({ query: query }), { headers: headers });
}
