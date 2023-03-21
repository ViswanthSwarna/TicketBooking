import { Component } from '@angular/core';
import { bus } from '../models/bus.model';
import { BusService } from '../services/bus.service';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    busList: Array<bus> = [];

    constructor(private busService: BusService) {}

    onSearch(eventData: any) {
        this.busService.searchForAvailableVehicle(eventData).subscribe({ next: response => this.onSearchSuccess(response) });
    }
    onSearchSuccess(response: any): void {
        this.busList = response;
    }
}
