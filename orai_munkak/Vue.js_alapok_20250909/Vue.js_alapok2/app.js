/*let myMixin = {
    created() {
        this.hello();
    },
    methods: {
        hello() {
            console.log('Hello from mixin!');
        }
    }
};

Vue.component('button-counter', {

    /*data: function () {
        return {
            counter: 0
        }
    } //Ez a régi szintaxis

    props: ['counter'], //Ez a új szintaxis
    template: `
    <div>
        <button @click="counter++">Add 1</button>
        Counter: {{ counter }}
    </div>` //Ez a régi szintaxis
    template: `
    <div>
        <button @click="$emit('add-some', 1)">Add 1</button>
        <button @click="$emit('add-some', 5)">Add 5</button>
        Counter: {{ counter }}
    </div>`, //Ez a új szintaxis

    mixins: [myMixin],
    data() {
        return {
            counter: 0
        }
    },
    template: `
    <div>
        <button @click="counter++">Add 1</button>
        Counter: {{ counter }}
    </div>`
});//kebab-case, saját html tag létrehozása és név alapján meghívás és működtetés*/

/*Vue.component('component-a', {
    template: `<div>Component A</div>`
});

Vue.component('component-b', {
    template: `<div><component-a></component-a> Component B</div>`
});//Meglévő Componentet meg lehet hívni a másik component-be

Vue.component('component-c', {
    template: `<div>Component C</div>`
});//Ez globális

let componentA = {
    template: `<div>Component A</div>`
};

let componentB = {
    template: `<div>Component B</div>`
};
let componentC = {
    template: `<div>Component C</div>`
};//Ez locális*/

/*Vue.component('hello-user', {
    props: ['name'],//props: ['username', 'age'] - több paraméter is lehet vesszővel elválasztva
    props: {
        name: {
            type: String,
            required: false,
            default: 'Csaba'
        }
    },
    template: `<div>Hello, {{ name }}!</div>`//{{ username }} - több paraméter is lehet vesszővel elválasztva
});*/

Vue.component('custom-input', {
    props: ['value'],
    template: `
    <input
        :value="value"
        @input="$emit('input', $event.target.value)"
    >
    `
});//Custom input component létrehozása


Vue.component('hello-user', {
    props: ['name'],
    template: `<div>Hello, <slot></slot>!</div>`
});//Hello user component létrehozása
let app = new Vue({
    el: '#app',
    data: {
        name: 'Jhon',
        /*counter: 0,*/
        inputText: 'Hello'
    },
    /*components: {
        'component-a': componentA,
        'component-b': componentB
    },*/
    
    /*methods: {
        addOne: function () {
            this.counter++;
        },
        addSome: function (valueToAdd) {
            this.counter += valueToAdd;
        }
    }*/
});