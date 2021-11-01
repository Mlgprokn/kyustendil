<template>
  <div class="container img__wrap">
    <img v-bind:src="location.image" class="img-fluid img__img"/>
    <h1 class="img__description">{{ location.title }}</h1>
  </div>
</template>

<script>
export default {
  name: "Location",
  props: ["location"],
};
</script>

<style scoped>
</style>