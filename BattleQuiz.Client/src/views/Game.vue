<template>
  <div class="game">
    <img alt="Vue logo" src="../assets/logo.png">
    {{gameUrl}}
  </div>
</template>

<script lang="ts">

import { Vue, Component, Prop, Watch } from 'vue-property-decorator';
import { GameService } from '@/services/API/game-service';
import { GameHub } from '@/services/SignalR/game-hub';
import { Game } from '@/models/game';

@Component({
        name: 'Game',
        components: {  },
})
export default class extends Vue{
  private gameService: GameService = new GameService();
  private gameHub: GameHub = new GameHub();
  private game: Game | null = null;

  @Prop(String) public gameId: string | undefined;

  get gameUrl(): string{
    if (this.game === null) {
      return "";
    }
    return this.game.url;
  }

  private setGame(game: Game): void{
      this.game = game;
      this.gameHub.joinGame(game);
  }

  async mounted(): Promise<void> {
    try{
      await this.gameHub.connect();
      this.loadGame();
    }
    catch(error){
      console.error(error)
    }
  }

  async loadGame(): Promise<void>{
    let game = undefined;
    if (this.gameId === undefined) {
      game = await  this.gameService.createGame();
    }
    else{
      game = await this.gameService.getGame(this.gameId);
    }
    this.setGame(game);
  }
}
</script>
