import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AnimalsTableComponent } from './animals-table.component';

describe('AnimalsTableComponent', () => {
  let component: AnimalsTableComponent;
  let fixture: ComponentFixture<AnimalsTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AnimalsTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AnimalsTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
