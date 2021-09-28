<template>
  <v-container class="pa-4 text-center">
    <v-row
      class="fill-height"
      align="center"
      justify="center"
    >
      <v-col cols="8">
        <v-text-field :rules="rules" prepend-icon="mdi-magnify"></v-text-field>
        <v-btn elevation="2">Search <v-icon right dark>mdi-magnify</v-icon></v-btn>
      </v-col>
      <v-col cols="4">
        <v-btn elevation="2">Add new location</v-btn>
      </v-col>
      <v-divider></v-divider>
      <template v-for="(location, i) in locations">
        <v-col
          :key="i"
          cols="12"
          md="3"
        >
          <Location v-bind:location="location" />
        </v-col>
      </template>
    </v-row>
  </v-container>
</template>

<script>
import Location from './Location.vue';
export default {
  name: "Home",
  components: {
    Location
  },
  data: function () {
    return {
      options: {
        keyboardScrolling: true,
        scrollOverflow: true,
        scrollBar: false,
        navigation: true,
        navigationPosition: 'left',
        sectionsColor: ['#C2B9B0', '#C2CAD0', '#C2B9B0', '#E7717D', '#AFD275'],                  
      },
      locations: [
        {
          id: 1,
          image: "https://www.pmgkn.com/images/phocagallery/pmg-gallery-2020/thumbs/phoca_thumb_l_pmg-dvor-esen_2018_17.jpg",
          title: "ПМГ",
          information:
            "Nunc vel malesuada purus, vitae posuere enim. Fusce accumsan sodales porttitor. Sed vulputate ac libero eget mollis. Nulla nec lectus faucibus, fermentum leo a, pretium lectus. In magna nisl, egestas eget fermentum non, auctor eu ex. Aliquam nisl turpis, suscipit ut dapibus vitae, vestibulum et ipsum. Nullam risus ante, tincidunt in lorem quis, mattis pulvinar ipsum. Sed a dapibus felis, et rutrum nunc. Aenean accumsan dictum mauris. Maecenas tristique lorem erat, non laoreet ipsum sollicitudin eget.",
        },
        {
          id: 2,
          image: "https://eg-kn.eu/uploads/index_1.jpg",
          title: "Езикова",
          information:
            "Nunc vel malesuada purus, vitae posuere enim. Fusce accumsan sodales porttitor. Sed vulputate ac libero eget mollis. Nulla nec lectus faucibus, fermentum leo a, pretium lectus. In magna nisl, egestas eget fermentum non, auctor eu ex. Aliquam nisl turpis, suscipit ut dapibus vitae, vestibulum et ipsum. Nullam risus ante, tincidunt in lorem quis, mattis pulvinar ipsum. Sed a dapibus felis, et rutrum nunc. Aenean accumsan dictum mauris. Maecenas tristique lorem erat, non laoreet ipsum sollicitudin eget.",
        },
        {
          id: 3,
          image: "http://images.focus-news.net/2ba1b72c553aea28b0a7c7cd3845c768.jpg",
          title: "Галерия",
          information:
            "Nunc vel malesuada purus, vitae posuere enim. Fusce accumsan sodales porttitor. Sed vulputate ac libero eget mollis. Nulla nec lectus faucibus, fermentum leo a, pretium lectus. In magna nisl, egestas eget fermentum non, auctor eu ex. Aliquam nisl turpis, suscipit ut dapibus vitae, vestibulum et ipsum. Nullam risus ante, tincidunt in lorem quis, mattis pulvinar ipsum. Sed a dapibus felis, et rutrum nunc. Aenean accumsan dictum mauris. Maecenas tristique lorem erat, non laoreet ipsum sollicitudin eget.",
        },
        {
          id: 4,
          image: "http://images.focus-news.net/2ba1b72c553aea28b0a7c7cd3845c768.jpg",
          title: "Галерия",
          information:
            "Nunc vel malesuada purus, vitae posuere enim. Fusce accumsan sodales porttitor. Sed vulputate ac libero eget mollis. Nulla nec lectus faucibus, fermentum leo a, pretium lectus. In magna nisl, egestas eget fermentum non, auctor eu ex. Aliquam nisl turpis, suscipit ut dapibus vitae, vestibulum et ipsum. Nullam risus ante, tincidunt in lorem quis, mattis pulvinar ipsum. Sed a dapibus felis, et rutrum nunc. Aenean accumsan dictum mauris. Maecenas tristique lorem erat, non laoreet ipsum sollicitudin eget.",
        },
        {
          id: 5,
          image: "https://www.pmgkn.com/images/phocagallery/pmg-gallery-2020/thumbs/phoca_thumb_l_pmg-dvor-esen_2018_17.jpg",
          title: "ПМГ",
          information:
            "Nunc vel malesuada purus, vitae posuere enim. Fusce accumsan sodales porttitor. Sed vulputate ac libero eget mollis. Nulla nec lectus faucibus, fermentum leo a, pretium lectus. In magna nisl, egestas eget fermentum non, auctor eu ex. Aliquam nisl turpis, suscipit ut dapibus vitae, vestibulum et ipsum. Nullam risus ante, tincidunt in lorem quis, mattis pulvinar ipsum. Sed a dapibus felis, et rutrum nunc. Aenean accumsan dictum mauris. Maecenas tristique lorem erat, non laoreet ipsum sollicitudin eget.",
        },
        {
          id: 6,
          image: "https://eg-kn.eu/uploads/index_1.jpg",
          title: "Езикова",
          information:
            "Nunc vel malesuada purus, vitae posuere enim. Fusce accumsan sodales porttitor. Sed vulputate ac libero eget mollis. Nulla nec lectus faucibus, fermentum leo a, pretium lectus. In magna nisl, egestas eget fermentum non, auctor eu ex. Aliquam nisl turpis, suscipit ut dapibus vitae, vestibulum et ipsum. Nullam risus ante, tincidunt in lorem quis, mattis pulvinar ipsum. Sed a dapibus felis, et rutrum nunc. Aenean accumsan dictum mauris. Maecenas tristique lorem erat, non laoreet ipsum sollicitudin eget.",
        },
        {
          id: 4,
          image: "http://images.focus-news.net/2ba1b72c553aea28b0a7c7cd3845c768.jpg",
          title: "Галерия",
          information:
            "Nunc vel malesuada purus, vitae posuere enim. Fusce accumsan sodales porttitor. Sed vulputate ac libero eget mollis. Nulla nec lectus faucibus, fermentum leo a, pretium lectus. In magna nisl, egestas eget fermentum non, auctor eu ex. Aliquam nisl turpis, suscipit ut dapibus vitae, vestibulum et ipsum. Nullam risus ante, tincidunt in lorem quis, mattis pulvinar ipsum. Sed a dapibus felis, et rutrum nunc. Aenean accumsan dictum mauris. Maecenas tristique lorem erat, non laoreet ipsum sollicitudin eget.",
        },
        {
          id: 5,
          image: "https://www.pmgkn.com/images/phocagallery/pmg-gallery-2020/thumbs/phoca_thumb_l_pmg-dvor-esen_2018_17.jpg",
          title: "ПМГ",
          information:
            "Nunc vel malesuada purus, vitae posuere enim. Fusce accumsan sodales porttitor. Sed vulputate ac libero eget mollis. Nulla nec lectus faucibus, fermentum leo a, pretium lectus. In magna nisl, egestas eget fermentum non, auctor eu ex. Aliquam nisl turpis, suscipit ut dapibus vitae, vestibulum et ipsum. Nullam risus ante, tincidunt in lorem quis, mattis pulvinar ipsum. Sed a dapibus felis, et rutrum nunc. Aenean accumsan dictum mauris. Maecenas tristique lorem erat, non laoreet ipsum sollicitudin eget.",
        },
        {
          id: 6,
          image: "https://eg-kn.eu/uploads/index_1.jpg",
          title: "Езикова",
          information:
            "Nunc vel malesuada purus, vitae posuere enim. Fusce accumsan sodales porttitor. Sed vulputate ac libero eget mollis. Nulla nec lectus faucibus, fermentum leo a, pretium lectus. In magna nisl, egestas eget fermentum non, auctor eu ex. Aliquam nisl turpis, suscipit ut dapibus vitae, vestibulum et ipsum. Nullam risus ante, tincidunt in lorem quis, mattis pulvinar ipsum. Sed a dapibus felis, et rutrum nunc. Aenean accumsan dictum mauris. Maecenas tristique lorem erat, non laoreet ipsum sollicitudin eget.",
        },
      ],
    };
  },
};
</script>

<style scoped></style>

