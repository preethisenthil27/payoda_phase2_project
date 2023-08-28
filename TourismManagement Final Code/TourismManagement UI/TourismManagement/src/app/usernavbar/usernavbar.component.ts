import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { PackageService } from '../services/addpackage.service';

@Component({
  selector: 'app-usernavbar',
  templateUrl: './usernavbar.component.html',
  styleUrls: ['./usernavbar.component.css']
})
export class UsernavbarComponent {

  public userdeatil:any = localStorage.getItem('userdeatil')
  public cName:string=JSON.parse(this.userdeatil).cName;

  constructor(private router:Router, private fb: FormBuilder,private packageService: PackageService) { }
  
  ngOnInit(): void {  
    
  }
   logout():void
   {
    localStorage.clear();
    this.router.navigate(['login'])
   }

}
