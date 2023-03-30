import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  apiKey$ = new BehaviorSubject<string>("2");

  createUser(authenticateRequest: any):Observable<any>
   {
    //call api here
    return this.apiKey$;
  }
  loginUser(authenticateRequest: any):Observable<any>
  {
    //call api here and store response in api key
    return this.apiKey$;
  }

  isLoggedin():boolean{
    return this.apiKey$.getValue() != '';
  }
}
