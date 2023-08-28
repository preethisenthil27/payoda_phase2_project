import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import {map,catchError} from 'rxjs/operators'
@Injectable({
  providedIn: 'root',
})
export class PackageService {
  private apiUrl = 'https://localhost:7014/api/Package'; // Replace with your API URL
  private apiSearchUrl = 'https://localhost:7014/api/Search';
  private apibookingurl='https://localhost:7014/api/Booking';
  private loginbasepath='https://localhost:7014/api/Login/Logindetails';
  private regurl='https://localhost:7014/api/Login/Register';

  constructor(private http: HttpClient) {}

  uploadImage(imageFile: File): Observable<string> {
    const formData = new FormData();
    formData.append('image', imageFile);

    return this.http.post<string>(`${this.apiUrl}/upload-image`, formData);
  }
//Insert packages
  public savePackage(packageData: any): Observable<any> {
    console.log(packageData);
    return this.http.post(`${this.apiUrl}`, packageData);
  }

  //Get All Packages
  public getAllPackages():Observable<any>
  {
    return this.http.get(this.apiUrl );
  }
  public getAllBookings():Observable<any>
  {
    return this.http.get(`${this.apibookingurl}/(Allbooking)` );
  }

  //get by package name
  public getStudentById(packagename:string):Observable<any>
  {
    return this.http.get(`${this.apiUrl}/Packagename?packagename=${packagename}`);                       //.pipe(retry(0), catchError(this.handleError));
  }
//search
  public searchpackage(packagename:string):Observable<any>
  {
    return this.http.get(`${this.apiSearchUrl}?searchelement=${packagename}`);   
  }


  //booking table by name
  public getdetailsByName(customername:string):Observable<any>
  {
    
     return this.http.get(`https://localhost:7014/api/Booking/${customername}`);     
                
  }
//login 
  public logindetails(data:{phnnumber:number,password:string})
  {
    const url = `${this.loginbasepath}/?phnnumber=${data.phnnumber}&password=${data.password}`;
    return this.http.get(url).pipe(map((response:any)=>
    {
      return response
    }),catchError((err)=>{
      return throwError(err.error)
    })
    );
  }
  public register(redetatils: any): Observable<any> {
   
    return this.http.post(`${this.regurl}`, redetatils);
  }

public bookingform(bookingdata:any) :Observable<any>
 {
  return this.http.post(`${this.apibookingurl}`, bookingdata);
}

// public Delete(packageName:string, student:any)
// {
//   const url = `${this.basepath}/?rollno=${packageName}`;
//   return this.http.put(url , student);
// }
}
