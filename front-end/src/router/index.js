import Vue from "vue";
import VueRouter from "vue-router";
import Home from "../components/Home.vue";
import LocationShow from "../components/LocationShow.vue";

Vue.use(VueRouter);

const routes = [
  {
    path: "/places",
    name: "Home",
    component: Home,
  },
  {
    path: "/places/add",
    name: "LocationShow",
    component: LocationShow
  },
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes,
});

export default router;
