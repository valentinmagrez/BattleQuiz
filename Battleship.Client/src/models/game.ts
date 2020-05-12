import { User } from './user'
import { GameDto } from './Dto/game-dto';

export class Game{
    players: User[] = [];
    token: string | undefined;

    public get url(): string{
        return "?gid=" + this.token;
    }

    public static create(game: GameDto): Game{
        const result = new Game();
        const players = game.players.map(player => User.create(player));
        result.players = players;
        result.token = game.token;

        return result;
    }
}