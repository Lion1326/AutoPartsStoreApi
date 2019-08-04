<template>
  <div>vue new app</div>
</template>

<script>
import axios from "axios";

export default {
  name: "ewq",
  methods: {
    laodData() {
      axios
        .get("/Main/Test")
        .then(function(res) {
          console.log(res);
        })
        .catch(error => {
          console.log(error);
        });
    }
  },
  mounted() {
    this.laodData();
  }
};
</script>

<style>
</style>