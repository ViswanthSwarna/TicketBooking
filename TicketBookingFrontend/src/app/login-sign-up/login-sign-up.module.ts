import { NgModule } from '@angular/core';
import { LoginSignUPComponent } from './login-sign-up.component';
import { RouterModule } from '@angular/router';
import { loginSignUpAppRoutes } from './login-sign-up.routes';



@NgModule({
  declarations: [LoginSignUPComponent],
  imports: [
    RouterModule.forChild(loginSignUpAppRoutes)
  ],
  providers: [],
  bootstrap: [LoginSignUPComponent]
})
export class LoginSignUpModule { }
