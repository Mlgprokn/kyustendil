<template>
  <v-app>
    <v-main>
      <Navigation />
      <router-view/>
    </v-main>
  </v-app>
</template>

<script>
import Navigation from './components/Navigation.vue';

export default {
  name: "App",
  components: {
    Navigation,
  },
};
</script>

<style>
#app {
  font-family: Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
