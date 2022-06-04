import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatIconModule} from '@angular/material/icon'; 
import { PlanesRoutingModule } from './planes-routing.module';
import { PlanesComponent } from './planes/planes.component';
import { MaterialModule } from '../material/material.module';
import { MarksPipe } from 'src/app/marks.pipe';
import { PlaneComponent } from './plane/plane.component';


@NgModule({
  declarations: [
    PlanesComponent,
    MarksPipe,
    PlaneComponent,
  ],
  imports: [
    CommonModule,
    PlanesRoutingModule,
    MaterialModule,
    MatIconModule,
  ],
  exports: [
    MarksPipe,
  ]
})
export class PlanesModule { }
