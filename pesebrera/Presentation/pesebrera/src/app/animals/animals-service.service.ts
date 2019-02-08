import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

export interface Animal {
  name: string;
  family: AnimalFamily;
}

export interface AnimalFamily {
  name?: string;
}

@Injectable({
  providedIn: 'root'
})
export class AnimalsServiceService {
  animalUrl = 'http://localhost:49879/api/Animal';

  constructor(private http: HttpClient) { }
  getAllAnimal() {
    return this.http.get<Animal[]>(this.animalUrl);
  }
}
