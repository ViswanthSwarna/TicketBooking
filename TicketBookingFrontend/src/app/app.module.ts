import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { BusSearchComponent } from './home/components/bus-search/bus-search.component';
import { HttpClientModule } from '@angular/common/http';
import { DisplayAvailableBusComponent } from './home/components/display-available-bus/display-available-bus.component';
import { HomeComponent } from './home/home.component';
import { CollectPassengerComponent } from './collect-passenger/collect-passenger.component';
import { TicketBookingSuccessfulComponent } from './ticket-booking-successful/ticket-booking-successful.component';
import { appRoutes } from './app.routes';
import { ToastrModule } from 'ngx-toastr';
import { CoreModule } from 'src/core/core.module';


@NgModule({
  declarations: [
    AppComponent,
    BusSearchComponent,
    DisplayAvailableBusComponent,
    HomeComponent,
    CollectPassengerComponent,
    TicketBookingSuccessfulComponent
    ],
  imports: [
    HttpClientModule,
    BrowserModule,
    ReactiveFormsModule,
    RouterModule.forRoot(appRoutes),
    ToastrModule.forRoot(),
    CoreModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
