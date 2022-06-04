import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TicketsService {

  public url ='https://localhost:44333/api/Ticket';
  constructor(
    public http :HttpClient,
  ) { }

  public getTickets(): Observable<any> {
    return this.http.get(`${this.url}`);
  }
}
