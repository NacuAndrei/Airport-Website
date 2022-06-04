import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { PlanesService } from 'src/app/services/planes.service';

@Component({
  selector: 'app-plane',
  templateUrl: './plane.component.html',
  styleUrls: ['./plane.component.scss']
})
export class PlaneComponent implements OnInit {

  public subscription: Subscription;
  public id;
  public plane = {
    id: 'default id',
    name: 'default name',
  };
  constructor(
    private route: ActivatedRoute,
    private planesService: PlanesService,
  ) { }

  ngOnInit(): void {
    this.subscription = this.route.params.subscribe(params => {
      this.id = +params['id'];
      if (this.id) {
        this.getPlane();
      }
    });
  }

  public getPlane(): void {
    this.planesService.getPlaneById(this.id).subscribe(
      (result) => {
        console.log(result);
        this.plane = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

}
