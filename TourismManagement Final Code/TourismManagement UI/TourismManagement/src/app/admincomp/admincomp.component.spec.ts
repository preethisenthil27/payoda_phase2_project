import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdmincompComponent } from './admincomp.component';

describe('AdmincompComponent', () => {
  let component: AdmincompComponent;
  let fixture: ComponentFixture<AdmincompComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdmincompComponent]
    });
    fixture = TestBed.createComponent(AdmincompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
