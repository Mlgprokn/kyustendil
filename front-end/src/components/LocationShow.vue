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
img {
}

.img__wrap {
  position: relative;
  width: 100%; /* You can set the dimensions to whatever you want */
  height: 100%;
  border-radius: 2%;
}

.img__description {
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background: rgba(57, 55, 61, 0.72);
  color: rgb(234, 255, 50);
  opacity: 0;
}

.img__wrap:hover .img__description {
  visibility: visible;
  color: #fff;
  opacity: 1;
}
</style>