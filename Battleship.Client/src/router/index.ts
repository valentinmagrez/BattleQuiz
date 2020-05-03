import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'
import Game from '../views/Game.vue'

Vue.use(VueRouter)
  const loginRoute = {'path': '/login', 'name': 'Login'}
  const gamerRoute = {'path': '/', 'name': 'Game'}

  const routes: Array<RouteConfig> = [
  {
    path: gamerRoute.path,
    name: gamerRoute.name,
    component: Game,
    props: (route) => ({ gameId: route.query.gid })
  },
  {
    path: loginRoute.path,
    name: loginRoute.name,
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "login" */ '../views/Login.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

router.beforeEach((to, from, next) => {
  const isAuthenticated = localStorage.getItem('name') == null;
  if(to.name !== loginRoute.name && !isAuthenticated) next({name: loginRoute.name})
  else next()
})

export default router
