new Vue({
    el: '#app',
    data: {
        hello: 'Hello World!',
        reverseHello: '',
        tooltip: 'This is a tooltip text',
        color: 'redText',
        fontweight: 'boldText',
        StyleObject: {
            color: 'green',
            fontSize: '20px',
        },
        myheader: '<h2 style="color:blue">Rendered with v-html directive</h2>',
        showhelloworld: true,
        a: 5,
        fruits: ['Apple', 'Banana', 'Orange'],
        person: { firstName: 'Lakatos', lastName: 'Armando', age: 30 },
        counter: 0,
        mouseEventStatus: 'NaN',
        inputText: 'Start typing...',
    },
    created: function() {
        this.reverseHello = this.hello.split(' ').reverse().join(' ');
    },
    methods: {
        /*reverseHello() {
            return this.hello.split(' ').reverse().join(' ');
        },*/
        capitalizeHello() {
            return this.hello.toUpperCase();
        },
        add(a, b) {
            return a + b;
        },
        addOne(event) {
            /*if (event) {
                event.preventDefault();
            }*/
            this.counter += 1;
        },
        addSome(valueToAdd) {
            this.counter += valueToAdd;
        },
        performMouseOver() {
            this.mouseEventStatus = 'Mouse Over Event';
        },
        performMouseOut() {
            this.mouseEventStatus = 'Mouse Out Event';
        }
    },
    /*watch: {
        hello: function(newValue) {
            this.reverseHello = newValue.split(' ').reverse().join(' ');
        }
    }*/
    computed: {
        reverseHello() {
            return this.hello.split(' ').reverse().join(' ');
        }
    }
})