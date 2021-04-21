import Vue from "vue";
import App from "./App.vue";
//fullpage
import 'fullpage.js/dist/fullpage.css'
import 'fullpage.js/vendors/scrolloverflow' // Optional. When using scrollOverflow:true
import VueFullPage from 'vue-fullpage.js'

//Bootstrap
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

//aos
import AOS from 'aos'
import 'aos/dist/aos.css'

AOS.init()
Vue.use(BootstrapVue)
Vue.use(IconsPlugin)
Vue.use(VueFullPage);
Vue.config.productionTip = false;

new Vue({
  render: (h) => h(App),
}).$mount("#app");
