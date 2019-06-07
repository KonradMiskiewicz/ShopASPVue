var app = new Vue({
    el: '#app',
    data: {
        loading: false,
        objectindex: 0,
        productModel: {
            id: 0,
            name: "Product Name",
            description: "Product Description",
            value: 1.99
        },
        products: []
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
                });
        },
        editProducts: function (product, index) {
            this.objectindex = index;
            this.productModel = {
                id: product.id,
                name: product.name,
                description: product.description,
                value: product.value
            };
        },
        updateProduct: function () {
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
                });
        },
        deleteProduct: function (id, index) {
            this.loading = true;
            axios.delete("/Admin/products" + id)
                .then(res => {
                    console.log(res.data);
                    this.products.splice(index, 1, res.data);
                })
                .catch(err => {
                    console.log(err)
                })
                .then(() => {
                    this.loading = false;
                });
        }
    },
    computed: {
    }
});
