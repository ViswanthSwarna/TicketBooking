import { CollectPassengerComponent } from './collect-passenger/collect-passenger.component';
import { HomeComponent } from './home/home.component';
import { LoginSignUPComponent } from './login-sign-up/login-sign-up.component';
import { TicketBookingSuccessfulComponent } from './ticket-booking-successful/ticket-booking-successful.component';

export const appRoutes = [
    { path: 'login/:isLogin', component: LoginSignUPComponent },
    { path: 'signup/:isLogin', component: LoginSignUPComponent },
    { path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },
    { path: 'collectdetails/:busId', component: CollectPassengerComponent },
    { path: 'bookingsuccessful', component: TicketBookingSuccessfulComponent }
];
