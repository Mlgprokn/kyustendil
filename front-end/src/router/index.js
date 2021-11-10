import Vue from "vue";
import VueRouter from "vue-router";
import Places from "../components/Places/Places.vue";
import AddPlace from "../components/Places/AddPlace.vue";
import Account from "../components/Account/Account.vue";
import History from "../components/History/History.vue";

Vue.use(VueRouter);

const routes = [
  {
    path: "/places",
    name: "Places",
    component: Places,
  },
  {
    path: "/places/add",
    name: "AddPlace",
    component: AddPlace
  },
  {
    path: "/account",
    name: "Account",
    component: Account
  },
  {
    path: "/history",
    name: "History",
    component: History
  },
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes,
});

export default router;
