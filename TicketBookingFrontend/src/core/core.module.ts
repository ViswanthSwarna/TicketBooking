import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { TypeaheadDropdownComponent } from '../core/typeahead-dropdown/typeahead-dropdown.component';
import { InputWithLabelComponent } from '../core/input-with-label/input-with-label.component';
import { CommonModule } from '@angular/common';


@NgModule({
  declarations: [
    TypeaheadDropdownComponent,
    InputWithLabelComponent
    ],
  imports: [
    HttpClientModule,
    CommonModule,
    ReactiveFormsModule
  ],
  exports: [
    TypeaheadDropdownComponent,
    InputWithLabelComponent
  ]

})
export class CoreModule { }
