<template>
  <div class="row align-items-center">
    <div class="col row align-items-center test">
      <div class="col-md-6">
        <img v-bind:src="location.image" class="img-fluid" />
      </div>
      <div class="col-md-6">
        <h1>{{ location.title }}</h1>
        <p class="text-muted">{{ location.information }}</p>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Location",

  props: ["location"],
};
</script>

<style scoped>
img {
  width: 80%; /* You can set the dimensions to whatever you want */
  height: 80%;
  border-radius: 2%;
}


.test {
    padding: 10px; 
}
</style>
