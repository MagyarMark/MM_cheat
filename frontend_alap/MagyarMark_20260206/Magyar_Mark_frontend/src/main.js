import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap'
import router from './router.js'
import axios from 'axios'

import './assets/openpage.css'

import { createApp } from 'vue'
import App from './App.vue'

createApp(App)
    .use(router)
    .use(axios)
    .mount('#app')
