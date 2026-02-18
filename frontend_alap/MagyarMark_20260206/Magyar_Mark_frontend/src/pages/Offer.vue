<template>
    <h1 class="text-center pt-2 pt-lg-4">Ajánlataink</h1>
    <table>
        <tr>
            <th>Kategória</th>
            <th>Leírás</th>
            <th>Hírdetés dátuma</th>
            <th>tehermentes</th>
            <th>Fénykép</th>
        </tr>
        <tr v-for="ingatlan in ingatlanok" :key="ingatlan.id">
            <td class="text-center">{{ ingatlan.kategoriaNev }}</td>
            <td>{{ ingatlan.leiras }}</td>
            <td class="text-center">{{ ingatlan.hirdetesDatuma }}</td>
            <td class="text-center" :class="{ zold: ingatlan.tehermentes, piros: !ingatlan.tehermentes }">
                {{ ingatlan.tehermentes ? 'igen' : 'nem' }}
            </td>
            <td class="text-center"><!--{{ ingatlan.kepUrl }}-->
                <img :src="ingatlan.kepUrl" class="kep" />
            </td>
        </tr>
    </table>
</template>

<script>
import axios from 'axios'
axios.defaults.baseURL = 'http://localhost:5000/api/'
export default {
    name: 'Offer',
    data() {
        return {
            ingatlanok: []
        }
    },
    mounted() {
        axios.get('ingatlan')
            .then(response => {
                this.ingatlanok = response.data
            })
            .catch(error => {
                console.error('Hiba az ingatlanok lekérésekor:', error)
            })
    }
}
</script>
<style>
    table {
        width: 80%;
        border-collapse: collapse;
        margin: 20px auto;
        box-shadow: 5px 5px 15px gray;
    }
    th, td {
        border-bottom: 1px solid lightgray;
        padding: 8px;
        text-align: left;
    }
    th{
        text-align: center;
    }
    .kep {
        height: 100px;
        margin: 0 auto;
        display: block;
    }

    .zold{
        color: lightgreen;
    }

    .piros{
        color: lightcoral;
    }
</style>