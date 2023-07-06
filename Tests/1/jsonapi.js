import http from "k6/http";

export default function () {
  let url = 'http://localhost:26846/api/actors?include=roles.movie&page[size]=1&filter=has(roles,equals(movie.year,\'2000\'))';
  url = url.replace(/ /g, '%20');
  
  http.get(url);
}