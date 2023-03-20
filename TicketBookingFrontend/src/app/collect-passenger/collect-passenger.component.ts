import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ticketRequestBody } from '../models/ticket.model';
import { BookingService } from '../services/booking.service';

@Component({
    selector: 'app-collect-passenger',
    templateUrl: './collect-passenger.component.html'
})
export class CollectPassengerComponent {
    nameFormControl: any = this.fb.control('', [Validators.required]);
    emailFormControl: any = this.fb.control('', [Validators.required, Validators.email]);
    phoneNumberFormControl: any = this.fb.control('', [Validators.required, Validators.pattern('^[0-9]{10}$')]);
    myForm: FormGroup = this.fb.group({
        name: this.nameFormControl,
        email: this.emailFormControl,
        phone: this.phoneNumberFormControl
    });

    constructor(private fb: FormBuilder, private route: ActivatedRoute, private bookingService: BookingService, private router: Router) {}

    onSubmit(form: FormGroup) {
        let ticketBody = <ticketRequestBody>{
            busId: this.route.snapshot.params['busId'],
            userId: 1,
            fare: 100,
            isPaymentDone: false,
            user: { fullName: form.value.name, email: form.value.email, phoneNumber: form.value.phone, isLoggedIn: false, isAdmin: false, password: '' }
        };
        this.bookingService.SaveTicket(ticketBody).subscribe({ next: response => this.onTicketSaved(response) });
    }

    onTicketSaved(response: any) {
        this.router.navigate(['/bookingsuccessful']);
    }
}
