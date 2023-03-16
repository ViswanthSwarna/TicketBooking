import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../environment/environment';

@Injectable({
  providedIn: 'root'
})
export class BusService {

  constructor(private http:HttpClient) { }

  getAllBusStopLocations(pattern:string):Observable<any>
  {
    if(pattern == ""){
      return of([]);
    }
    return this.http.get(environment.apiUrl +pattern);
  }

  searchForAvailableVehicle(searchBody:any):Observable<any>
  {
    let busModel: any;
    busModel.busName = "Temp"
    return of([busModel]);
  }
}
