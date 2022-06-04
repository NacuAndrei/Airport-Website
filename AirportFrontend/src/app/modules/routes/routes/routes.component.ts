import { Component, OnInit } from '@angular/core';
import { RoutesService } from 'src/app/services/routes.service';

@Component({
  selector: 'app-routes',
  templateUrl: './routes.component.html',
  styleUrls: ['./routes.component.scss']
})
export class RoutesComponent implements OnInit {

  public routes = [];
  public displayedColumns = ['id', 'name'];
  constructor(
    private routesService: RoutesService,
  ) { }

  ngOnInit(): void {
    this.routesService.getRoutes().subscribe(
      (result) => {
        console.log(result);
        this.routes = result;
      },
      (error) => {
        console.error(error);
      }

    );
  }

}
