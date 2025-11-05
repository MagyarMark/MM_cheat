<template>
    <div class="pinkBall"></div>
        <li v-bind="$attrs">{{ itemName }}</li>
<!--ezzel az vbindal egyértelmű, hogy melyik stílust akarjuk használni-->
    <!--<p>piros</p>-->
    <div class="pinkBall"></div>
</template>

<script>
export default {
        props: ["itemName"]
    }
</script>