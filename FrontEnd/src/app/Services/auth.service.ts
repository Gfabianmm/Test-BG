import { Injectable } from '@angular/core';
import { User } from '../user.model';
import { UserRegister } from '../userRegister.model';
import { RouteService } from './route.service';

import { HttpClient, HttpParams } from '@angular/common/http';
import { retry } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private readonly USER_KEY = 'user';

  constructor(private http: HttpClient, private routeService: RouteService) { }

  isLoggedIn(): boolean {
    return !!this.getUser();
  }

  login(user: UserRegister): Promise<User | null> {
    const params = new HttpParams()
      .set('mail', user.mail)
      .set('password', user.password);

    return new Promise((resolve, reject) => {
      this.http.get(this.routeService.GetUserUri(), { params }).subscribe({
        next: (response: any) => {
          if (response.totalItems > 0) {
            const loggedUser = response.items[0];
            localStorage.setItem(this.USER_KEY, JSON.stringify(loggedUser));
            resolve(loggedUser);
          } else {
            reject('El usuario no existe');
          }
        },
        error: (error: any) => {
          reject('Ocurrió un error al verificar el usuario');
        }
      });
    });
  }


  logout(): void {
    localStorage.removeItem(this.USER_KEY);
  }

  getUser(): User | null {
    const userString = localStorage.getItem(this.USER_KEY);
    return userString ? JSON.parse(userString) : null;
  }

  RegisterUser(user: UserRegister) {

    this.http.post(this.routeService.GetUserUri(), user).subscribe({
      next: (response: any) => {
        alert('registro exitoso');
        this.login(response);
      },
      error: (error: any) => {
        alert('ocurrio algo inesperado');
        console.error(error);
      }
    });

  }
}
