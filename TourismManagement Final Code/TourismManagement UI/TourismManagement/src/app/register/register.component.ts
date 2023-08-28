import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PackageService } from '../services/addpackage.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
 
  userForm!: FormGroup;

  constructor(
    private router:Router,
    private fb: FormBuilder,
    private packageService: PackageService
  ) {}

  ngOnInit(): void {
    this.initForm();   
  }

  initForm(): void {
    this.userForm = this.fb.group({
      CName: ['', Validators.required],
      CEmail: ['', Validators.required],
      CPassword: [''],
    PhnNumber: ['', Validators.required],
     });  
  }

  public onSubmit(): void {
    this.packageService.register(this.userForm.value).subscribe(response => {
    
      this.router.navigate(['login'])
     
      });
    //}
  }


}
