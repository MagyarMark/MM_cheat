<template>
    <div>
        <button @click="counter++">Add +1</button>
        <p>Clicked {{ counter }} times.</p>
    </div>
</template>

<script>
export default {
    data() {
        return {
                counter: 0
            }
        }
    }
</script>

<style scoped>
    p{
        color: blue;
    }
</style>