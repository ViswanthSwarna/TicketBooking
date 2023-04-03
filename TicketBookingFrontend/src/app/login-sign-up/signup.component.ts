import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import {  Router } from '@angular/router';
import { AuthenticationService } from '../services/authentication.service';

@Component({
    selector: 'app-login',
    templateUrl: './login-sign-up.component.html'
})
export class SignUpComponent {
    myForm: FormGroup = this.fb.group({
        email: this.fb.control(''),
        password: this.fb.control('')
    });
    submitActionName: string = 'Sign Up';

    constructor(private fb: FormBuilder, private route: Router, private authenticationService: AuthenticationService) {}

    onSubmit(form: FormGroup) {
        this.authenticationService.createUser(form.value).subscribe({ next: response => this.onUserCreated(response) });
    }

    onUserCreated(res: any) {
        this.route.navigate(['auth/login']);
    }
}
