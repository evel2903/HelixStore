let products = sessionStorage['products'] == undefined ? [] : JSON.parse(sessionStorage['products'])
let carts = sessionStorage['carts'] == undefined ? [] : JSON.parse(sessionStorage['carts'])

const renderCartItemHTML = (prod_id, amount) => {
    const product = products.filter(p => p.productId == prod_id)[0]
    return `<div class="cart__item">
                <div class="cart__item__img">
                    <img src="http://localhost:5000/api/Products/image/${product.productId}/${product.productImg}"
                        alt="">
                </div>
                <div class="cart__item__name">
                    <p>${product.productName}</p>
                </div>
                <div class="cart__item__amount">
                    <div><span>Amount</span></div>
                    <input productid="${product.productId}" type="number" min="1" max="${product.productAmount}" value="${amount}" onchange="changePrdAmount(this)">
                </div>
                <div class="cart__item__price">
                    <div><span>Price</span></div>
                    <span>${product.productPrice}</span>
                </div>
                <div class="cart__item__total">
                    <div><span>Total</span></div>
                    <span>${Number(amount) * Number(product.productPrice)}</span>
                </div>
                <div class="cart__item__del">
                    <button productid="${product.productId}" onclick="delInCart(this)">
                        <i class='bx bx-trash-alt'></i>
                    </button>
                </div>
            </div>`
}
const changePrdAmount = (that) => {
    let change_id = that.getAttribute("productid")
    let _amount = that.value
    carts.forEach(c => {
        if (c.prd_id == change_id) {
            c.amount = _amount
            totalPrice()
            updateCartStore()
            return
        }
    });

    that.parentElement.parentElement.children[4].children[1].textContent = Number(that.parentElement.parentElement.children[3].children[1].textContent) * Number(_amount)
}
const updateCartStore = () => {
    sessionStorage.setItem('carts', JSON.stringify(carts))
    changeCartAmount()
}
const delInCart = (that) => {
    let del_id = that.getAttribute("productid")
    carts.forEach(c => {
        if (c.prd_id == del_id) {
            carts.splice(carts.indexOf(c), 1)
            renderCart()
            totalPrice()
            updateCartStore()
            return
        }
    });
}
const totalPrice = () => {
    let result = 0;
    carts.forEach(c => {
        //result += renderCartItemHTML(c.prd_id, c.amount)
        const product = products.filter(p => p.productId == c.prd_id)[0]
        result += Number(c.amount) * Number(product.productPrice)


    });
    sessionStorage['totalPrice'] == undefined ? sessionStorage.setItem('totalPrice', result) : sessionStorage['totalPrice'] = result
    document.getElementById('total--price').innerHTML = result
}
totalPrice()
const renderCart = () => {
    let result = ''
    carts.forEach(c => {
        result += renderCartItemHTML(c.prd_id, c.amount)
    });
    document.getElementById('cart--list').innerHTML = result
}

renderCart()






document.getElementById('checkout--btn').addEventListener('click', () => {
    if (sessionStorage['userLogin'] == undefined) {
        window.location = '../../../views/account/login.html'
    }
    else {
        window.location = '../../../checkout.html'
    }
})
