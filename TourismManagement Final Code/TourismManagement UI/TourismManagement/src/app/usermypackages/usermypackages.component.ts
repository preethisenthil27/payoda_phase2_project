import { Component } from '@angular/core';
import { PackageService } from '../services/addpackage.service';

@Component({
  selector: 'app-usermypackages',
  templateUrl: './usermypackages.component.html',
  styleUrls: ['./usermypackages.component.css']
})
export class UsermypackagesComponent {
  public userdeatil:any = localStorage.getItem('userdeatil')
  public role:any = localStorage.getItem('role')
  public cName:string=JSON.parse(this.userdeatil).cName;
  public package: any;  
  //getting the package name from all package details//
  //public packagename:string = this.router.snapshot.params['packagename'];
  customername!:string;
  constructor(private packageService: PackageService,
    ) { }

    ngOnInit(): void {  
      this .GetPackageByname();
    }
      
      
  public GetPackageByname(){
    if(this.role ==='admin'){
     this.packageService.getAllBookings()
      .subscribe(result => this.package = result );  
    }
    else{
      this.packageService.getdetailsByName(this.cName)
      .subscribe(result => this.package = result );
    }
      

     
      

     
  

      
   
  }


}
