import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TicketsRoutingModule } from './tickets-routing.module';
import { TicketsComponent } from './tickets/tickets.component';
import { MaterialModule } from '../material/material.module';
import { HoverTextDirective } from 'src/app/hover-text.directive';

@NgModule({
  declarations: [
    TicketsComponent,
    HoverTextDirective,
  ],
  imports: [
    CommonModule,
    TicketsRoutingModule,
    MaterialModule,
  ],
  exports: [
    HoverTextDirective,
  ]
})
export class TicketsModule { }
