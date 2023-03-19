import { TestBed } from '@angular/core/testing';

import { PartiesDataService } from './parties-data.service';

describe('PartiesDataService', () => {
  let service: PartiesDataService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PartiesDataService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
