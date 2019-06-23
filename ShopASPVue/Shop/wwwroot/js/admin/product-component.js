Vue.component('product-manager', {
    template: `<div v-if="!editing">
                    <button class="button is-success" @click="newProduct">Create Product</button>
                    <table class="table">
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Value</th>
                            <th></th>
                            <th></th>
                        </tr>
                        <tr v-for="(product, index) in products">
                            <td>{{product.id}}</td>
                            <td>{{product.name}}</td>
                            <td>{{product.value}}</td>
                            <td><a @click="editProduct(product.id, index)">Edit</a></td>
                            <td><a @click="deleteProduct(product.id)">Delete</a></td>
                        </tr>
                    </table>
                </div>

                <div v-else>
                    <div class="field">
                        <label class="label">Product name</label>
                        <div class="control">
                            <input class="input" v-model="productModel.name" />
                        </div>
                    </div>
                    <div class="field">
                        <label class="label">Product description</label>
                        <div class="control">
                            <input class="input" v-model="productModel.description" />
                        </div>
                    </div>
                    <div class="field">
                        <label class="label">Product value</label>
                        <div class="control">
                            <input class="input" v-model="productModel.value" />
                        </div>
                    </div>
                    <button class="button is-success" @click="createProduct" v-if="!productModel.id">Create Product</button>
                    <button class="button is-warning" @click="updateProduct" v-else>Update</button>
                    <button class="button is-warning" @click="cancel">Cancel</button>
                </div>`,
    data() {
        return {
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
        }
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
        //removing random
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