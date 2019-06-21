import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CardsComponent } from './cards.component';
import { CardsApiService } from '../cards-api.service';

describe('CardsComponent', () => {
  let component: CardsComponent;
  let fixture: ComponentFixture<CardsComponent>;
  let spyService = jasmine.createSpyObj('CardsApiService', ['createDeck', 'drawDeck', 'shuffleDeck',]);

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [CardsComponent],
      providers: [
        { provide: CardsApiService, useValue: spyService }
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CardsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
