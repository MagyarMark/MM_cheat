new Vue({
    el: '#app',
    data: {
        hello: 'Hello World!',
        tooltip: 'This is a tooltip text',
        color: 'redText',
        fontweight: 'boldText',
        StyleObject: {
            color: 'green',
            fontSize: '20px',
        }
    },
    created: function() {
        console.log('Vue instance created.');
    }
})