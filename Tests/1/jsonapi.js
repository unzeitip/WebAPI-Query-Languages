import http from "k6/http";

export default function () {
  let url = 'http://localhost:26846/api/directors?include=movies&filter=and(equals(firstName,’Steven’),equals(lastName,’Spielberg’))&fields[directors]=movies';
  
  http.get(url);
}