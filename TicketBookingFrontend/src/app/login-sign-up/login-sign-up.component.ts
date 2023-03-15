import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { AuthenticationResponseModel } from '../models/authenticationResponse.model';
import { AuthenticationService } from '../services/authentication.service';

@Component({
  selector: 'app-login-sign-up',
  templateUrl: './login-sign-up.component.html',
  styleUrls: ['./login-sign-up.component.css'],
})
export class LoginSignUPComponent{

}