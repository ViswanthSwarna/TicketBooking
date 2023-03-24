import { Injectable } from '@angular/core';
import { BehaviorSubject, debounce, interval, map, Observable, of, Subject, switchMap } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../environment/environment';
import { bus } from '../models/bus.model';
import { searchRequest } from '../models/search-request.model';

@Injectable({
    providedIn: 'root'
})
export class BusService {
    searchBody$ = new BehaviorSubject<searchRequest>({ sourceCity: '', destinationCity: '', startDate: '' });
    busList$: Observable<any> = this.searchBody$.pipe(
        switchMap(searchBody => {
            return this.http.post(environment.domainUrl +'api/TicketBooking/', searchBody);
        })
    );

    pattern$ = new BehaviorSubject<string>("");
    locations$ : Observable<any> =  this.pattern$.pipe(
        switchMap(pattern => {
            return this.http.get(environment.domainUrl + pattern);
        })
    )


    constructor(private http: HttpClient) {}

    getAllBusStopLocations(pattern: string): Observable<any> {
        this.pattern$.next(pattern);
        return this.locations$;
    }

    searchForAvailableVehicle(searchBody: any): Observable<any> {
        this.searchBody$.next(searchBody);
        return this.busList$;
    }
}
