<template>
    <div>
        <div v-for="(chatMessage, index) in messages" v-bind:key="index">
            {{chatMessage.user}}: {{chatMessage.message}}
        </div>
        <input v-model="newMessage" placeholder="Entrez du texte...">
        <button v-on:click="addMessage">Envoyer</button>
    </div>
</template>

<script lang="ts">
import {Component, Vue} from 'vue-property-decorator';
import { ChatMessage } from '@/models/chat-message'
import { User } from '@/models/user'

@Component
export default class Chat extends Vue {
    private messages: ChatMessage[] = [
        new ChatMessage(new User("test"), "message 1"),
        new ChatMessage(new User("test1"), "message 2"),
        new ChatMessage(new User("test2"), "message 3"),
    ];

    private newMessage!: string;

    created(){
        this.newMessage = ""
    }
    
    private addMessage(): void{
        this.messages.push(new ChatMessage(new User("customuser"), this.newMessage));
        this.newMessage = "";
    }
}
</script>