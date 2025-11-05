import { createApp } from 'vue'
import App from './App.vue'
import FoodItem from './components/FoodItem.vue'
import TodoItem from './components/Todoitem.vue'
import SlotComp from './components/SlotComp.vue'

const app = createApp(App)
app.component('food-item', FoodItem)
app.component('todo-item', TodoItem)
app.component('slot-comp', SlotComp)
app.mount('#app')
