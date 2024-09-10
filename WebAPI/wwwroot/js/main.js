function loadProducts() {
    fetch('https://localhost:44382/api/products/getAll')
        .then(response => response.json())
        .then(data => {
            const productList = document.getElementById('product-list');
            productList.innerHTML = data.map(product => `<div>Product Name: ${product.productName}</div>`).join('');
            document.getElementById('order-list').innerHTML = '';
            document.getElementById('customer-list').innerHTML = '';
        });
}

function loadOrders() {
    fetch('https://localhost:44382/api/orders/getAll')
        .then(response => response.json())
        .then(data => {
            const orderList = document.getElementById('order-list');
            orderList.innerHTML = data.map(order => `<div>Order ID: ${order.orderId}</div>`).join('');
            document.getElementById('product-list').innerHTML = '';
            document.getElementById('customer-list').innerHTML = '';
        });
}

function loadCustomers() {
    fetch('https://localhost:44382/api/customers/getAll')
        .then(response => response.json())
        .then(data => {
            const customerList = document.getElementById('customer-list');
            customerList.innerHTML = data.map(customer => `<div>Company Name: ${customer.companyName}</div>`).join('');
            document.getElementById('product-list').innerHTML = '';
            document.getElementById('order-list').innerHTML = '';
        });
}
