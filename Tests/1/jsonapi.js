import http from "k6/http";

export default function () {
    let url = 'http://localhost:26846/api/actors?include=roles.movie&filter=has(roles,equals(movie.year,\'2000\'))&page[size]=1000';
  url = url.replace(/ /g, '%20');
  
  http.get(url);
}