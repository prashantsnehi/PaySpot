import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-app-login',
  templateUrl: './app-login.component.html',
  styleUrls: ['./app-login.component.css']
})
export class AppLoginComponent implements OnInit {
  model: any = {};
  constructor(private route: Router) { }

  ngOnInit() {
  }

  login() {
    console.log(this.model);
    //this.route.navigateByUrl('dashboard');
    this.route.navigateByUrl('fetch-data');
  }
}
