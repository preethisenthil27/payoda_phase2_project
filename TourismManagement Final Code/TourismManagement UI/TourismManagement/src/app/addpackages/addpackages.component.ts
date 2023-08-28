import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PackageService } from '../services/addpackage.service';
import { HttpClient} from '@angular/common/http';
import { Router } from '@angular/router';
@Component({
  selector: 'app-addpackages',
  templateUrl: './addpackages.component.html',
  styleUrls: ['./addpackages.component.css'],
})
export class AddpackagesComponent implements OnInit {
   
  packageForm!: FormGroup;

  constructor(
    private fb: FormBuilder,
    private router:Router,
    private packageService: PackageService
  ) {}

  ngOnInit(): void {
    this.initForm();   
  }

  initForm(): void {
    this.packageForm = this.fb.group({
      packageName: ['', Validators.required],
      imageUrl: [null],
    packageDescription1: ['', Validators.required],
    packageDescription2: [''],
    packageDescription3: [''],
    regionId: ['', Validators.required],
    spotName: ['', Validators.required],
    packageDuration: ['', Validators.required],
    packagePrice: ['', [Validators.required, Validators.pattern(/^\d+$/)]],
    });
  }

 
  public onSubmit(): void {
    // if (this.packageForm.valid) {
    //   const formData = this.packageForm.value;
    //   // Send the full form data to the service
    //   this.savePackageDetails(formData);
    this.packageService.savePackage(this.packageForm.value).subscribe(response => {
        // alert('Package Added');
        this.router.navigate(['packages'])
      });
    //}
  }

//   savePackageDetails(formData: any): void {
//     this.packageService.savePackage(formData).subscribe(response => {
//       alert('Package Added');
//     });
//   }
}

//   onSubmit(): void {
//     if (this.packageForm.valid)
//      {
//       const formData = this.packageForm.value;
//  // Get the image control
//       const imageControl = this.packageForm.get('image');
//       if (imageControl) {// Check if the control exists
//         const imageValue = imageControl.value;
//         console.log(imageValue);
//         if (imageValue) { // Check if the value is not null or undefined
//         this.packageService .savePackageDetails().subscribe((imageUrl) => {
//             formData.image = imageUrl; 
//             this.savePackageDetails(formData);
//           });
//       } else {
//         // No image selected, directly save the package details
//         this.savePackageDetails(formData);
//       }
//     }
//   }
//   }

// onSubmit(): void {
//     if (this.packageForm.valid) {
//       // Prepare the form data (excluding the image) to be sent to the API
//       const formData = this.packageForm.value;

//       // Upload the image if it's selected
//       if (this.packageForm.get('image').value) {
//         const imageFile = this.packageForm.get('image').value;
//         this.packageService.uploadImage(imageFile).subscribe(imageUrl => {
//           formData.image = imageUrl; // Set the image URL in the form data
//           this.savePackageDetails(formData);
//         });
//       } else {
//         // No image selected, directly save the package details
//         this.savePackageDetails(formData);
//       }
//     }
//   }

//         onSubmit(): void {
//         if (this.packageForm.valid)
//          {
//             const formData = this.packageForm.value;
//          }
//         }


//   public savePackageDetails(formData: any): void {
//     this.packageService.savePackage(formData)
//     .subscribe((response) => 
//     {
//         alert(" Package Added ");
//     });
//   }
//}
