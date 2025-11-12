<template>
    <div>
        <slot v-for="x in foods" 
        :key="x.name" 
        :foodName="x.name"
        :foodDesc="x.desc"
        :foodUrl="x.url">
        </slot> <!--v-bind:lclData="data"-->
    </div><!--
    <div>
        <slot>
            <h4>Nincs megadva tartalom!</h4>
        </slot>
    </div>
    <div>
        <slot name="bottomSlot"></slot>
    </div>-->

    <!--<slot staticText="Ez egy statikus szöveg" :dynamicText="text"></slot>-->
    <slot name="leftSlot" :text="leftText"></slot>
    <slot name="rightSlot" :text="rightText"></slot>
</template>

<script>
export default {
    data() {
        return {
            //data: "Ez egy slotból érkező adat"
            //foods: ['Alma', 'Banán', 'Cseresznye']
            foods: [
                    {name:'Alma', desc: "Ez egy alma", url: './img_apple.svg'},
                    {name:'Pizza', desc: "Ez egy pizza", url: './img_pizza.svg'},
                    {name:'Rízs', desc: "Ez itt RIZSA", url: './img_rice.svg'},
                    {name:'Hal', desc: "Ez itt egy hal", url: './img_fish.svg'},
                    {name:'Torta', desc: "TORTAAAA", url: './img_cake.svg'}
            ],
                leftText:'Ez a left slot szövege',
                rightText:'Ez a right slot szövege'
            }
        }
    }
</script>

<style scoped>
div{
    box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
    border-radius: 10px;
    margin: 10px;
}

</style>