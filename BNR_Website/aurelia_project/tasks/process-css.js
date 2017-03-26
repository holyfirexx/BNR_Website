import gulp from 'gulp';
import sourcemaps from 'gulp-sourcemaps';
import sass from 'gulp-sass';
import project from '../aurelia.json';
import {build} from 'aurelia-cli';

export default function processCSS() {
    return gulp.src(project.cssProcessor.source)
         .pipe(sourcemaps.init())
         .pipe(sass({
                 includePaths: [
                     './node_modules/foundation-sites/scss',
                     './node_modules/font-awesome/scss',
                     './node_modules/slick-carousel/slick'
                     //'./node_modules/motion-ui/src'
                 ]
             }
         ).on('error', sass.logError))
         .pipe(gulp.dest(project.cssProcessor.output))
         .pipe(build.bundle());
}
