export default {
routes: [
    {
        route: ['','/home'],
        name: 'home',
        moduleId: 'components/views/home/home',
        nav: true,
        title: 'BNR',
        settings: {
            roles: [],
            font: "fa fa-home"
        }
    },{
        route: '/server-info',
        name: 'server-info',
        moduleId: 'components/views/server-info/server-info',
        nav: true,
        title: 'Server Info & Rules',
        settings: {
            roles: [],
            font: "fa fa-laptop"
        }
    },
    {
        route: '/events',
        name: 'events',
        moduleId: 'components/views/events/events',
        nav: true,
        title: 'Events',
        settings: {
            roles: [],
            font: "fa fa-calendar"
        }
    },
    {
        route: '/leader-boards',
        name: 'leader-boards',
        moduleId: 'components/views/leader-boards/leader-boards',
        nav: true,
        title: 'Leader Boards',
        settings: {
            roles: [],
            font: "fa fa-list-ol"
        }
    },
    {
        route: '/about',
        name: 'about',
        moduleId: 'components/views/about/about',
        nav: true,
        title: 'About us',
        settings: {
            roles: [],
            font: "fa fa-info-circle"
        }
    },
    {
        route: '/admins',
        name: 'admins',
        moduleId: 'components/views/admins/admins',
        nav: true,
        title: 'Admins',
        settings: {
            roles: [],
            font: "fa fa-calendar"
        }
    },
    {
        route: '/create-user',
        name: 'create-user',
        moduleId: 'components/views/create-user/create-user',
        nav: true,
        title: 'Create User',
        settings: {
            roles: [],
            font: "fa fa-calendar"
        }
    }],
fallbackRoute: 'home'
};