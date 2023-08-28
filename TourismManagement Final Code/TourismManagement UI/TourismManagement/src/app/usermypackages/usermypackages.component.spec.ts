import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsermypackagesComponent } from './usermypackages.component';

describe('UsermypackagesComponent', () => {
  let component: UsermypackagesComponent;
  let fixture: ComponentFixture<UsermypackagesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UsermypackagesComponent]
    });
    fixture = TestBed.createComponent(UsermypackagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
