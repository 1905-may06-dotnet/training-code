import { TestBed, async, inject } from '@angular/core/testing';

import { SillyGuard } from './silly.guard';

describe('SillyGuard', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SillyGuard]
    });
  });

  it('should ...', inject([SillyGuard], (guard: SillyGuard) => {
    expect(guard).toBeTruthy();
  }));
});
