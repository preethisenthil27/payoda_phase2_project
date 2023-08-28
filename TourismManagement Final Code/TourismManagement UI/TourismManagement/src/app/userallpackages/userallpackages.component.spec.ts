import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserallpackagesComponent } from './userallpackages.component';

describe('UserallpackagesComponent', () => {
  let component: UserallpackagesComponent;
  let fixture: ComponentFixture<UserallpackagesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UserallpackagesComponent]
    });
    fixture = TestBed.createComponent(UserallpackagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
