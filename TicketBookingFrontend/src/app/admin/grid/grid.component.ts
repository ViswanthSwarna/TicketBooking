import { Component, EventEmitter, Input, OnDestroy, Output } from '@angular/core';
import { Subject } from 'rxjs';
import { bus } from 'src/app/models/bus.model';

@Component({
  selector: 'admin-grid',
  templateUrl: './grid.component.html'
})
export class GridComponent implements OnDestroy {

  @Input() busList:Array<bus> = [];
  @Output() delete = new EventEmitter<number>(); 
  @Output() edit = new EventEmitter<number>(); 

  deleteItem(id: any) {
    this.delete.emit(id);
  }

  editItem(id: any) {
    this.edit.emit(id);
  }

  ngOnDestroy(): void {
  }

}
