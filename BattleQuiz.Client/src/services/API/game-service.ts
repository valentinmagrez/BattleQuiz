import { Game } from '@/models/game'
import { GameDto } from '@/models/Dto/game-dto'
import { ApiService } from './api-service'

export class GameService extends ApiService{
    private readonly resource = "game";

    public async createGame(): Promise<Game>{
        const gameDto = await this.postResource(GameDto, this.resource);
        
        return Game.create(gameDto);
    }

    public async getGame(gameId: string): Promise<Game>{
        const resource = this.resource + "/" + gameId;
        const gameDto = await this.get(GameDto, resource);
        
        return Game.create(gameDto);
    }
}