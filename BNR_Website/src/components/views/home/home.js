import slick from "slick-carousel";
import $ from 'jquery';

export class Home {
  constructor() {
      this.slideIndex = 1;
      this.displayImage = [false,false,false,false]
  }
  attached() {
      $(".slideShow").slick({
          autoplay: true,
          autoplaySpeed: 3000,
          dots: true
      }); 
  }
}