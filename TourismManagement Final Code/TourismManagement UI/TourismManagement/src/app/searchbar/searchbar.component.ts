import { Component, EventEmitter, Output } from '@angular/core';
import { PackageService } from '../services/addpackage.service';

@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.css']
})
export class SearchbarComponent {

  @Output()
  public onSearch = new EventEmitter<string>()
  
  public searchName :string = ''

  constructor(private packageService: PackageService
    ) { }

  ngOnInit(): void {
  }
  
  public SearchPackage(){
      this.onSearch.emit(this.searchName)
    
  }

}
