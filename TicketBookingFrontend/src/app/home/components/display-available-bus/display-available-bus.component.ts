import { Component, Input } from '@angular/core';
import { bus } from 'src/app/models/bus.model';

@Component({
    selector: 'app-display-available-bus',
    templateUrl: './display-available-bus.component.html'
})
export class DisplayAvailableBusComponent {
    @Input()
    busList: Array<bus> = [];

    isEmpty() {
        let isEmpty = Object.keys(this.busList).length === 0;
        return isEmpty;
    }
}
