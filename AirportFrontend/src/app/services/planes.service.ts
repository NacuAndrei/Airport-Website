import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PlanesService {

  public url ='https://localhost:44333/api/Plane';
  constructor(
    public http :HttpClient,
  ) { }

  public getPlanes(): Observable<any> {
    return this.http.get( `${this.url}` );
  }

  public getPlaneById(id): Observable<any> {
    return this.http.get( `${this.url}/byId/${id}` );
  }
}
