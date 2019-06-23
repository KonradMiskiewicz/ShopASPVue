﻿var app = new Vue({
    el: '#app',
    data: {
        products: [],
        selectedProduct: null,
        newStock: {
            productId: 0,
            description: "Size",
            quality: 10
        }
    },
    mounted() {
        this.getStock();
    },
    methods: {
        getStock: function () {
            this.loading = true;
            axios.get("/Admin/stocks")
                .then(res => {
                    console.log(res);
                    this.products = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                })
        },
        selectProduct: function (product) {
            this.selectedProduct = product;
            this.newStock.productId = product.id;
        },
        updateStock: function () {
            this.loading = true;
            axios.put("/Admin/stocks", {
                stock: this.selectedProduct.stock.map(x => {
                    return {
                        id: x.id,
                        description: x.description,
                        quality: x.quality,
                        productId: this.selectedProduct.id
                    };
                })
            })
                .then(res => {
                    console.log(res);
                    this.selectedProduct.stock.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                })
        },
        addStock: function () {
            this.loading = true;
            axios.post("/Admin/stocks", this.newStock)
                .then(res => {
                    console.log(res);
                    this.selectedProduct.stock.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                })

        },
        deleteStock: function (id, index) {
            this.loading = true;
            axios.delete("/Admin/stocks/" + id)
                .then(res => {
                    console.log(res);
                    this.selectedProduct.stock.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                })

        }

    },
});