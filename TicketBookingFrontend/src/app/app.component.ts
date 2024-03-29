import { Component } from '@angular/core';
import { AuthenticationService } from './services/authentication.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html'
})
export class AppComponent {
    constructor(private authenticationService:AuthenticationService) {
    }
    isLoggedIn:boolean = this.authenticationService.isLoggedin();
}
