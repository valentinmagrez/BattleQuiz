import {
    HubConnection,
    HubConnectionBuilder,
    HubConnectionState,
    LogLevel
  } from '@microsoft/signalr';

export abstract class Hub{
    readonly signalRUrl: string = "https://localhost:32768/"
    protected hubConnection: HubConnection;

    constructor(hubName: string){
        this.hubConnection = this.createConnection(hubName);
        this.registerOnServerEvents();
        this.startConnection();    
    }

    createConnection(hubName: string) {    
        return new HubConnectionBuilder()
            .withUrl(this.signalRUrl + hubName)
            .withAutomaticReconnect()
            .configureLogging(LogLevel.Information)
            .build();
    }

    abstract registerOnServerEvents(): void;

    private startConnection() {
        if (this.hubConnection.state === HubConnectionState.Connected) {
          return;
        }
    
        this.hubConnection.start().then(
          () => {
            console.log('Hub connection started!');
          },
          error => console.error(error)
        );
      }
}