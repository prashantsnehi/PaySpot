import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppLoginComponent } from './app-login/app-login.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CounterComponent } from './counter/counter.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppLoginComponent,
    HomeComponent,
    FetchDataComponent,
    CounterComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports: [
    AppLoginComponent,
    HomeComponent,
    FetchDataComponent,
    CounterComponent
  ]
})
export class ComponentsModule { }
