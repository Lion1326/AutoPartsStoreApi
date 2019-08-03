<template>
  <div>vue new app</div>
</template>

<script>
import axios from "axios";
export default {
  name: "qwe",
  methods: {
    laodData() {
      const options = {
        method: "get",
        headers: { "Access-Control-Allow-Origin": "*" },
        url: "https://localhost:5001/Token/qwe",
        transformRequest: [
          (data, headers) => {
            return data;
          }
        ]
      };

      axios(options);
      // const options = {
      //   headers: { "Access-Control-Allow-Origin": "*" }
      // };
      // axios.get("https://localhost:5001/Token/qwe").then(function(res) {
      //   alert(res);
      //   FА;
      // });
    } 
  },
  mounted() {
    this.laodData();
  }
};
</script>

<style>
</style>
