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
<<<<<<< HEAD
  width: 80%;
  height: 80%;
  border-radius: 2%;
}

.test {
    padding: 10px; 
=======
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
>>>>>>> 4d032ba4d3442a7eab8c34f7d7fd2bc93b7c8c4d
}
</style>