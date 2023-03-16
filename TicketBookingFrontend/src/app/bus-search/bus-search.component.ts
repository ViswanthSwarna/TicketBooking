import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { SearchRequest } from '../models/searchRequest.model';
import { BusService } from '../services/bus.service';

@Component({
  selector: 'app-bus-search',
  templateUrl: './bus-search.component.html',
  styleUrls: ['./bus-search.component.css']
})
export class BusSearchComponent implements OnInit{
  sourceLocationList:any = new Array<string>();
  destinationLocationList:any = new Array<string>();
  myForm!: FormGroup;

  constructor(private busService:BusService,private fb:FormBuilder) {
  }
  ngOnInit(): void {
    this.myForm = this.fb.group({
      source: this.fb.control(''),
      destination: this.fb.control(''),
      travelDate: this.fb.control('')
    });
  }

  sourceValueChanged()
  {
    if(typeof this.myForm.value.source !='undefined' && this.myForm.value.source){
    this.busService.getAllBusStopLocations(this.myForm.value.source).subscribe({next:response=>this.onSourceValueSuccess(response)});
    }
  }

  onSourceValueSuccess(response:any)
  {
    this.sourceLocationList = response;
  }

  destinationValueChanged()
  {
    if(typeof this.myForm.value.destination !='undefined' && this.myForm.value.destination)
    {
      this.busService.getAllBusStopLocations(this.myForm.value.destination).subscribe({next:response=>this.onDestinationValueSuccess(response)});
    }
  }

  onDestinationValueSuccess(response:any)
  {
    this.destinationLocationList = response;
  }

  onSubmit(form: FormGroup) 
  {
    let searchRequest = new SearchRequest();
    searchRequest.source = form.value.source
    searchRequest.destination = form.value.destination
    searchRequest.travelDate = form.value.travelDate
    this.busService.searchForAvailableVehicle(searchRequest).subscribe({next:response=>this.onSearchSuccess(response)})
  }

  onSearchSuccess(response:any)
  {
  }

}

