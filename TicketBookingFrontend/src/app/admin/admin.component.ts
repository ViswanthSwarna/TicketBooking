import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { bus } from 'src/app/models/bus.model';
import { BusService } from 'src/app/services/bus.service';
import { city } from '../models/city.model';

declare var window:any;

@Component({
    selector: 'app-admin',
    templateUrl: './admin.component.html'
})
export class AdminComponent implements OnInit {
    busList!:Array<bus>;
    formModal:any;
    isAdd:boolean = false;
    updateId:number = 0;

    sourceCity:any = this.formBuilder.control('');
    destinationCity:any = this.formBuilder.control('');
    startDateTime:any = this.formBuilder.control(Date());
    endDateTime:any = this.formBuilder.control(Date());
    type:any = this.formBuilder.control('');

    busFormGroup:FormGroup =this.formBuilder.group({
        busName:this.formBuilder.control(''),
        sourceCity:this.sourceCity,
        destinationCity:this.destinationCity,
        startDateTime:this.startDateTime,
        endDateTime:this.endDateTime,
        type:this.type
    });

    constructor(private busService: BusService,private formBuilder:FormBuilder) {}

    ngOnInit(): void {
        this.getAllBusList();
        this.formModal = new window.bootstrap.Modal(
            document.getElementById('modal-my-id')
          );
    }

    getAllBusList(){
        this.busService.getAllBuses().subscribe({next:response=>this.onSuccess(response)});
    }

    onSuccess(response: any) {
        this.busList = response;
    }

    add(){
        this.isAdd = true;
        this.busFormGroup.setValue({
            busName:'',
            sourceCity:'',
            destinationCity:'',
            startDateTime:'',
            endDateTime:'',
            type:''
        })
        this.formModal.show();
    }

    save(){
        var requestBody =<bus>{
            busName:this.busFormGroup.value.busName,
            sourceCity:<city>{name:this.busFormGroup.value.sourceCity},
            destinationCity:<city>{name:this.busFormGroup.value.destinationCity},
            startDateTime:this.busFormGroup.value.startDateTime,
            endDateTime:this.busFormGroup.value.endDateTime,
            type:this.busFormGroup.value.type
        }
        if(this.isAdd){
            this.busService.addBus(requestBody).subscribe({next:response=>this.getAllBusList()});
        }else{
            requestBody.id = this.updateId;
            this.busService.updateBus(requestBody).subscribe({next:response=>this.getAllBusList()})
        }
        this.formModal.hide();
    }

    edit(id: number) {
        this.isAdd = false;
        this.busService.getBus(id).subscribe({next:response => this.setValue(response)}); 
        this.formModal.show();
        this.updateId = id;
    }

    setValue(response:any){
        this.busFormGroup.setValue({
            busName:response.busName,
            sourceCity:response.sourceCity.name,
            destinationCity:response.destinationCity.name,
            startDateTime:new Date(response.startDateTime).toISOString().substring(0, 16),
            endDateTime:new Date(response.endDateTime).toISOString().substring(0, 16),
            type:response.type
        }) 
    }
    delete(id: number) {
        this.busService.deleteBus(id).subscribe({next:response => this.getAllBusList()}); 
    }
}
