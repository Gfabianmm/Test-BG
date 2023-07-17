import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private apiUrl = 'https://localhost:7259/api/Movie';

  constructor(private http: HttpClient) { }

  fetchMovieData() {
    const headers = new HttpHeaders().set('Access-Control-Allow-Origin', '*');
    return this.http.get(this.apiUrl+'?IsSortAscending=true&Page=-1', { headers });
  }
}
