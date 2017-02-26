export default {
routes: [
    {
        route: ['','/home'],
        name: 'home',
        moduleId: 'components/views/home/home',
        nav: true,
        title: 'Home',
        settings: {
            roles: []
        }
    }],
fallbackRoute: 'home'
};