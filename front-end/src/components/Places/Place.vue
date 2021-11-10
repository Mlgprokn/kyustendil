<template>
  <v-hover v-slot="{ hover }">
    <v-card
      :elevation="hover ? 12 : 2"
      :class="{ 'on-hover': hover }"
    >
      <p class="mt-4 subheading">
        {{ place.title }}
      </p>
      <v-img
        :src="place.image"
        height="225px"
      >
        <v-card-title class="text-h6 white--text">
          <v-row
            class="fill-height flex-column"
            justify="space-between"
          >
          </v-row>
        </v-card-title>
      </v-img>
    </v-card>
  </v-hover>
</template>

<script>
export default {
  name: "Place",
  props: ["place"],
};
</script>

<style scoped>
.v-card {
  transition: opacity .4s ease-in-out;
}

.v-card:not(.on-hover) {
  opacity: 0.6;
 }

 .subheading {
   font-size: 30px;
 }
 </style>