import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-details',
  templateUrl: './show-details.component.html',
  styleUrls: ['./show-details.component.css']
})
export class ShowDetailsComponent implements OnInit {

  detailList:any = [];
  modal:any;
  activate:boolean = false;
  detail:any;
  constructor(private sharedService: SharedService) { }

  ngOnInit(): void {
  }

 addClick(){
    this.detail = {
      FullName:"",
      Address:"",
      DepartmentName:"",
      Gender:""
    }
    this.modal = "Add StudentDetails";
    this.activate = true;
  }
  closeClick(){
    this.activate = false;
    /*this.refreshMarkList(); */
  }

}
