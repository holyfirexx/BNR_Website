import $ from 'jquery';
import foundation from 'foundation-sites';

export class App {
  constructor() {
    this.clanName = 'Brotherhood of the Nefariously Righteous!';
  }

  attached() {
      $(document).foundation();
  }
}
