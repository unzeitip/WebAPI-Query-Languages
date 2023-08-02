import http from "k6/http";

export default function () {
  let url = 'http://localhost:26846/api/actors?filter=has(roles,and(greaterThan(movie.rank,’9’),has(movie.moviesGenres,equals(genre,’Horror’)),has(movie.directors,has(directorsGenres,equals(genre,’Comedy’)))))';
  
  http.get(url);
}