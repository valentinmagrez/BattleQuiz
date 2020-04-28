<template>
    <div>
        <login-frame></login-frame>
        <chat></chat>
    </div>    
</template>

<script lang="ts">
import { Vue, Component } from 'vue-property-decorator';
import LoginFrame from '@/components/LoginFrame.vue'
import Chat from '@/components/Chat.vue'

@Component({
        name: 'Login',
        components: { LoginFrame, Chat },
})
export default class extends Vue{ }
</script>