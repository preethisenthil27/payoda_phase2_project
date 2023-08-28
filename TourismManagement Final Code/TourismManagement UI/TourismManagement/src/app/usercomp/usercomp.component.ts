import { Component } from '@angular/core';
import { PackageService } from '../services/addpackage.service';

@Component({
  selector: 'app-usercomp',
  templateUrl: './usercomp.component.html',
  styleUrls: ['./usercomp.component.css']
})
export class UsercompComponent {

 public packages :any;
  constructor(private service: PackageService) { }


  public onSearchPackage(formValue:any){
    this.service.searchpackage(formValue).subscribe(result => {
      this.packages  = result;
    }); 
  }

}
