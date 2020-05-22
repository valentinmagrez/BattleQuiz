import { User } from '@/models/user'

export class ChatMessage{
    public user: User;
    public message: string;

    constructor(user: User, message: string){
        this.user = user;
        this.message = message;
    }
}