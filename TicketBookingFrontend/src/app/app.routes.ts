import { CollectPassengerComponent } from './collect-passenger/collect-passenger.component';
import { HomeComponent } from './home/home.component';
import { AuthPageGuardService } from './services/auth-page-guard.service';
import { TicketBookingSuccessfulComponent } from './ticket-booking-successful/ticket-booking-successful.component';


export const appRoutes = [
    { path: 'auth', loadChildren: () => import('./login-sign-up/login-sign-up.module').then(m => m.LoginSignUpModule), canActivate:[AuthPageGuardService] },
    { path: 'admin', loadChildren: () => import('./admin/admin.module').then(m => m.AdminModule) },
    { path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },
    { path: 'collectdetails/:busId', component: CollectPassengerComponent },
    { path: 'bookingsuccessful', component: TicketBookingSuccessfulComponent }
];

