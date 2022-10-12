import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from "src/app/shared.service";
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-details',
  templateUrl: './add-details.component.html',
  styleUrls: ['./add-details.component.css']
})
export class AddDetailsComponent implements OnInit {
  @Input() detail:any;
  StudentDetail: any ="";
  disabled = false;
  Student: any = []; 
  Department: any = [];
  activate: boolean = false;

  detailForm = new FormGroup({
    studentId: new FormControl(),
    address: new FormControl(),
    departmentId: new FormControl(),
    gender: new FormControl()
  })
  constructor(private service: SharedService, private fb: FormBuilder) { }

  ngOnInit(): void {
    this.dropdownstudent();
    this.dropdowndepartment();
  }

  addMark(){
    debugger
    console.log(this.detailForm.value);
      this.service.addMark(this.detailForm.value).subscribe(res =>{
        alert(res.toString());
      }) 
  }

  get studentId(){
    return this.detailForm.get('studentId') as FormControl
  }
  get address(){
    return this.detailForm.get('address') as FormControl
  }
  get departmentId(){
    return this.detailForm.get('departmentId') as FormControl
  }
  get gender(){
    return this.detailForm.get('gender') as FormControl
  }

  dropdownstudent(){
    this.service.getStudentList().subscribe(data =>{
      data.forEach(element => {
         this.Student.push(element);
      });
    })
  }

  dropdowndepartment(){
    this.service.getDepartmentList().subscribe(data =>{
      data.forEach(element => {
         this.Department.push(element);
      });
    })
  }
}
