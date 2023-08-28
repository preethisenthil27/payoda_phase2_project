import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LogincompComponent } from './logincomp/logincomp.component';
import { AdmincompComponent } from './admincomp/admincomp.component';
import { UsercompComponent } from './usercomp/usercomp.component';
import { AdminnavbarComponent } from './adminnavbar/adminnavbar.component';
import { UsernavbarComponent } from './usernavbar/usernavbar.component';
import { HomeComponent } from './home/home.component';
import { AdminallpackagesComponent } from './adminallpackages/adminallpackages.component';
import { SearchbarComponent } from './searchbar/searchbar.component';
import { UserallpackagesComponent } from './userallpackages/userallpackages.component';
import { FooterComponent } from './footer/footer.component';
import { AdminuserpackagesComponent } from './adminuserpackages/adminuserpackages.component';
import { UsermypackagesComponent } from './usermypackages/usermypackages.component';
import { AddpackagesComponent } from './addpackages/addpackages.component';
import { PackagedetailsComponent } from './packagedetails/packagedetails.component';
import { PackageService } from 'src/app/services/addpackage.service';
import { FullayoutComponent } from './fullayout/fullayout.component';
import { MenulayoutComponent } from './menulayout/menulayout.component';
import { RegisterComponent } from './register/register.component';
import { SearchpackagenameComponent } from './searchpackagename/searchpackagename.component';
import { BookingformComponent } from './bookingform/bookingform.component';
import { AboutusComponent } from './aboutus/aboutus.component';

@NgModule({
  declarations: [
    AppComponent,
    LogincompComponent,
    AdmincompComponent,
    UsercompComponent,
    AdminnavbarComponent,
    UsernavbarComponent,
    HomeComponent,
    AdminallpackagesComponent,
    SearchbarComponent,
    UserallpackagesComponent,
    FooterComponent,
    AdminuserpackagesComponent,
    UsermypackagesComponent,
    AddpackagesComponent,
    PackagedetailsComponent,
    FullayoutComponent,
    MenulayoutComponent,
    RegisterComponent,
    SearchpackagenameComponent,
    BookingformComponent,
    AboutusComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [PackageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
