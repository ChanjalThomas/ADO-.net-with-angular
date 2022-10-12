import { Injectable } from '@angular/core';
import { HttpClient  } from '@angular/common/http';
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUrl = "http://localhost:5000/api";

  constructor(private http: HttpClient) { }
  getStudentList(): Observable < any[] > {
    return this.http.get < any > (this.APIUrl + '/Student');
  }
  addStudent(val: any){
    return this.http.post(this.APIUrl + '/Student', val);
  }
  updateStudent(val: any){
    return this.http.put(this.APIUrl + '/Student', val);
  }
  deleteStudent(id: any){
    return this.http.delete(this.APIUrl + '/Student/' + id);
  }
  getDepartmentList(): Observable < any[] > {
    return this.http.get < any > (this.APIUrl + '/Student/Getdata');
  }
  addDepartment(val: any){
    return this.http.post(this.APIUrl + '/Student/Create', val);
  }
  updateDepartment(val: any){
    return this.http.put(this.APIUrl + '/Student/Update', val);
  }
  deleteDepartment(id: any) {
    return this.http.delete(this.APIUrl + '/Student/DeleteDep?id='+ id);
  }

  getMarkList(): Observable < any[]> {
    return this.http.get < any > (this.APIUrl + '/Mark/GetMark');
  }
  addMark(val: any){
    debugger
    return this.http.post(this.APIUrl + '/Mark/CreateMark', val);
  }
  updateMark(val: any){
    return this.http.put(this.APIUrl + '/Mark/UpdateMark', val);
  }
  deleteMark(id: any) {
    return this.http.delete(this.APIUrl + '/Mark/DeleteMark?id=' + id);
  }
  

  detailsList(): Observable < any[]> {
    return this.http.get < any > (this.APIUrl + '/Detail/GetDetails');
  }
  addDeatils(val: any){
    debugger
    return this.http.post(this.APIUrl + '/Detail/CreateDetails', val);
  }
  updateDetails(val: any){
    return this.http.put(this.APIUrl + '/Detail/UpdateDetails', val);
  }
  deleteDetails(id: any) {
    return this.http.delete(this.APIUrl + '/Detail/DeleteDetails?id=' + id);
  }
}
