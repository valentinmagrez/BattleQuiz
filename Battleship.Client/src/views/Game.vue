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
  @Prop(String) public gameId: string | undefined;

  async mounted(): Promise<void> {
    if (this.gameId === undefined){
      this.createGame();
    }
    else{
      this.loadGame();
    }
  }

  createGame(): void{
    console.log('Create game');
  }

  loadGame(): void{
    console.log('call api to get party data, if none create')
  }
}
</script>
