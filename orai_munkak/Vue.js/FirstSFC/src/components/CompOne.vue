<template>
    <!--<div>
        <h1>Ez az egyes komponens</h1>
    </div>
    <div>
        <img :src="imgSrc">
        <h2>Component One</h2>
        <p>Choose food.</p>
        <label>
            <input type="radio" name="rbgfood" v-model="imgSrc" value="img_apple.svg">
            Apple
        </label>
        <label>
            <input type="radio" name="rbgfood" v-model="imgSrc" value="img_cake.svg">
            Cake
        </label>
    </div>-->
    <div>
        <img :src="imgSrc">
        <h2>Component One</h2>
        <p>Choose One</p>
        <teleport to='body' >
            <div id="redDiv">Hello</div>
        </teleport>
    </div>
</template>

<style scoped>
div{
    background-color: lightgreen;
}
img{
    float: right;
    width: 70px;
    margin-top: 20px;
}
label:hover{
    cursor: pointer;
}
#redDiv{
    background-color: red;
    width: 300px;
    height: 100px;
    font-size: 24px;
}
</style>

<script>
export default {
    name: 'comp-one',
    data() {
        return {
            imgSrc: 'img_question.svg'
        }
    }
}
</script>