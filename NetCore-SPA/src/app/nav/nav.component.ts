import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
model: any = {};
  constructor(private authservice: AuthService) { }

  ngOnInit() {
  }

  login() {

     this.authservice.login(this.model).subscribe(x => {
       console.log('Login good');
     }, error => {
       console.log('Login failed');
     });
  }

  loggedIn() {

    const token = localStorage.getItem('token');
    return !!token;
  }

  logout() {
    localStorage.removeItem('token');

  }

}
