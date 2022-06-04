import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PlaneComponent } from './plane/plane.component';
import { PlanesComponent } from './planes/planes.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'planes',
  },
  {
    path: 'planes',
    component: PlanesComponent
  },
  {
    path: 'plane/:id',
    component: PlaneComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PlanesRoutingModule { }
