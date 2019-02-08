import { TestBed } from '@angular/core/testing';

import { AnimalsServiceService } from './animals-service.service';

describe('AnimalsServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AnimalsServiceService = TestBed.get(AnimalsServiceService);
    expect(service).toBeTruthy();
  });
});
