import $ from 'jquery';
import foundation from 'foundation-sites';

export class App {
  constructor() {
    this.message = 'Hello World!';
  }

  attached() {
      $(document).foundation();
  }
}
