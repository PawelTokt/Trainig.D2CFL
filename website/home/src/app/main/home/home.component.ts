import { Component } from '@angular/core';

import { environment } from '../../../environments/environment';

@Component({
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  masterDataUrl: string = environment.masterDataUrl;

  constructor() { }
}