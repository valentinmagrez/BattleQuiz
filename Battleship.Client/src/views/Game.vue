<template>
  <div class="game">
    <img alt="Vue logo" src="../assets/logo.png">
    {{gameId}}
  </div>
</template>

<script lang="ts">

import { Vue, Component, Prop } from 'vue-property-decorator';

@Component({
        name: 'Game',
        components: {  },
})
export default class extends Vue{
  @Prop(String) public gameId!: string;
}
</script>
