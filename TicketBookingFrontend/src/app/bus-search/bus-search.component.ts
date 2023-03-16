import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { SearchRequest } from '../models/searchRequest.model';
import { BusService } from '../services/bus.service';

@Component({
  selector: 'app-bus-search',
  templateUrl: './bus-search.component.html',
  styleUrls: ['./bus-search.component.css'],
})
export class BusSearchComponent {
  
  source: FormControl = this.fb.control('');
  destination: FormControl = this.fb.control('');
  travelDate: FormControl = this.fb.control('');
  myForm: FormGroup = this.fb.group({
    source: this.source,
    destination: this.destination,
    travelDate: this.travelDate,
  });

  constructor(private busService: BusService, private fb: FormBuilder) {}

  onSubmit(form: FormGroup) {
    let searchRequest = new SearchRequest();
    searchRequest.source = form.value.source
    searchRequest.destination = form.value.destination
    searchRequest.travelDate = form.value.travelDate
    this.busService.searchForAvailableVehicle(searchRequest).subscribe({next:response=>this.onSearchSuccess(response)})
  }

  onSearchSuccess(response: any) {}
}
