<template>
    <div>
        <div class="field">
            <div class="control has-icons-left">
                <input class="input" placeholder="Pseudo">
                <span class="icon is-small is-left">
                    <font-awesome-icon icon="user" />
                </span>
            </div>
        </div>
        <button class="button is-info">
            Jouer
        </button>
    </div>
</template>


<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class LoginFrame extends Vue {
  
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">

</style>
