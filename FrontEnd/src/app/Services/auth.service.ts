import { Injectable } from '@angular/core';
import {User} from '../user.model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private readonly USER_KEY = 'user';

  constructor() { }

  isLoggedIn(): boolean {
    return !!this.getUser();
  }

  login(user: User): void {
    localStorage.setItem(this.USER_KEY, JSON.stringify(user));
  }

  logout(): void {
    localStorage.removeItem(this.USER_KEY);
  }

  getUser(): User | null {
    const userString = localStorage.getItem(this.USER_KEY);
    return userString ? JSON.parse(userString) : null;
  }
}
