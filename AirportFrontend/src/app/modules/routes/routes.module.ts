import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RoutesRoutingModule } from './routes-routing.module';
import { RoutesComponent } from './routes/routes.component';
import { MaterialModule } from '../material/material.module';

@NgModule({
  declarations: [
    RoutesComponent,
  ],
  imports: [
    CommonModule,
    RoutesRoutingModule,
    MaterialModule,
    
  ]
})
export class RoutesModule { }
