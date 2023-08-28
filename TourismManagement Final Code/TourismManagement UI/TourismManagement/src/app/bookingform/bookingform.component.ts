import { Component, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PackageService } from '../services/addpackage.service';
import { Route, Router } from '@angular/router';
@Component({
  selector: 'app-bookingform',
  templateUrl: './bookingform.component.html',
  styleUrls: ['./bookingform.component.css']
})
export class BookingformComponent {
  @Input()
  public packages: any;

  public userdeatil:any = localStorage.getItem('userdeatil')
  bookingform!: FormGroup;

  constructor(
    private fb: FormBuilder,
    private packageService: PackageService,
    private router:Router
  ) {}

  ngOnInit(): void {
    this.initForm();   
  }

  initForm(): void {
    
    this.bookingform = this.fb.group({
      bookingName: ['', Validators.required],
      bookingDate: [''],
      noOfPersons:[''],
      bookingPrice:[''],
      packageId:[this.packages.packageId],
      cId:[JSON.parse(this.userdeatil).cId]
    });
  }
  public onSubmit():void
  {

    this.bookingform.get('bookingPrice')?.setValue(this.packages.packagePrice * this.bookingform.value.noOfPersons)
    
    this.packageService.bookingform(this.bookingform.value).subscribe(response => {
      
      this.router.navigate(['mypackages'])
    }
    
    );
  }
}
