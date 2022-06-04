import { Component, OnInit } from '@angular/core';
import { TicketsService } from 'src/app/services/tickets.service';

@Component({
  selector: 'app-tickets',
  templateUrl: './tickets.component.html',
  styleUrls: ['./tickets.component.scss']
})
export class TicketsComponent implements OnInit {

  public tickets = [];
  public displayedColumns = ['id', 'price', 'dateOfPurchase'];
  constructor(
    private ticketsService: TicketsService,
  ) { }

  ngOnInit(): void {
    this.ticketsService.getTickets().subscribe(
      (result) => {
        console.log(result);
        this.tickets = result;
      },
      (error) => {
        console.error(error);
      }

    );
  }

}
