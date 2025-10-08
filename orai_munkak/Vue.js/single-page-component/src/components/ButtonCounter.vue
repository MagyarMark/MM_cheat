<template lang="pug">
    div
        button(@click="counter++") Add +1
        p Clicked {{ counter }}
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

<style lang="less" scoped>
@color: blue;
    p{
        color: @color;
    }
</style>