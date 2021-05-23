const previousButton = document.getElementById("previous")
const nextButton = document.getElementById("next")
const submitButton = document.getElementById('validate')
const form = document.getElementById('stepByStepForm')
const dots = document.getElementsByClassName('progress-bar__dot')
const numberOfSteps = 3
let currentStep = 1

for (let i = 0; i < dots.length; ++i) {
    dots[i].addEventListener('click', () => {
        goToStep(i + 1)
    })
}

previousButton.onclick = goPrevious
nextButton.onclick = goNext


function goNext(e) {
    e.preventDefault()
    currentStep += 1
    goToStep(currentStep)
}

function goPrevious(e) {
    e.preventDefault()
    currentStep -= 1
    goToStep(currentStep)
}

function goToStep(stepNumber) {
    currentStep = stepNumber

    let inputsToHide = document.getElementsByClassName('step')
    let inputs = document.getElementsByClassName(`step${currentStep}`)
    let indicators = document.getElementsByClassName('progress-bar__dot')

    for (let i = indicators.length - 1; i >= currentStep; --i) {
        indicators[i].classList.remove('full')
    }

    for (let i = 0; i < currentStep; ++i) {
        indicators[i].classList.add('full')
    }

    //hide all input
    for (let i = 0; i < inputsToHide.length; ++i) {
        hide(inputsToHide[i])
    }

    //only show the right one
    for (let i = 0; i < inputs.length; ++i) {
        show(inputs[i])
    }

    //if we reached final step
    if (currentStep === numberOfSteps) {
        enable(previousButton)
        disable(nextButton)
        show(submitButton)
    }

    //else if first step
    else if (currentStep === 1) {
        disable(previousButton)
        enable(next)
        hide(submitButton)
    }

    else {
        enable(previousButton)
        enable(next)
        hide(submitButton)
    }
}

function enable(elem) {
    elem.classList.remove("disabled");
    elem.disabled = false;
}

function disable(elem) {
    elem.classList.add("disabled");
    elem.disabled = true;
}

function show(elem) {
    elem.classList.remove('hidden')
}

function hide(elem) {
    elem.classList.add('hidden')
}

document.getElementById('delivery--address--new').addEventListener('click', () => {
    let _form = document.getElementById('f-new-address')
    if (_form.classList.contains('f-new-address')) {
        _form.classList.remove('f-new-address')
    }
    else {
        _form.classList.add('f-new-address')
    }
})

//Logic
const newDeliveryAddress = async () => {

    let _name = document.getElementById('new--address--name').value
    let _address = document.getElementById('new--address--address').value
    let _phone = document.getElementById('new--address--phone').value

    if (_name.length == 0 || _address.length == 0 || _phone.length == 0) {
        alert('Enter your information')
        return
    }

    let id = JSON.parse(sessionStorage['userLogin']).customerId
    let _url = `http://localhost:5000/api/Users/Address/New/${id}`

    return await axios({
        method: 'get',
        url: _url,
        params: {
            name: _name,
            address: _address,
            phone: _phone
        }
    })
        .then(res => {
            alert('Success!')

            getDeliveryAddress()
            window.location.reload();
            loadAddress()

        })
}
document.getElementById('new--address--save').addEventListener('click', () => { newDeliveryAddress() })

const getDeliveryAddress = async () => {
    let id = JSON.parse(sessionStorage['userLogin']).customerId
    let _url = `http://localhost:5000/api/Users/Address/${id}`
    return await axios({
        method: 'get',
        url: _url
    })
        .then(res => {
            sessionStorage['address'] = JSON.stringify(res.data)
            loadAddress()
        })
        .catch(err => {
            sessionStorage['address'] = JSON.stringify([])
        });
}
getDeliveryAddress()

const select_address = document.getElementById('delivery--address')
select_address.addEventListener('change', () => {
    sessionStorage['address_selected'] = select_address.value
})

const loadAddress = () => {
    let result = ''
    let address = JSON.parse(sessionStorage['address'])
    if (address.length == 0) {
        result = ''
        return
    }
    else {
        sessionStorage['address_selected'] = address[0].deliveryAddressId
        address.forEach(a => {
            result += `<option value="${a.deliveryAddressId}">${a.deliveryAddressRecipient} - ${a.deliveryAddressPhone} - ${a.deliveryAddressAddress}</option>`
        })
    }
    select_address.innerHTML = result
}

loadAddress()

//Products

const renderRowProductHTML = (prod_id, amount) => {
    const products = JSON.parse(sessionStorage['products'])
    const product = products.filter(p => p.productId == prod_id)[0]
    return `<div class="input-group-product">
                <label>${product.productName}</label>
                <label> * </label>
                <label>${amount}</label>
                <label> = </label>
                <label>${Number(product.productPrice) * Number(amount)}</label>
            </div>`
}
const renderTotalProductHTML = () => {
    return `<div class="input-group-total">
                <label>Total: </label>
                <label>${sessionStorage['totalPrice']}</label>
                <label>VND</label>
            </div>`
}

const renderTable = () => {
    const carts = JSON.parse(sessionStorage['carts'])
    let result = ''
    carts.forEach(c => {
        result += renderRowProductHTML(c.prd_id, c.amount)
    });

    result += renderTotalProductHTML()
    document.getElementById('f2--product').innerHTML = result
}
renderTable()

//submit
submitButton.addEventListener('click', () => {

    const carts = JSON.parse(sessionStorage['carts'])
    const products = JSON.parse(sessionStorage['products'])

    let invoice = {
        "invoiceId": 0,
        "invoiceDate": new Date().toUTCString(),
        "invoiceProvisionalAmount": sessionStorage['totalPrice'],
        "invoiceDiscount": 0,
        "invoiceTotal": sessionStorage['totalPrice'],
        "deliveryAddressId": sessionStorage['address_selected'],
        "customerId": JSON.parse(sessionStorage['userLogin']).customerId,
        "staffId": 16,
    }

    let invoiceDetails = []

    carts.forEach(c => {
        const product = products.filter(p => p.productId == c.prd_id)[0]
        let invoiceDetail = {
            "invoiceDetailId": 0,
            "invoiceDetailAmount": c.amount,
            "invoiceDetailTotal": Number(product.productPrice) * Number(c.amount),
            "invoiceId": 0,
            "productId": c.prd_id
        }
        invoiceDetails.push(invoiceDetail)
    });
    createInvoice(invoice, invoiceDetails)


})

const createInvoice = async (invoice, invoiceDetails) => {
    let _url = 'http://localhost:5000/api/Invoices/Create'
    return await axios({
        method: 'post',
        url: _url,
        params: {
            invoiceJson: JSON.stringify(invoice),
            invoiceDetailsJson: JSON.stringify(invoiceDetails)
        },
    }).then((res) => {

        sessionStorage.removeItem("address_selected")
        sessionStorage.removeItem("carts")
        sessionStorage.removeItem("address")
        sessionStorage.removeItem("totalPrice")
        alert('Thank you for getting in touch!')

    }).catch((err) => {
        sessionStorage.removeItem("address_selected")
        sessionStorage.removeItem("carts")
        sessionStorage.removeItem("address")
        sessionStorage.removeItem("totalPrice")
        alert('Thank you for getting in touch!')
        window.location = '../../../views/account/profile.html'
    });
}


