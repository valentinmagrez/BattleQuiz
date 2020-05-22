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
    private messages: ChatMessage[] = [];

    private newMessage!: string;

    created(){
        this.newMessage = ""
    }
    
    private addMessage(): void{
        var user = new User()
        user.name = "a";
        this.messages.push(new ChatMessage(user, this.newMessage));
        this.newMessage = "";
    }
}
</script>