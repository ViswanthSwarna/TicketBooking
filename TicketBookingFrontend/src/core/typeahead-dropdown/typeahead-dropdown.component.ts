import { Component, Input } from '@angular/core';
import { FormControl } from '@angular/forms';
import { BehaviorSubject, map, Observable, switchMap } from 'rxjs';
import { item } from 'src/app/models/item.model';
import { BusService } from 'src/app/services/bus.service';

@Component({
  selector: 'typeahead-dropdown',
  templateUrl: './typeahead-dropdown.component.html'
})
export class TypeaheadDropdownComponent {
  @Input() labelText = 'label';
  
  @Input() inputFormControl = new FormControl();

  dynamicId: string = 'Id' + Math.random();

  constructor(private busService: BusService) {}

  inputText$ = new BehaviorSubject<string>('');
  itemList$: Observable<string[]> = this.inputText$.pipe(
    switchMap((x) => {
      return this.busService.getAllBusStopLocations(x); //see if u can generalize this also with delegate or something
    }),
    map((items: item[]) => items.map((x) => x.name))
  );

  valueChanged() {
    this.inputText$.next(this.inputFormControl.value);
  }
}
