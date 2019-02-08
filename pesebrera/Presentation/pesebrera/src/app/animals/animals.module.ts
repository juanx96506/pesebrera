import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { AnimalsTableComponent } from './animals-table/animals-table.component';

@NgModule({
  declarations: [AnimalsTableComponent],
  imports: [
    CommonModule,
    HttpClientModule
  ],
  exports: [
    AnimalsTableComponent
  ]
})

export class AnimalsModule {
  constructor() { }
}
