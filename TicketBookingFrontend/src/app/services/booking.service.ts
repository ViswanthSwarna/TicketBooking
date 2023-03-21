import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject, switchMap } from 'rxjs';
import { environment } from '../environment/environment';
import { ticket } from '../models/ticket.model';

@Injectable({
    providedIn: 'root'
})
export class BookingService {
    ticketBody$ = new Subject<ticket>();
    isSaved$: Observable<any> = this.ticketBody$.pipe(
        switchMap(ticketBody => {
            return this.http.post(environment.apiUrl + 'saveticket', ticketBody);
        })
    );

    constructor(private http: HttpClient) {}

    SaveTicket(ticketBody: ticket): Observable<any> {
        this.ticketBody$.next(ticketBody);
        return this.isSaved$;
    }
}
