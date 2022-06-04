import { Component, OnInit } from '@angular/core';
import { PlanesService } from 'src/app/services/planes.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-planes',
  templateUrl: './planes.component.html',
  styleUrls: ['./planes.component.scss']
})
export class PlanesComponent implements OnInit {

  public planes = [];
  public displayedColumns = ['id', 'name', 'profile'];
  constructor(
    private router: Router,
    private planesService: PlanesService,
  ) { }

  ngOnInit(): void {
    this.planesService.getPlanes().subscribe(
      (result) => {
        console.log(result);
        this.planes = result;
      },
      (error) => {
        console.error(error);
      }

    );
  }

  public goToPlaneProfile(id): void {
    this.router.navigate(['/plane', id]);
  }

}
