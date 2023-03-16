import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { BusSearchComponent } from './bus-search/bus-search.component';
import { LoginSignUPComponent } from './login-sign-up/login-sign-up.component';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    BusSearchComponent,
    LoginSignUPComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    ReactiveFormsModule,
    RouterModule.forRoot(
      [
        {path:'login/:isLogin',component:LoginSignUPComponent},
        {path:'signup/:isLogin',component:LoginSignUPComponent},
        {path:'',component:BusSearchComponent}
      ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
