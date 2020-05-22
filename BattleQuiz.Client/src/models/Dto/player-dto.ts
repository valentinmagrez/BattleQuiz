import { JsonProperty, JsonObject } from 'json2typescript';

@JsonObject("PlayerDto")
export class PlayerDto{
    @JsonProperty('name', String, true)
    public name!: string;
}