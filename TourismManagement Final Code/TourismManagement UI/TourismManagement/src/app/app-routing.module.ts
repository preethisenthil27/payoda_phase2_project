import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LogincompComponent } from './logincomp/logincomp.component';
import { AdmincompComponent } from './admincomp/admincomp.component';
import { PackagedetailsComponent } from './packagedetails/packagedetails.component';
import { FullayoutComponent } from './fullayout/fullayout.component';
import { RegisterComponent } from './register/register.component';
import { MenulayoutComponent } from './menulayout/menulayout.component';
import { UsercompComponent } from './usercomp/usercomp.component';
import { HomeComponent } from './home/home.component';
import { UsermypackagesComponent } from './usermypackages/usermypackages.component';
import { AddpackagesComponent } from './addpackages/addpackages.component';

const routes: Routes = [
 
  

  {path:'',
 redirectTo:'/login',
 pathMatch:'full'},
  {path :'',component:FullayoutComponent,
children:
[
  {path:'login',component:LogincompComponent},
  {path:'register',component:RegisterComponent}
]},

{path :'',component:MenulayoutComponent,
children:
[
  {path:'home',component:HomeComponent},
  {path:'mypackages',component:UsermypackagesComponent},
  {path:'userpackages',component:UsermypackagesComponent},
  {path:'aboutus',component:UsermypackagesComponent},
  {path:'packages',component:UsercompComponent},
  {path:'addpackages',component:AddpackagesComponent},
  {path:'usercom/:packagename/:packageid/detail',component:PackagedetailsComponent},
 
  {path:'admincomp',component:AdmincompComponent},
]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
