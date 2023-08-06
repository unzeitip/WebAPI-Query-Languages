import http from "k6/http";

export default function () {
  let url = "http://localhost:22900/api/directors?$expand=movies&$filter=firstname eq 'Steven' and lastname eq 'Spielberg'&$select=movies";
  url = url.replace(/ /g, '%20');
  
  http.get(url);
}