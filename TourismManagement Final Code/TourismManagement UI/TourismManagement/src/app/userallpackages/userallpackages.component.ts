import { Component, Input } from '@angular/core';
import { PackageService } from '../services/addpackage.service';

@Component({
  selector: 'app-userallpackages',
  templateUrl: './userallpackages.component.html',
  styleUrls: ['./userallpackages.component.css']
})
export class UserallpackagesComponent {
  public errorMessage: string = '';
  @Input()
  public packages: any;
  public role:string| null = localStorage.getItem('role');

  constructor(private service: PackageService) { }

  ngOnInit(): void {
    if(!this.packages){
      this.getPackages();
    }
  }

  public getPackages(): void 
  {
    this.service.getAllPackages().subscribe(result => {
      this.packages = result;
      this.errorMessage = '';
       console.log(this.packages);

    }
   
    );
  }

//   public delete(){
//     var res= this.service.delete(this.packageName)
//     .subscribe(result => this.packages = result );
    
//     return res;
  
// }



}
