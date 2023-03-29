import { Component, Input } from '@angular/core';

@Component({
    selector: 'app-input-with-label',
    templateUrl: './input-with-label.component.html'
})
export class InputWithLabelComponent {
    @Input() labelText: any;
    @Input() inputFieldFormControl:any;
}
