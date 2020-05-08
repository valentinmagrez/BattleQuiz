<template>
  <div class="game">
    <img alt="Vue logo" src="../assets/logo.png">
    {{gameId}}
  </div>
</template>

<script lang="ts">

import { Vue, Component, Prop } from 'vue-property-decorator';
import { GameService } from '@/services/API/game-service'
@Component({
        name: 'Game',
        components: {  },
})
export default class extends Vue{
  @Prop(String) public gameId: string | undefined;
  private gameService: GameService = new GameService();

  async mounted(): Promise<void> {
    if (this.gameId === undefined){
      this.createGame();
    }
    else{
      this.loadGame();
    }
  }

  createGame(): void{
    this.gameService.createGame().then((game) => {
      this.gameId = game.token;
    });
  }

  loadGame(): void{
    console.log('call api to get party data, if none create')
  }
}
</script>
