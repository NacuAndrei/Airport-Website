import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './auth.guard';

const routes: Routes = [
  {
    path: '',
    canActivate: [AuthGuard],
    children: [
      {
        path:'',
        loadChildren: () => import('src/app/modules/users/users.module').then(m => m.UsersModule),
      },
    ]
  },
  {
    path:'',
    loadChildren: () => import('src/app/modules/users/users.module').then(m => m.UsersModule),
  },
  {
    path:'',
    loadChildren: () => import('src/app/modules/planes/planes.module').then(m => m.PlanesModule),
  },
  {
    path:'',
    loadChildren: () => import('src/app/modules/routes/routes.module').then(m => m.RoutesModule),
  },
  {
    path:'',
    loadChildren: () => import('src/app/modules/tickets/tickets.module').then(m => m.TicketsModule),
  },
  {
    path:'login',
    loadChildren: () => import('src/app/modules/auth/auth.module').then(m => m.AuthModule),
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
