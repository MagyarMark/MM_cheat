<script>
/*export default {
    data() {
        return {
            message: "Hello Vue 3"
        }
    }
}*/
</script>

<template>
    <h1>Ételek</h1>
    <div id="wrapper">
        <food-item 
        food-name="Almák" 
        food-desc="A különböző almák fákon teremnek" :is-favorite="true"/>
        <food-item 
        food-name="Pizza" 
        food-desc="A pizza kenyértéstra feltétekkel" :is-favorite="false"/>
        <food-item 
        food-name="Rizs" 
        food-desc="Nagyon sok ember fogyaszt rizst" :is-favorite="false"/>
    </div>
</template>

<style>
    #wrapper{
        display: flex;
        flex-wrap: wrap;
    }
    #wrapper > div{
        border: dashed 1px black;
        flex-basis: 120px;
        margin: 10px;
        padding: 10px;
        background-color: lightgreen;
    }
    /*#app > div:hover{
        cursor: pointer;
    }*/
</style>
