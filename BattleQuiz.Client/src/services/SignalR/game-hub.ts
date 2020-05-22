import { Hub } from './hub';
import { Game } from '@/models/game';


class GameServerMethod{
    public static readonly JOIN_GAME="JoinGame";
}

export class GameHub extends Hub{
    constructor(){
        super("gamehub")
    }

    public joinGame(game: Game): void {
        this.hubConnection.invoke(GameServerMethod.JOIN_GAME, game.token);
    }

    protected registerOnServerEvents(): void {        
        this.hubConnection.on('playerJoinGame', (user: string) => {
            console.log('New player join');
        });
    }
}