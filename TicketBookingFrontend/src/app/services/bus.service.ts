import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, of } from 'rxjs';
import { BusModel } from '../models/bus.model';
import { HttpClient } from '@angular/common/http';

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
    return this.http.get('https://localhost:7069/'+pattern);
  }

  searchForAvailableVehicle(searchBody:any):Observable<any>
  {
    let busModel = new BusModel()
    busModel.busName = "Temp"
    return of([busModel]);
  }
}
