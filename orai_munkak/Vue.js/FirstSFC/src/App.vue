<script>
/*export default {
    data() {
        return {
            message: "Hello Vue 3"
        }
    }
}*/

export default {
    data() {
        return {
            foods: [
                { name: 'Alma', desc: 'Az alma egy fán termő fyümölcs', favorite: true },
                { name: 'Pizza', desc: 'A pizza kenyértészta alapon, paradicsomszósz, sajt és más feltétek', favorite: false },
                { name: 'Rizs', desc: 'A rizs egy gabonaféle, amit sok ember fogyaszt', favorite: true },
                { name: 'Hal', desc: 'A hal egy vízben élő állat', favorite: false },
                { name: 'Sütemény', desc: 'A sütemény édes és nagyon finom', favorite: true}

            ]
        }
    },
    methods: {
        removeItem() {
            this.foods.splice(0, 1);//a tömbből kivágja az első elemet
        },
        receiveEmit(foodId) {
            //alert(foodId+' Ételre kattintottál');
            const foundFood = this.foods.find(food => food.name == foodId); 
            foundFood.favorite = !foundFood.favorite;

        }
    }
}
</script>

<template>
    <h1>Ételek</h1>
    <button @click="removeItem">Törlés</button>
    <div id="wrapper">
        <food-item v-for="x in foods"
        :key="x.name"
        :food-name="x.name"
        :food-desc="x.desc"
        :is-favorite="x.favorite"
        @toggle-favorite="receiveEmit"
        />

        <!--<food-item 
        food-name="Almák" 
        food-desc="A különböző almák fákon teremnek" :is-favorite="true"/>
        <food-item 
        food-name="Pizza" 
        food-desc="A pizza kenyértéstra feltétekkel" :is-favorite="false"/>
        <food-item 
        food-name="Rizs" 
        food-desc="Nagyon sok ember fogyaszt rizst" :is-favorite="false"/>-->
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
