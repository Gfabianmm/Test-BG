import { Component } from '@angular/core';
import {User} from './user.model';
import {UserRegister} from './userRegister.model';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AuthService } from './Services/auth.service';
import { HttpClient ,HttpHeaders} from '@angular/common/http';
import {RouteService} from './Services/route.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(private modalService: NgbModal, public authService: AuthService,private http: HttpClient, private routeService: RouteService) {}

  title = 'Test Bango Guayaquil - Gerardo Machuca Morán';
  user?: User;
  userRegister : UserRegister= {
    mail:'',
    names:' ',
    password:''

  };
  ngOnInit() {
    this.fetchMovieData();
  }
  movieData: any[] = [];
  genres: any[] = [];
  showModal = false;
  openModal(content: any) {
    this.modalService.open(content);
  }

  openModalRegistrar(content: any,modal: any) {
    modal.close();
    this.modalService.open(content);


  }

  OnRegister(modal: any) {
    this.authService.RegisterUser(this.userRegister);
     modal.close();
  }
  OnLogIn(modal: any) {
    this.authService.login(this.userRegister)
      .then((user: User | null) => {
        if (user) {
          this.user = user;
          console.log(user);
          modal.close();
        } else {
          alert('El usuario no existe');
        }
      })
      .catch((error: any) => {
        alert('Ocurrió un error al verificar el usuario: ' + error);
      });
  }


  onLogout() {
    // Cerrar sesión
    this.authService.logout();
    this.user = undefined;
  }

  fetchMovieData() {

    const url = this.routeService.GetMovieUri()+'?IsSortAscending=true&Page=-1';
    const headers = new HttpHeaders().set('Access-Control-Allow-Origin', '*');
    this.http.get(url,{ headers }).subscribe((response: any) => {

      this.movieData = response.items;

      this.genres = this.getUniqueGenres();
// console.log(this.movieData);
// console.log(this.genres );
    });
  }

  getUniqueGenres(): any[] {
    const uniqueCategories :any[] = [];

    this.movieData.forEach((movie) => {
      movie.movieGenres.forEach((genre:any) => {
        const existingCategory = uniqueCategories.find((c) => c.id === genre.id);

        if (!existingCategory) {
          uniqueCategories.push(genre);
        }
      });
    });
// console.log('unique');
// console.log(uniqueCategories);

    return uniqueCategories;
  }

  filterMoviesByGenre(genreId: number): any[] {
    console.log('filter '+genreId);
    if (!genreId) {
      console.log('no');
      return this.movieData;
    }

    return this.movieData.filter((movie) =>
      movie.movieGenres.some((genre:any) => genre.id === genreId)

    );
  }
}
