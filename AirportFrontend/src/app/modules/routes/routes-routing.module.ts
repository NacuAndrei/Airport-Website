import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RoutesComponent } from './routes/routes.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'routes',
  },
  {
    path: 'routes',
    component: RoutesComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RoutesRoutingModule { }
