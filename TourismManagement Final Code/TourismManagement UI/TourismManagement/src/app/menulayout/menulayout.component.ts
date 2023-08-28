import { Component } from '@angular/core';

@Component({
  selector: 'app-menulayout',
  templateUrl: './menulayout.component.html',
  styleUrls: ['./menulayout.component.css']
})
export class MenulayoutComponent {
  public role:string| null = localStorage.getItem('role');
}
