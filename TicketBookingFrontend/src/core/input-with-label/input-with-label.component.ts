import { Component, Input } from '@angular/core';

@Component({
    selector: 'app-input-with-label',
    templateUrl: './input-with-label.component.html',
    styleUrls: ['./input-with-label.component.css']
})
export class InputWithLabelComponent {
    @Input() labelText: any;
    @Input() inputFieldFormControl:any;
}
