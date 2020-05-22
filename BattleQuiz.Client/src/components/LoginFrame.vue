<template>
    <div>
        <h1 class="login-title">BattleQuiz</h1>
        <div class="field">
            <div class="control has-icons-left">
                <input class="input" placeholder="Pseudo" maxlength="20">
                <span class="icon is-small is-left">
                    <font-awesome-icon icon="user" />
                </span>
            </div>
        </div>
        <button class="button is-info login-button" v-on:click="connect()">
            Jouer
        </button>
    </div>
</template>


<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class LoginFrame extends Vue {
  public connect(): void{
      console.log("ici");
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
    .login-title{
        margin-bottom: 3%;
        font-weight: bold;
    }

    .login-button{
        width: 100%;
    }
</style>
