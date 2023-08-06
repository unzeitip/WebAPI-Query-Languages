import http from "k6/http";

export default function () {
  let url = "http://localhost:22900/api/actors?&$filter=Roles/any(r:r/Movie/Rank gt 9 and r/Movie/MoviesGenres/any(g:g/Genre eq 'Horror')and r/Movie/Directors/any(d:d/DirectorsGenres/any(g:g/Genre eq 'Comedy')))";
  url = url.replace(/ /g, '%20');
  
  http.get(url);
}