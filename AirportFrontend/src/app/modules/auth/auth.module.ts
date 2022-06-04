import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './login/login.component';
import { MaterialModule } from '../material/material.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HoverBtnDirective } from 'src/app/hover-btn.directive';


@NgModule({
  declarations: [
    LoginComponent,
    HoverBtnDirective,
  ],
  imports: [
    CommonModule,
    AuthRoutingModule,
    MaterialModule,
    ReactiveFormsModule,
  ],
  exports: [
    HoverBtnDirective,
  ]
})
export class AuthModule { }
