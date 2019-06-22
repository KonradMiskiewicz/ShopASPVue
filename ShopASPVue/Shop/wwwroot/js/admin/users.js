var app = new Vue({
    el: '#app',
    data: {
        username:  ""
    },
    mounted() {
        //TO DO get all users
    },
    methods: {
        createUser: function () {
            this.loading = true;
            axios.get("/users", { username: this.username })
                .then(res => {
                    console.log(res);
                })
                .catch(err => {
                    console.log(err);
                })
        }      
    },
});