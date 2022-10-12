import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from "src/app/shared.service";

@Component({
  selector: 'app-add-edit-mark',
  templateUrl: './add-edit-mark.component.html',
  styleUrls: ['./add-edit-mark.component.css']
})
export class AddEditMarkComponent implements OnInit {
  @Input() mark:any;
  MarkId:string = "";
  FullName: string ="";
  DepartmentName: string ="";
  Mark: string ="";
  disabled = false;
  Student: any;
  Department: any;

  constructor(private service: SharedService) { }

  ngOnInit(): void {
    this.MarkId = this.mark.MarkId;
    this.FullName = this.mark.FullName;
    this.DepartmentName = this.mark.DepartmentName;
    this.Mark = this.mark.Mark;
  }

/*  addMark(){
    debugger
    var val = {
      MarkId: this.MarkId,
      FullName: this.FullName,
      DepartmentName: this.DepartmentName,
      Mark:this.Mark};
      this.service.addMark(val).subscribe(res =>{
        alert(res.toString());
      }) 
  }
*/
  updateMark(){
    var val = {
      MarkId: this.MarkId,
      FullName:this.FullName,
      DepartmentName: this.DepartmentName,
      Mark:this.Mark};
      this.service.updateMark(val).subscribe(res =>{
        alert(res.toString());
    })
  }

}
