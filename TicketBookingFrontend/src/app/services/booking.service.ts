import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject, switchMap } from 'rxjs';
import { environment } from '../environment/environment';
import { ticketRequestBody } from '../models/ticket.model';

@Injectable({
    providedIn: 'root'
})
export class BookingService {
    ticketBody$ = new Subject<ticketRequestBody>();
    isSaved$: Observable<any> = this.ticketBody$.pipe(
        switchMap(ticketBody => {
            return this.http.post(environment.apiUrl2 + 'saveticket', ticketBody);
        })
    );

    constructor(private http: HttpClient) {}

    SaveTicket(ticketBody: ticketRequestBody): Observable<any> {
        this.ticketBody$.next(ticketBody);
        return this.isSaved$;
    }
}
