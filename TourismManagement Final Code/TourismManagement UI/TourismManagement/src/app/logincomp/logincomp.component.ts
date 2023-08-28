import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PackageService } from '../services/addpackage.service';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-logincomp',
  templateUrl: './logincomp.component.html',
  styleUrls: ['./logincomp.component.css'],
})
export class LogincompComponent {
  loginform!:FormGroup;
  phnnumber!:number;
  password!:string;
  public details: any;
  constructor(private router:Router, private fb: FormBuilder,private packageService: PackageService) { }
 
  ngOnInit(): void {
    this.initForm();   
  }

  initForm(): void {
    this.loginform=this.fb.group({
      phnnumber: ['', Validators.required],
      password: [''],
    })
  }


  public onSubmit(): void {

    if(this.loginform.value.phnnumber === '8270014102' && this.loginform.value.password === 'admin'){
      localStorage.setItem('role','admin');
      localStorage.setItem('userdeatil',JSON.stringify({cName:'admin'}))
      this.router.navigate(['packages'])
    }
    else{
      this.packageService.logindetails(this.loginform.value).subscribe(response => {
        localStorage.setItem('userdeatil',JSON.stringify(response))
          localStorage.setItem('role','user')
        
       
        this.router.navigate(['home'])
      },
      (err)=>{
        alert(JSON.stringify(err));
      }
     );
    }
    
    
    }
}
