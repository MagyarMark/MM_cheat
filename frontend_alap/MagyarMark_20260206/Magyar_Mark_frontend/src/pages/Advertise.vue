<template>
    <div class="container">
        <h2 class="mb-4 text-center">Új hirdetés elküldése</h2>
        <div class="row">
            <div class="offset-lg-3 offset-md-2 col-lg-6 col-md-8 col-12">
                <div class="mb-3">
                    <label for="category" class="form-label">Ingatlan kategóriája</label>
                    <select class="form-select" v-model="ujIngatlanUrlap.kategoriaId">
                        <option value="0">Kérem válasszon</option>
                        <option v-for="kategoria in kategoriak" :key="kategoria.id" :value="kategoria.id">
                            {{ kategoria.megnevezes }}
                        </option>
                    </select>

                </div>

                <div class="mb-3">
                    <label for="date" class="form-label">Hirdetés dátuma</label>
                    <input type="date" class="form-control" v-model="ujIngatlanUrlap.hirdetesDatuma">
                </div>
                <div class="mb-3">
                    <label for="description" class="form-label">Ingatlan leírása</label>
                    <textarea class="form-control" v-model="ujIngatlanUrlap.leiras" rows="3"></textarea>
                </div>
                <div class="form-check mb-3">
                    <input class="form-check-input" type="checkbox" v-model="ujIngatlanUrlap.tehermentes">
                    <label class="form-check-label" for="creditFree">Tehermentes ingatlan</label>
                </div>
                <div class="mb-3">
                    <label for="pictureUrl" class="form-label">Fénykép az ingatlanról</label>
                    <input type="url" class="form-control" v-model="ujIngatlanUrlap.kepUrl">
                </div>
                <div class="mb-3 text-center">
                    <button class="btn btn-primary px-5" @click="mentes()">Küldés</button>
                </div>

                <div class="alert alert-danger alert-dismissible" role="alert">
                    <strong>{{ hibaUzenet }}</strong>
                    <button type="button" class="btn-close"></button>
                </div>

            </div>
        </div>
    </div>
</template>

<script>
    import axios from 'axios'
    axios.defaults.baseURL = 'http://localhost:5000/api/'
export default {
    name: 'Advertise',
    data() {
        return {
            kategoriak: [],
            ujIngatlanUrlap: {
                kategoriaId: 0,
                hirdetesDatuma: new Date().toISOString().substr(0, 10),
                leiras: '',
                tehermentes: false,
                kepUrl: ''
            },
            hibaUzenet: ''
        };
    },
    mounted() {
        axios.get('kategoriak')
            .then(response => {
                this.kategoriak = response.data
            })
            .catch(error => {
                console.error('Hiba a kategóriák lekérésekor:', error)
            });
    },
    methods: {
        mentes() {
            axios.post('ujingatlan', this.ujIngatlanUrlap)
                .then(() => {
                    this.$router.push('/offer')
                })
                .catch(error => {
                    this.hibaUzenet = error + " ";
                });
        }
    }
}
</script>

<style>

</style>