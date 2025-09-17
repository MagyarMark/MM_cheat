Vue.component('button-counter', {
    data: function () {
        return {
            counter: 0
        }
    },
    template: `
    <div>
        <button @click="counter++">Add 1</button>
        Counter: {{ counter }}
    </div>`
});/*kebab-case, saját html tag létrehozása és név alapján meghívás és működtetés*/

/*Vue.component('component-a', {
    template: `<div>Component A</div>`
});

Vue.component('component-b', {
    template: `<div><component-a></component-a> Component B</div>`
});//Meglévő Componentet meg lehet hívni a másik component-be

Vue.component('component-c', {
    template: `<div>Component C</div>`
});//Ez globális*/

let componentA = {
    template: `<div>Component A</div>`
};

let componentB = {
    template: `<div>Component B</div>`
};
let componentC = {
    template: `<div>Component C</div>`
};/*Ez locális */

let app = new Vue({
    el: '#app',
    components: {
        'component-a': componentA,
        'component-b': componentB
    }
});