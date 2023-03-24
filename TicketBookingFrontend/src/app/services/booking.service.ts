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
    ticketBodyForGuest$ = new Subject<ticket>();
    isSaved$: Observable<any> = this.ticketBody$.pipe(
        switchMap(ticketBody => {
            return this.http.post(environment.domainUrl + 'api/TicketBooking/saveticket', ticketBody);
        })
    );
    isSavedForGuestUser$:Observable<any> = this.ticketBodyForGuest$.pipe(
        switchMap(ticketBody => {
            return this.http.post(environment.domainUrl + 'api/TicketBooking/saveticketforguest', ticketBody);
        })
    );

    constructor(private http: HttpClient) {}

    SaveTicket(ticketBody: ticket): Observable<any> {
        this.ticketBody$.next(ticketBody);
        return this.isSaved$;
    }

    SaveTicketForGuestUser(ticketBodyForGuest: ticket): Observable<any> {
        this.ticketBodyForGuest$.next(ticketBodyForGuest);
        return this.isSavedForGuestUser$;
    }
}
