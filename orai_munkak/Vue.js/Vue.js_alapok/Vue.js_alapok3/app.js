Vue.component('tab-home', {
    template: `<div>Home component</div>`
})

Vue.component('tab-hello', {
    template: `<div>Hello component</div>`
})

Vue.component('tab-fruit', {
    template: `<div>fruit component</div>`
})

new Vue({
    el: '#app',
    data:{
        currentTab: 'home',
        tabs: ['home', 'hello', 'fruit']
    },
    computed: {
        currentTabComponent: function(){
            return 'tab-' + this.currentTab.toLowerCase()
        }
    }
})