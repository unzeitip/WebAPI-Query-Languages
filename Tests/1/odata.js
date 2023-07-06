import http from "k6/http";

export default function () {
  let url = 'http://localhost:22900/api/Actors?$expand=Roles($expand=Movie)&$filter=Roles/any(r: r/Movie/Year eq 2000)&$top=1000&$orderBy=id';
  url = url.replace(/ /g, '%20');
  
  http.get(url);
}