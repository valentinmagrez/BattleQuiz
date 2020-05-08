import { PlayerDto } from './player-dto'
import { JsonProperty, JsonObject } from 'json2typescript';

@JsonObject("GameDto")
export class GameDto{
    @JsonProperty('players', [PlayerDto], true)
    players: PlayerDto[] = [];

    @JsonProperty('urlId', String, true)
    token: string | undefined = undefined;
}