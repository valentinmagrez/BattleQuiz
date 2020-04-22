import { Hub } from './hub'

export class ChatHub extends Hub{
    constructor(){
        super("chathub")
    }

    registerOnServerEvents(): void {    
        this.hubConnection.on('receiveMessage', (user: string, message: string) => {
            console.log(user + ': '+message);
      });
    }

    public sendMessage(user: string, message: string){
        this.hubConnection.send("sendMessage", user, message)
        .then(() => console.log("message sent"));
    }
}