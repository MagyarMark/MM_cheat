import './assets/main.css'
import { createApp } from 'vue'
import HelloUser from './components/helloUser.vue'
import ButtonCounter from './components/ButtonCounter.vue'
import App from './App.vue'

const app = createApp(App);
app.component('helloUser', HelloUser);
app.component('ButtonCounter', ButtonCounter);
app.mount('#app');
