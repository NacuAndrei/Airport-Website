import { Component, OnDestroy, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup } from '@angular/forms';
import { Route, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent implements OnInit, OnDestroy {

  public subscription: Subscription;
  public loggedUser;
  Msg = "";
  Msg1 = "";
  public reviewForm : FormGroup = new FormGroup( {
    review: new FormControl(''),

  });
  public raffleForm :FormGroup = new FormGroup({
    email: new FormControl(''),
  });

  constructor(
    private router: Router,
    private dataService: DataService,
  ) { }

  get review (): AbstractControl {
    return this.reviewForm.get('review') as FormGroup;
  }

  get raffle (): AbstractControl {
    return this.raffleForm.get('raffle') as FormGroup;
  }

  ngOnInit(): void {
    this.subscription = this.dataService.currentUser.subscribe(user => this.loggedUser = user);
  }

  ngOnDestroy(): void {
      this.subscription.unsubscribe();
  }

  public logout(): void {
    localStorage.setItem('Role', 'Anonim');
    this.router.navigate(['/login']);
  }

  public fctreview(): void {
    this.Msg = "Review-ul tau a fost inregistrat.Multumim!"
  }
  public fcttombola(): void{
    this.Msg1 = "Participarea ta a fost inregistrata!"
  }
}
