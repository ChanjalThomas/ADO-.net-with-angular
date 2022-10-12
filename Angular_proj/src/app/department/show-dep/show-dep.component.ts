import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-dep',
  templateUrl: './show-dep.component.html',
  styleUrls: ['./show-dep.component.css']
})
export class ShowDepComponent implements OnInit {
  departmentList:any = [];
  modal:any;
  activateAddEditDepCom:boolean = false;
  department:any;

  constructor(private sharedService: SharedService) { }

  ngOnInit(): void {
    this.refreshDepartmentList();
  }

  refreshDepartmentList(){
    this.sharedService.getDepartmentList().subscribe(data =>{
      this.departmentList = data;
    });
  }

  AddDepartment(){
    this.department = {
      DepartmentId:0,
      DepartmentName:""
    }
    this.modal = "Add Department";
    this.activateAddEditDepCom = true;
  }

  EditDepartment(item: any){
    this.department = item;
    this.activateAddEditDepCom = true;
    this.modal = "Update Department";
  }

  deleteClick(item: any){
    if(confirm ('Are you sure')){
      this.sharedService.deleteDepartment(item.DepartmentId).subscribe(data => {
        alert(data.toString());
        this.refreshDepartmentList();
      })
    }
  }

  click(){
    this.activateAddEditDepCom = false;
    this.refreshDepartmentList();
  }
}
