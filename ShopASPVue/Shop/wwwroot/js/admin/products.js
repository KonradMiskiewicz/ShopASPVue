var app = new Vue({
    el: '#app',
    data: {
            menu: 0,
            loading: false,
            editing: false,
            objectindex: 0,
            productModel: {
                id: 0,
                name: "Product Name",
                description: "Product Description",
                value: 1.99
            },
            products: []
    },
    mounted: function () {
        this.getProducts();
    },
    methods: {
        getProducts: function () {
            this.loading = true;
            axios.get("/Admin/products")
                .then(res => {
                    console.log(res);
                    this.products = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getProduct: function (id) {
            axios.get("/Admin/products/" + id)
                .then(res => {
                    console.log(res);
                    var product = res.data;
                    this.productModel = {
                        id: product.id,
                        name: product.name,
                        description: product.description,
                        value: product.value
                    };

                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createProduct: function () {
            this.loading = true;
            axios.post("/Admin/products", this.productModel)
                .then(res => {
                    console.log(res.data);
                    this.products.push(res.data);
                })
                .catch(err => {
                    console.log(err)
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        editProduct: function (id, index) {
            this.objectindex = index;
            this.getProduct(id);
            this.editing = true;
        },
        updateProduct: function () {
            this.loading = true;
            axios.put("/Admin/products", this.productModel)
                .then(res => {
                    console.log(res.data);
                    this.products.splice(this.objectindex, 1, res.data);
                })
                .catch(err => {
                    console.log(err)
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        //removing random after refresh removing correct id
        deleteProduct: function (id, index) {
            this.loading = true;
            axios.delete("/Admin/products/" + id)
                .then(res => {
                    console.log(res.data);
                    this.products.splice(index, 1);
                })
                .catch(err => {
                    console.log(err)
                })
                .then(() => {
                    this.loading = false;
                });
        },
        cancel: function () {
            this.editing = false;
        },
        newProduct: function () {
            this.editing = true;
            this.productModel.id = 0;
        }
    },
    computed: {
    }
});
