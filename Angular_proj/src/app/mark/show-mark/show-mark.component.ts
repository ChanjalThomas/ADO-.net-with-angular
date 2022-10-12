import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-show-mark',
  templateUrl: './show-mark.component.html',
  styleUrls: ['./show-mark.component.css']
})
export class ShowMarkComponent implements OnInit {

  markSection = new FormGroup({
    studentmark: new FormControl('')
  });

  markList: any = [];
  markSheet: any;
  activate: boolean = false;
  mark: any;
  marks: any;

  constructor(private sharedService: SharedService) { }

  ngOnInit(): void {
    this.refreshMarkList();
  }

  refreshMarkList(){
    this.sharedService.getMarkList().subscribe(data =>{
      this.markList = data;
    });
  }

  addClick(){
    this.mark = {
      FullName:"",
      DepartmentName:"",
      Mark:""
    }
    this.markSheet = "Add Mark";
    this.activate = true;
  }

  editClick(item: any){
    this.mark = item;
    this.activate = true;
    this.markSheet = "Update Mark";
  }

  deleteClick(item: any){
    if(confirm ('Are you sure')){
      this.sharedService.deleteMark(item.MarkId).subscribe(data => {
        alert(data.toString());
        this.refreshMarkList();
      })
    }
  }

  closeClick(){
    this.activate = false;
    this.refreshMarkList();
  }

}
