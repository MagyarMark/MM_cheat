<template>
    <!--<div>
        <h1>Ez a kettes komponens</h1>
    </div>-->
    <div>
        <h2>Component Two</h2>
        <input type="text" v-model="msg" placeholder="Write something...">
        <p>Your message: </p>
        <p><strong>{{ this.msg }}</strong></p>
    </div>
</template>

<style scoped>
div{
    background-color: lightcoral;
    width: 300px;
    padding:20px;
    margin:10px
}
strong{
    background-color: yellow;
    padding: 5px;
}
</style>

<script>
export default {
    name: 'comp-two',
    data() {
        return {
            msg:''
        }
    }
}
</script>