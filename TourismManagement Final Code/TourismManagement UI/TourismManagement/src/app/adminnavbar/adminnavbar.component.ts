import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-adminnavbar',
  templateUrl: './adminnavbar.component.html',
  styleUrls: ['./adminnavbar.component.css']
})
export class AdminnavbarComponent {
  public userdeatil:any = localStorage.getItem('userdeatil')
  public cName:string=JSON.parse(this.userdeatil).cName;

  constructor(private router:Router) { }
  
  ngOnInit(): void {  
    
  }
   logout():void
   {
    localStorage.clear();
    this.router.navigate(['login'])
   }
}
