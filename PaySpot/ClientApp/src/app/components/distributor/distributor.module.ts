import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DistributorDashboardComponent } from './distributor-dashboard/distributor-dashboard.component';



@NgModule({
  declarations: [
    DistributorDashboardComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    DistributorDashboardComponent
  ]
})
export class DistributorModule { }
