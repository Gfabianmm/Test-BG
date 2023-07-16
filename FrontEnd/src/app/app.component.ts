import { Component } from '@angular/core';
import {User} from './user.model';
import {UserRegister} from './userRegister.model';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AuthService } from './Services/auth.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(private modalService: NgbModal, public authService: AuthService) {}

  title = 'Test Bango Guayaquil - Gerardo Machuca Morán';
  user?: User;
  userRegister : UserRegister= {
    mail:'',
    names:' ',
    password:''

  };

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
      name: 'fabiam',
      mail: this.userRegister.mail,
      interests:[]
    };
    this.authService.login(this.user);
    modal.close('Registro exitoso');
    // console.log(userRegister.)
  }
  onLogout() {
    // Cerrar sesión
    this.authService.logout();
    this.user = undefined;
  }
}
