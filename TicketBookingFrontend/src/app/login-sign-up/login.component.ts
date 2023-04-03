import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from '../services/authentication.service';

@Component({
    selector: 'app-login',
    templateUrl: './login-sign-up.component.html'
})
export class LoginComponent {
    myForm: FormGroup = this.fb.group({
        email: this.fb.control(''),
        password: this.fb.control('')
    });
    submitActionName: string = 'Log In';

    constructor(private fb: FormBuilder, private route: Router, private authenticationService: AuthenticationService) {}

    onSubmit(form: FormGroup) {
        this.authenticationService.loginUser(form.value).subscribe({ next: response => this.onLoginSuccess(response) });
    }

    onLoginSuccess(response: any) {
        this.route.navigate(['']);
    }
}
