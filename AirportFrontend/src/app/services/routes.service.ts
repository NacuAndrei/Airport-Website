import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RoutesService {

  public url = 'https://localhost:44333/api/Route';
  constructor(
    public http: HttpClient,
  ) { }

  public getRoutes(): Observable<any> {
    return this.http.get( `${this.url}` );
  }
}
