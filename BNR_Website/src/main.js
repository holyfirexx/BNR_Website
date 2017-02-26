import {Config} from 'aurelia-config';
import {Router} from 'aurelia-router';

import environment from './environment';
//config
import routerConfig from 'config/router';

//Configure Bluebird Promises.
Promise.config({
  warnings: {
    wForgottenReturn: false
  }
});

function configureRouter(config) {
    config.title = "BNR Clan Page";
    config.map(routerConfig.routes);
    config.fallbackRoute(routerConfig.fallbackRoute);
}

function setRoot(aurelia) {
    if (aurelia.setupAureliaDone) {
        aurelia.container.get(Router).configure(configureRouter);
        aurelia.setRoot('app');
    }
}

export function configure(aurelia) {
  aurelia.use
    .standardConfiguration()
    .feature('components')
    .feature('resources');

  if (environment.debug) {
    aurelia.use.developmentLogging();
  }

  if (environment.testing) {
    aurelia.use.plugin('aurelia-testing');
  }

  aurelia.start().then(() => {
      aurelia.setupAureliaDone = true;
      setRoot(aurelia);
  });
}
