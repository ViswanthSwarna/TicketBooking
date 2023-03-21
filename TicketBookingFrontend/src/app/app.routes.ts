import { CollectPassengerComponent } from './collect-passenger/collect-passenger.component';
import { HomeComponent } from './home/home.component';
import { TicketBookingSuccessfulComponent } from './ticket-booking-successful/ticket-booking-successful.component';


export const appRoutes = [
    { path: 'loginsignup/:isLogin', loadChildren: () => import('./login-sign-up/login-sign-up.module').then(m => m.LoginSignUpModule) },
    { path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },
    { path: 'collectdetails/:busId', component: CollectPassengerComponent },
    { path: 'bookingsuccessful', component: TicketBookingSuccessfulComponent }
];

