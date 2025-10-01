import { createRouter, createWebHistory } from "vue-router";
import Home from './pages/Home.vue'
import Offers from './pages/offers.vue'
import Newad from './pages/newad.vue'

const routes = [
    {
        path: "/",
        name: "Home",
        component: Home
    },
    {
        path: "/offers",
        name: "Offers",
        component: Offers
    },
    {
        path: "/newad",
        name: "Newad",
        component: Newad
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;