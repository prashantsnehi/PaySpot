import { Container } from '@angular/compiler/src/i18n/i18n_ast';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})

export class LogInComponent implements OnInit {

  showMenu: boolean;
  constructor(private route: Router) { }
  ngOnInit() {

  }

  SignInButton = () => {
    var elem = document.getElementById('container');
    elem.classList.remove('right-panel-active');
  }

  SignUpButton = () => {
    var elem = document.getElementById('container');
    elem.classList.add('right-panel-active');
  }

  Login = () => {
    alert('Welcome to Payspot');
    this.showMenu = false;
    this.route.navigateByUrl('fetch-data');
    
  }
}
