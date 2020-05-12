import {
    HubConnection,
    HubConnectionBuilder,
    HubConnectionState,
    LogLevel
  } from '@microsoft/signalr';

export abstract class Hub{
    readonly signalRUrl: string = "https://localhost:32770/"
    protected hubConnection: HubConnection;

    constructor(hubName: string){
        this.hubConnection = this.createConnection(hubName);
        this.registerOnServerEvents();
    }

    protected createConnection(hubName: string) {    
        return new HubConnectionBuilder()
            .withUrl(this.signalRUrl + hubName)
            .withAutomaticReconnect()
            .configureLogging(LogLevel.Information)
            .build();
    }

    protected abstract registerOnServerEvents(): void;

    public async connect() {
        if (this.hubConnection.state === HubConnectionState.Connected) {
          return;
        }
    
        await this.hubConnection.start();
    }
}