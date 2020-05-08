import { PlayerDto } from './Dto/player-dto'

export class User{
    public name!: string;

    public toString(): string{
        return this.name;
    }

    public static create(player: PlayerDto): User{
        const user = new User();
        user.name = player.name;

        return user;
    }
}