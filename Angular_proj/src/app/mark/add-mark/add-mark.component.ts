import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from "src/app/shared.service";
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-mark',
  templateUrl: './add-mark.component.html',
  styleUrls: ['./add-mark.component.css']
})
export class AddMarkComponent implements OnInit {
  @Input() mark:any;
  MarkId:string = "";
  StudentId:string = "";
  DepartmentId:string = "";
  FullName: string ="";
  DepartmentName: string ="";
  Marks: any ="";
  disabled = false;
  Student: any = []; 
  Department: any = [];
  activate: boolean = false;

  reactiveForm = new FormGroup({
    studentId: new FormControl(),
    departmentId: new FormControl(),
    Mark: new FormControl()
  })
  
  constructor(private service: SharedService, private fb: FormBuilder) { }

  ngOnInit(): void {
    this.dropdownrefresh();
    this.dropdowndepartment();
    this.MarkId = this.mark.MarkId;
    this.FullName = this.mark.FullName;
    this.DepartmentName = this.mark.DepartmentName;
    this.Marks = this.mark.Marks;
    
  }

  addMark(){
    debugger
    console.log(this.reactiveForm.value);
      this.service.addMark(this.reactiveForm.value).subscribe(res =>{
        alert(res.toString());
      }) 
  }

  get studentId(){
    return this.reactiveForm.get('studentId') as FormControl
  }
  get departmentId(){
    return this.reactiveForm.get('departmentId') as FormControl
  }
  get Mark(){
    return this.reactiveForm.get('Mark') as FormControl
  }

  dropdownrefresh(){
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
