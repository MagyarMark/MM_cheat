<template>
    <div><!--@click="countClicks"-->
        <h2>
            {{ foodName }}
            <img src="../img_quality.svg" v-show="isFavorite">
        </h2>
        <p>{{ foodDesc }}</p>
        <button @click="togglefavorite">{{ isFavorite ? "Kedvenc törlése" : "Kedvenc hozzáadása" }}</button>
        <!--<h2>{{ name }}</h2>
        <p>{{ message }}</p>
        <p id="red">Klikkelések száma: {{ clicks }}</p>-->
    </div>
</template>

<script>
export default {

    props: ["foodName", "foodDesc", "isFavorite"],
    emits:[ 'toggle-favorite'],
    /*data() {
        return {
            foodisfavorite: this.isFavorite
    }
},*/
    methods: {
        togglefavorite() {
            //this.foodisfavorite = !this.foodisfavorite;
            this.$emit('toggle-favorite', this.foodName);
        }
},
    //props:["foodName", "foodDesc", "isFavorite"],
    /*props: {
        foodName: {
            type: String,
            required: true // ha nincs megadva név akkor hiba üzenetet ad
        },
        foodDesc: {
            type: String,
            required: false,
            default: "Ennek az ételnek nincs leírása",
            validator: function (value) {
                if (20 < value.length && value.length < 50) {
                    return true;
                } else {
                    return false;
                }
            }
        },
        isFavorite: {
            type: Boolean,
            required: false,
            default: false
        }
},    data() {
        return {
            foodisfavorite: this.isFavorite
    }
},
    methods: {
        togglefavorite() {
            this.foodisfavorite = !this.foodisfavorite;
    }
},

/*data() {
        return {
            name: "Alma",
            message: "Szeretem az almát",
            clicks: 0
        }
    },
    methods: {
        countClicks() {
            this.clicks++
        }
    }*/
}
</script>

<style scoped> /*a scoped miatt csak itt fog működni a stílus sehol máshol*/
    /*#red{
        font-weight: bold;
        color: rgb(144, 12, 12);
    }*/
    img{
        height: 1.5em;
        float: right;
    }

    p{
        color:  red;
    }
</style>