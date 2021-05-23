const showMenu = (that) => {
    let subMenuElement = that.parentElement.children[1];
    if (subMenuElement.classList.contains('menu--hide')) {
        subMenuElement.classList.remove('menu--hide')
    }
    else {
        subMenuElement.classList.add('menu--hide')
    }
};

//show item in dropdown account
let signup_link = document.getElementById('signup--link')
let login_link = document.getElementById('login--link')
let detail_link = document.getElementById('detail--link')
let logout_link = document.getElementById('logout--link')
logout_link.style = `cursor:pointer;`
if (sessionStorage['userLogin'] != undefined) {
    signup_link.style.display = 'none'
    login_link.style.display = 'none'
    detail_link.style.display = 'flex'
    logout_link.style.display = 'flex'
}
else {
    signup_link.style.display = 'flex'
    login_link.style.display = 'flex'
    detail_link.style.display = 'none'
    logout_link.style.display = 'none'
}
logout_link.addEventListener('click', () => {
    sessionStorage.removeItem("userLogin")
    sessionStorage.removeItem("address_selected")
    sessionStorage.removeItem("carts")
    sessionStorage.removeItem("products")
    sessionStorage.removeItem("address")
    sessionStorage.removeItem("totalPrice")

    window.location = "../../index.html"
})

const changeCartAmount = () => {
    let amount = JSON.parse(sessionStorage['carts'] == undefined ? '[]' : sessionStorage['carts']).length
    document.getElementById('cart--amount').innerHTML = amount
}
changeCartAmount()