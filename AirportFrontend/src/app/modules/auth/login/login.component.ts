import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  public loginForm: FormGroup = new FormGroup( {
    username: new FormControl(''),
    password: new FormControl(''),
  })

  constructor(
    private router: Router,
    private dataService: DataService,
  ) { }


  get username(): AbstractControl {
    return this.loginForm.get('username') as FormGroup;
  }
  get password(): AbstractControl {
    return this.loginForm.get('pasword') as FormGroup;
  }
  ngOnInit(): void {
  }

  public login(): void {
    console.log(this.loginForm.value);
    this.dataService.changeUserData(this.loginForm.value);
    localStorage.setItem('Role', 'Admin');
    this.router.navigate( ['/users']);
  }

}
