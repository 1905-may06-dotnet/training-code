import { TestBed } from '@angular/core/testing';

import { CardsApiService } from './cards-api.service';

describe('CardsApiService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CardsApiService = TestBed.get(CardsApiService);
    expect(service).toBeTruthy();
  });
});
