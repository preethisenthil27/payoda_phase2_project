import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddpackagesComponent } from './addpackages.component';

describe('AddpackagesComponent', () => {
  let component: AddpackagesComponent;
  let fixture: ComponentFixture<AddpackagesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddpackagesComponent]
    });
    fixture = TestBed.createComponent(AddpackagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
