<script>
/*export default {
    data() {
        return {
            message: "Hello Vue 3"
        }
    }
}
import FoodItem from './components/FoodItem.vue'*/

/*export default {
    components: {
        'food-item':FoodItem,
    },
    data() {
        return {
            foods: [
                { name: 'Alma', desc: 'Az alma egy fán termő fyümölcs', favorite: true },
                { name: 'Pizza', desc: 'A pizza kenyértészta alapon, paradicsomszósz, sajt és más feltétek', favorite: false },
                { name: 'Rizs', desc: 'A rizs egy gabonaféle, amit sok ember fogyaszt', favorite: true },
                { name: 'Hal', desc: 'A hal egy vízben élő állat', favorite: false },
                { name: 'Sütemény', desc: 'A sütemény édes és nagyon finom', favorite: true}

            ],
            newItem: "",
            items: ['Bevásárlás', 'Mosás', 'Takarítás']
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

        },
        addItem() {
            this.items.push(this.newItem);
            this.newItem = "";
        }
    }
}

export default {
    data() {
        return {
            toggleValue: true
        }
    },
    computed: {
        activeComp() {
            return this.toggleValue ? 'comp-one' : 'comp-two';
        }
    }
}

export default {
    data() {
        return {
            randomMammal: null,
            data: null
        }
    },
    methods: {
        async fetchData() {
            /*const response = await fetch('bigLandMammals.json')
            const data = await response.json();

            const randomIndex = Math.floor(Math.random() * data.results.length);
            this.randomMammal = data.results[randomIndex];
            const response = await fetch('https://nameday.abalin.net/api/V2/today/budapest')
            this.data = await response.json();
        }
    }
}*/

import axios from 'axios';

export default {
    data() {
        return {
            data: null
        }
    },
    methods: {
        async fetchData() {
            const response = await axios.get('https://nameday.abalin.net/api/V2/today/budapest')
            this.data = response.data;
        }
    }
}
</script>

<template>
    <!--<h1>Ételek</h1>
    <button @click="removeItem">Törlés</button>
    <div id="wrapper">
        <food-item v-for="x in foods"
        :key="x.name"
        :food-name="x.name"
        :food-desc="x.desc"
        :is-favorite="x.favorite"
        @toggle-favorite="receiveEmit"
        />

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
    <h3>Teendők listája</h3>
    <ul>
        <todo-item
        v-for="x in items"
        :key="x"
        :item-name="x"
        style="
        background-color: lightgreen; 
        padding: 5px; 
        margin: 5px; 
        border: dashed 1px black; 
        width: fit-content;"
        ></todo-item>
    </ul>
    <input v-model="newItem">
    <button @click="addItem">Hozzáadás</button>
    <div class="wrapper">
        <slot-comp v-for="x in foods" :key="x.name">
            <img :src="x.url">
            <h4>{{ x.desc }}</h4>
            <p>{{ x.name }}</p>
        </slot-comp>
    </div>-->
    <!--<h3>Fallback tartalom</h3>
    <slot>

    </slot>
    <footer>
        <slot-comp v-slot:bottomSlot>
            <h3>Ez egy lábléc</h3>
            <p>Copyright 2024</p>
        </slot-comp>
    </footer>
    <slot-comp>
        <template #bottomSlot> A v-slot helyett a # is működik
            <h4>Ez az új tartalom</h4>
            <p>Ez a tartalom bottomSlot nevű slotba kerül bele</p>
        </template>
    </slot-comp>
    
    <slot-comp v-slot="food" style="background-color: lightgreen; padding: 10px; margin: 0;">
        <hr>
        <h2>{{ food.foodName }} <img :src=food.foodUrl style="width: 70px; float: right; margin-left: 10px;"></h2>
        <p>{{ food.foodDesc }}</p>
    </slot-comp>

    <slot-comp v-slot="texts">
        <h2>Statikus szöveg: {{ texts.staticText }}</h2>
        <h2>Statikus szöveg: {{ texts.dynamicText}}</h2>
    </slot-comp>
    <br>
    <hr>
    <slot-comp>
        <template #leftSlot="leftProps">
            <h3>{{ leftProps.text }}</h3>
        </template>
    </slot-comp>

    <slot-comp>
        <template #rightSlot="rightProps">
            <h3>{{ rightProps.text }}</h3>
        </template>
    </slot-comp>-->
    <!--<h1>Dinamikus komponens</h1>
    <p>Egy gombbal változtathatunk a két komponens között</p>
    <button @click="toggleValue = !toggleValue" >Komponens választó</button>
    <keep-alive include="comp-one">
        <component :is="activeComp"></component>
    </keep-alive>-->

        <!--<p>A gombra kattintva egy véletlen állatot kapunk</p>
        <button @click="fetchData">Fetch Data</button>
        <div v-if="randomMammal">
            <h2>{{ randomMammal.name }}</h2>
            <p>Max Weight: {{ randomMammal.maxWeight }} kg</p>
        </div>-->  
        
        <p>Névnapok</p>
        <button @click="fetchData">Fetch Data</button>
        <div v-if="data" id="dataDiv">
            <p>Üzenet: {{ data.message }}</p>
            <p>Névnap ma: <b>{{ data.data.hu }}</b></p>
        </div>
</template>

<style>
    #app{
        width: 300px;
    }

    /*#wrapper{
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
    #app > div:hover{
        cursor: pointer;
    }*/
</style>
