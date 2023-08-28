import { Component } from '@angular/core';
import { PackageService } from '../services/addpackage.service';
import { ActivatedRoute, Route } from '@angular/router';

@Component({
  selector: 'app-packagedetails',
  templateUrl: './packagedetails.component.html',
  styleUrls: ['./packagedetails.component.css']
})
export class PackagedetailsComponent {

  
  public package: any;  
  //getting the package name from all package details//
  public packagename:string = this.router.snapshot.params['packagename'];
  public packageid:string = this.router.snapshot.params['packageid'];

  constructor(private packageService: PackageService,private router:ActivatedRoute
    ) { }

  ngOnInit(): void {
    this.GetPackageByPackagename();
  }
  
  public GetPackageByPackagename(){
      this.packageService.getStudentById(this.packagename)
      .subscribe(result => this.package = result );
      
    
  }



}
