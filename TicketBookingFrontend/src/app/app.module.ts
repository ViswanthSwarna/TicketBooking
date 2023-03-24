import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { BusSearchComponent } from './home/components/bus-search/bus-search.component';
import { HttpClientModule } from '@angular/common/http';
import { TypeaheadDropdownComponent } from '../core/typeahead-dropdown/typeahead-dropdown.component';
import { DisplayAvailableBusComponent } from './home/components/display-available-bus/display-available-bus.component';
import { HomeComponent } from './home/home.component';
import { CollectPassengerComponent } from './collect-passenger/collect-passenger.component';
import { InputWithLabelComponent } from '../core/input-with-label/input-with-label.component';
import { TicketBookingSuccessfulComponent } from './ticket-booking-successful/ticket-booking-successful.component';
import { appRoutes } from './app.routes';
import { ToastrModule } from 'ngx-toastr';


@NgModule({
  declarations: [
    AppComponent,
    BusSearchComponent,
    TypeaheadDropdownComponent,
    DisplayAvailableBusComponent,
    HomeComponent,
    CollectPassengerComponent,
    InputWithLabelComponent,
    TicketBookingSuccessfulComponent
    ],
  imports: [
    HttpClientModule,
    BrowserModule,
    ReactiveFormsModule,
    RouterModule.forRoot(appRoutes),
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
