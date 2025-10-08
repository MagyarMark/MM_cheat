import './assets/main.css'
import { createApp } from 'vue'
import HelloUser from './components/helloUser.vue'
import ButtonCounter from './components/ButtonCounter.vue'
import App from './App.vue'
import { createStore } from 'vuex'

const store = createStore({
    state(){
        counter: 0
    },
    mutations: {
        increment(state) {
            state.counter++
        }
    }
})

const app = createApp(App);
app.component('helloUser', HelloUser);
app.component('ButtonCounter', ButtonCounter);
app.mount('#app');
