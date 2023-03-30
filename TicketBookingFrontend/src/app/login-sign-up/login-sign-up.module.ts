import { NgModule } from '@angular/core';
import { LoginComponent } from './login.component';
import { RouterModule } from '@angular/router';
import { loginSignUpAppRoutes } from './login-sign-up.routes';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { SignUpComponent } from './signup.component';



@NgModule({
  declarations: [LoginComponent,SignUpComponent],
  imports: [
    RouterModule.forChild(loginSignUpAppRoutes),
    CommonModule,
    ReactiveFormsModule
  ]})
export class LoginSignUpModule { }
