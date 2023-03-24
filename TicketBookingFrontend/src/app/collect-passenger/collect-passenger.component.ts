import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { regex } from '../constants/regex';
import { ticket } from '../models/ticket.model';
import { BookingService } from '../services/booking.service';

@Component({
    selector: 'app-collect-passenger',
    templateUrl: './collect-passenger.component.html'
})
export class CollectPassengerComponent {
    nameFormControl: any = this.fb.control('', [Validators.required]);
    emailFormControl: any = this.fb.control('', [Validators.required, Validators.email]);
    phoneNumberFormControl: any = this.fb.control('', [Validators.required, Validators.pattern(regex.phoneNumberRegex)]);
    myForm: FormGroup = this.fb.group({
        name: this.nameFormControl,
        email: this.emailFormControl,
        phone: this.phoneNumberFormControl
    });

    constructor(
        private fb: FormBuilder,
        private route: ActivatedRoute,
        private bookingService: BookingService,
        private router: Router,
        private toastService: ToastrService
    ) {}

    onSubmit(form: FormGroup) {
        let isGuestUser = true;
        if (isGuestUser) {
            let ticketBody = <ticket>{
                busId: this.route.snapshot.params['busId'],
                fare: 100,
                isPaymentDone: false,
                user: { fullName: form.value.name, email: form.value.email, phoneNumber: form.value.phone, isLoggedIn: false, isAdmin: false, password: '' }
            };
            this.bookingService.SaveTicketForGuestUser(ticketBody).subscribe({ next: response => this.onTicketSaved(response) });
        } else {
            let ticketBody = <ticket>{
                busId: this.route.snapshot.params['busId'],
                userId: 1,
                fare: 100,
                isPaymentDone: false
            };
            this.bookingService.SaveTicket(ticketBody).subscribe({ next: response => this.onTicketSaved(response) });
        }
    }

    onTicketSaved(response: any) {
        this.toastService.info('Ticket Booked Successfully');
        this.router.navigate(['/bookingsuccessful']);
    }
}
