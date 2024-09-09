const apiUrl = '/api/products';

async function fetchProducts() {
    try {
        const response = await axios.get(`${apiUrl}/getAll`);
        const products = response.data.data;
        const productList = document.getElementById('product-list');
        productList.innerHTML = '';

        products.forEach(product => {
            const productItem = document.createElement('div');
            productItem.innerHTML = `ID: ${product.productId}, Name: ${product.productName}, Category ID: ${product.categoryId}`;
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

    try {
        await axios.post(`${apiUrl}/add`, {
            productName: productName,
            categoryId: categoryId
        });
        fetchProducts();
        document.getElementById('add-product-form').reset();
    } catch (error) {
        console.error('Error adding product:', error);
    }
}

document.getElementById('add-product-form').addEventListener('submit', addProduct);

fetchProducts();
