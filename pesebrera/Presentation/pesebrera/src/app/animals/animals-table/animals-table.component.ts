import { Component, OnInit } from '@angular/core';
import { AnimalsServiceService, Animal, AnimalFamily } from '../animals-service.service';
import { stringify } from '@angular/core/src/render3/util';
import { Observable } from 'rxjs';
import { Response } from 'selenium-webdriver/http';

@Component({
  selector: 'app-animals-table',
  templateUrl: './animals-table.component.html',
  styleUrls: ['./animals-table.component.css'],
  providers: [ AnimalsServiceService]
})
export class AnimalsTableComponent implements OnInit {

  animals : Animal[]
  constructor(private animalService: AnimalsServiceService) { }

  ngOnInit() {
    this.loadAnimals();

  }

  loadAnimals(){
    return this.animalService.getAllAnimal()
    .subscribe(x => 
      this.animals = x
    );
  }

}
