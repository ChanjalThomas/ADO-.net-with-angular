import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentComponent } from './student/student.component';
import { ShowStuComponent } from './student/show-stu/show-stu.component';
import { AddEditStuComponent } from './student/add-edit-stu/add-edit-stu.component';

import { HttpClientModule } from "@angular/common/http";
import { SharedService } from "./shared.service";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { DepartmentComponent } from './department/department.component';
import { ShowDepComponent } from './department/show-dep/show-dep.component';
import { AddEditDepComponent } from './department/add-edit-dep/add-edit-dep.component';

import { MarkComponent } from './mark/mark.component';
import { AddEditMarkComponent } from './mark/add-edit-mark/add-edit-mark.component';
import { ShowMarkComponent } from './mark/show-mark/show-mark.component';
import { AddMarkComponent } from './mark/add-mark/add-mark.component';
import { DetailsComponent } from './details/details.component';
import { ShowDetailsComponent } from './details/show-details/show-details.component';
import { AddDetailsComponent } from './details/add-details/add-details.component';
import { EditDetailsComponent } from './details/edit-details/edit-details.component';


@NgModule({
  declarations: [
    AppComponent,
    StudentComponent,
    ShowStuComponent,
    AddEditStuComponent,
    DepartmentComponent,
    ShowDepComponent,
    AddEditDepComponent,
    MarkComponent,
    AddEditMarkComponent,
    ShowMarkComponent,
    AddMarkComponent,
    DetailsComponent,
    ShowDetailsComponent,
    AddDetailsComponent,
    EditDetailsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
