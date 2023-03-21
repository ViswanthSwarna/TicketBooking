import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable, of, switchMap } from 'rxjs';
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
            return this.http.post(environment.apiUrl, searchBody);
        })
    );

    constructor(private http: HttpClient) {}

    getAllBusStopLocations(pattern: string): Observable<any> {
        if (pattern == '') {
            return of([]);
        }
        return this.http.get(environment.locationListApiUrl + pattern);
    }

    searchForAvailableVehicle(searchBody: any): Observable<any> {
        this.searchBody$.next(searchBody);
        return this.busList$;
    }
}
