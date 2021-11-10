<template>
  <v-bottom-navigation>
    <v-btn value="places" @click="$router.push('/places')">
      <span>Places</span>

      <v-icon>mdi-map-marker</v-icon>
    </v-btn>

    <v-btn value="places" @click="$router.push('/history')">
      <span>History</span>

      <v-icon>mdi-history</v-icon>
    </v-btn>

    <v-btn value="account" @click="$router.push('/account')">
      <span>Account</span>

      <v-icon>mdi-account</v-icon>
    </v-btn>
  </v-bottom-navigation>
</template>

<script>
export default {
  name: "Navigation",
};
</script>

<style scoped>
</style>
