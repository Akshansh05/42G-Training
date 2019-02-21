import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {DashComponent} from './dash/dash.component';
import {EmployeeComponent} from './employee/employee.component';
import {AboutComponent } from './about/about.component';
import{ContactComponent} from './contact/contact.component';

  const routes: Routes = [
    {path:'employee', component:EmployeeComponent},
    {path:'dash', component:DashComponent},
    {path:'about',component:AboutComponent},
    {path:'contact',component:ContactComponent},
    {path:'', redirectTo:'#', pathMatch:'full'}
    ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
