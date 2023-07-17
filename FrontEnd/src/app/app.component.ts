import { Component } from '@angular/core';
import {User} from './user.model';
import {UserRegister} from './userRegister.model';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AuthService } from './Services/auth.service';
import { HttpClient ,HttpHeaders} from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(private modalService: NgbModal, public authService: AuthService,private http: HttpClient) {}

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

    this.user = {
      id:1, // Asigna un ID adecuado según tu lógica de generación de ID
      // displayName:this.userRegister.names,
      name: this.userRegister.names,
      mail: this.userRegister.mail,
      interests:[]
      // Agrega más propiedades según sea necesario
    };
    this.authService.login(this.user);
    modal.close('Registro exitoso');
    // console.log(userRegister.)
  }

  OnLogIn(modal: any) {

    this.user = {
      id:1,
      name: 'Gerardo F. Mahcuca Morán',
      mail: this.userRegister.mail,
      interests:[]
    };
    this.authService.login(this.user);
    modal.close();
  }
  onLogout() {
    // Cerrar sesión
    this.authService.logout();
    this.user = undefined;
  }

  fetchMovieData() {
    const url = 'https://localhost:7259/api/Movie?IsSortAscending=true&Page=-1';
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
