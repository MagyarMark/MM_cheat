import { createRouter, createWebHistory } from 'vue-router'
import Home from './pages/Home.vue'
import Offer from './pages/Offer.vue'
import Advertise from './pages/Advertise.vue'

const routes = [
    {
        path: '/',
        name: 'Home',
        component: Home
    },
    {
        path: '/offer',
        name: 'Offer',
        component: Offer
    },
    {
        path: '/advertise',
        name: 'Advertise',
        component: Advertise
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router
