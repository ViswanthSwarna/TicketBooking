import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminComponent } from './admin.component';
import { RouterModule } from '@angular/router';
import { adminAppRoutes } from './admin.routes';
import { GridComponent } from 'src/app/admin/grid/grid.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CoreModule } from 'src/core/core.module';



@NgModule({
  declarations: [
    AdminComponent,
    GridComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(adminAppRoutes),
    ReactiveFormsModule,
    CoreModule
  ]
})
export class AdminModule { }
