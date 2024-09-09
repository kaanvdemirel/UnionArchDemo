﻿const apiUrl = '/api/products';

async function fetchProducts() {
    try {
        const response = await axios.get(`${apiUrl}/getAll`);
        const products = response.data.data;
        const productList = document.getElementById('product-list');
        productList.innerHTML = '';

        products.forEach(product => {
            const productItem = document.createElement('div');
            productItem.innerHTML = `
                ID: ${product.productId}, 
                Name: ${product.productName}, 
                Category ID: ${product.categoryId}, 
                Unit Price: ${product.unitPrice}, 
                Units In Stock: ${product.unitsInStock}
            `;
            productList.appendChild(productItem);
        });
    } catch (error) {
        console.error('Error fetching products:', error);
    }
}

async function addProduct(event) {
    event.preventDefault();
    const productName = document.getElementById('product-name').value;
    const categoryId = document.getElementById('category-id').value;
    const unitPrice = document.getElementById('unitPrice-id').value;
    const unitsInStock = document.getElementById('unitsInStock-id').value;

    try {
        await axios.post(`${apiUrl}/add`, {
            productName: productName,
            categoryId: categoryId,
            unitPrice: unitPrice,
            unitsInStock: unitsInStock
        });
        fetchProducts();
        document.getElementById('add-product-form').reset();
    } catch (error) {
        console.error('Error adding product:', error);
    }
}

async function updateProduct(event) {
    event.preventDefault();
    const productId = document.getElementById('update-product-id').value;
    const productName = document.getElementById('update-product-name').value;
    const categoryId = document.getElementById('update-category-id').value;
    const unitPrice = document.getElementById('update-unitPrice-id').value;
    const unitsInStock = document.getElementById('update-unitsInStock-id').value;

    try {
        await axios.post(`${apiUrl}/update`, {
            productId: productId,
            productName: productName,
            categoryId: categoryId,
            unitPrice: unitPrice,
            unitsInStock: unitsInStock
        });
        fetchProducts();
        document.getElementById('update-product-form').reset();
    } catch (error) {
        console.error('Error updating product:', error);
    }
}

async function deleteProduct(productId, productName) {
    try {
        await axios.post(`${apiUrl}/delete`, {
            productId: productId,
            productName: productName
        });
        fetchProducts();
    } catch (error) {
        console.error('Error deleting product:', error);
    }
}

document.getElementById('add-product-form').addEventListener('submit', addProduct);
document.getElementById('update-product-form').addEventListener('submit', updateProduct);
document.getElementById('delete-product-form').addEventListener('submit', function (event) {
    event.preventDefault();
    const productId = document.getElementById('delete-product-id').value;
    const productName = document.getElementById('delete-product-name').value;
    deleteProduct(productId, productName);
});

fetchProducts();
