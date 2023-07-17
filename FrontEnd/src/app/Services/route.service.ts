import { Injectable } from '@angular/core';
@Injectable({
  providedIn: 'root'
})
export class RouteService {

  urlBase = 'https://localhost:7259/';
  user = 'api/User';
  movie = 'api/movie';
  GetUserUri(): string {
    return this.urlBase + this.user;
  }

  GetMovieUri(): string {
    return this.urlBase + this.movie;
  }
}
