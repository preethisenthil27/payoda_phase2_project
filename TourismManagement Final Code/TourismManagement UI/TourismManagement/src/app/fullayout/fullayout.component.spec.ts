import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FullayoutComponent } from './fullayout.component';

describe('FullayoutComponent', () => {
  let component: FullayoutComponent;
  let fixture: ComponentFixture<FullayoutComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FullayoutComponent]
    });
    fixture = TestBed.createComponent(FullayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
