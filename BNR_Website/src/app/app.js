import $ from 'jquery';
import foundation from 'foundation-sites';
import {Router} from 'aurelia-router';
import {inject, bindable, computedFrom} from 'aurelia-framework';

@inject(Router)
export class App {
    constructor(router) {
        this.router = router;
        this.clanName = 'Brotherhood of the Nefariously Righteous';
  }

  attached() {
      $(document).foundation();
  }
}
