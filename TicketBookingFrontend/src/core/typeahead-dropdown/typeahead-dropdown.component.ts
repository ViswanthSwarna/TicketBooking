import { Component, Input } from '@angular/core';
import { FormControl } from '@angular/forms';
import { BehaviorSubject, map, Observable, switchMap } from 'rxjs';
import { BusService } from 'src/app/services/bus.service';

@Component({
  selector: 'typeahead-dropdown',
  templateUrl: './typeahead-dropdown.component.html',
  providers: [BusService]
})
export class TypeaheadDropdownComponent {
  @Input() labelText = 'label';
  
  @Input() inputFormControl = new FormControl();

  dynamicId: string = 'Id' + Math.random();

  constructor(private busService: BusService) {}

  inputText$ = new BehaviorSubject<string>("");
  itemList$: Observable<any> = this.inputText$.pipe(
    switchMap((x) => {
      return this.busService.getAllBusStopLocations(x);
    })
  );

  valueChanged() {
    this.inputText$.next(this.inputFormControl.value);
  }
}
