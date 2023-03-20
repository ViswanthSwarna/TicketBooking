import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';

@Component({
    selector: 'app-bus-search',
    templateUrl: './bus-search.component.html'
})
export class BusSearchComponent {
    source: FormControl = this.fb.control('');
    destination: FormControl = this.fb.control('');
    startDate: FormControl = this.fb.control('');
    myForm: FormGroup = this.fb.group({
        sourceCity: this.source,
        destinationCity: this.destination,
        startDate: this.startDate
    });

    @Output() searchFormGroup = new EventEmitter<FormGroup>();

    constructor(private fb: FormBuilder) {}

    onSubmit(form: FormGroup) {
        this.searchFormGroup.emit(form.value);
    }
}
