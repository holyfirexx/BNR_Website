import $ from 'jquery';
import foundation from 'foundation-sites';
import {Router} from 'aurelia-router';

export class App {
  constructor() {
    this.clanName = 'Brotherhood of the Nefariously Righteous!';
  }

  attached() {
      $(document).foundation();
  }
}
