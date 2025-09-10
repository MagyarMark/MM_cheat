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
        myheader: '<h2 style="color:blue">Rendered with v-html directive</h2>'
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