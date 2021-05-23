const axios = window.axios

const getAllProducts = async () => {
    let _url = `http://localhost:5000/api/Products`
    return await axios({
        method: 'get',
        url: _url
    })
        .then(res => {
            return res.data
        })
        .catch(err => {
            alert("Error connecting to server")
        });
}

if (sessionStorage['products'] == undefined) {
    getAllProducts().then(res => {
        sessionStorage.setItem('products', JSON.stringify(res))
    })
}



const getProductsByTypeId = async (id) => {
    let _url = `http://localhost:5000/api/Products/type/${id}`
    return await axios({
        method: 'get',
        url: _url
    })
        .then(res => {
            return res.data
        })
        .catch(err => {
            alert("Error connecting to server")
        });
}
const getImgSrc = (productId, imgFileName) => {
    return `C:/Users/evell/Desktop/2-2020-2021/XDPMPL/HelixStore/HelixStore.Data/Images/${productId}/${imgFileName}`
}
const renderProductHTML = (product) => {
    return `<div class="product__item">
                <img src="http://localhost:5000/api/Products/image/${product.productId}/${product.productImg}"
                    alt="product__img">

                <a href="detail.html" class="product__item__link">${product.productName}</a>

                <span class="product__item__price">${product.productPrice}</span>

                <button productid="${product.productId}" class="product__item__addcart" onclick="addToCart(this)">
                    <i class='bx bxs-cart-add'></i>
                </button>
            </div>`
}


const addToCart = (that) => {
    if (sessionStorage['carts'] == undefined) {
        let data = {
            prd_id: that.getAttribute("productid"),
            amount: 1
        }
        sessionStorage.setItem('carts', JSON.stringify([data]))
    }
    else {
        let data = {
            prd_id: that.getAttribute("productid"),
            amount: 1
        }
        sessionStorage['carts'] = JSON.stringify([...JSON.parse(sessionStorage['carts']), data])
    }
    alert('Success!!');
    changeCartAmount()
}


