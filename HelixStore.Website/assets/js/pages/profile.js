const raw = {
    "invoiceDate": "2021-05-23T15:24:03",
    "invoiceRows": [
        {
            "productName": "Iphone 11",
            "amount": 1,
            "price": 20490000,
            "total": 20490000
        },
        {
            "productName": "iPad Pro 12.9",
            "amount": 1,
            "price": 31190000,
            "total": 31190000
        }
    ],
    "customerName": "Han Diep",
    "staffName": "Website User",
    "deliveryAddressRecipient": "Han Diep",
    "deliveryAddressAddress": "Quan 5",
    "deliveryAddressPhone": "9999999999",
    "provisionalAmount": 51680000,
    "discount": 0,
    "total": 51680000,
    "invoiceId": 0
}
const renderInvoiceHTML = (i) => {
    return `<div class="orders__content__item">
                <div class="orders__content__item__text">
                    <span>${i.invoiceDate}</span>
                </div>
                <div class="orders__content__item__text">
                    <span>${i.total}</span>
                </div>
                <div class="orders__content__item__button">
                    <span invoiceid="${i.invoiceId}" onclick="viewInvoice(this)">View</span>
                </div>
            </div>`
}
const GetInvoiceVMs = async () => {
    let _url = 'http://localhost:5000/api/Invoices/GetInvoiceVMs'
    return await axios({
        method: 'get',
        url: _url,
        params: {
            cus_id: JSON.parse(sessionStorage['userLogin']).customerId
        }
    }).then((res) => {
        sessionStorage['invoices'] = JSON.stringify(res.data)
        let result = ''
        res.data.forEach(i => {
            result += renderInvoiceHTML(i)
        })
        document.getElementById('orders__content').innerHTML = result
    })
        .catch(err => {
            sessionStorage['invoices'] = JSON.stringify([])
            document.getElementById('orders__content').innerHTML = ''
        })
}
GetInvoiceVMs()

const viewInvoice = (that) => {

    let _id = that.getAttribute("invoiceid")
    _invoice = JSON.parse(sessionStorage['invoices']).filter(i => i.invoiceId == _id)[0]

    document.getElementById('orders__detail__box__info').innerHTML = orders__detail__box__info__HTML(_invoice.invoiceDate, _invoice.customerName, _invoice.staffName)
    let tableHTML = ''
    _invoice.invoiceRows.forEach(r => {
        tableHTML += table__content__item__HTML(r.productName, r.amount, r.price, r.total)
    })
    document.getElementById('table__content').innerHTML = tableHTML

    document.getElementById('invoice__address').innerHTML = invoice__address__HTML(_invoice.deliveryAddressRecipient, _invoice.deliveryAddressAddress, _invoice.deliveryAddressPhone)
    document.getElementById('invoice__money').innerHTML = invoice__money__HTML(_invoice.provisionalAmount, _invoice.discount, _invoice.total)





    document.getElementById('orders__detail__box').style.display = 'block'
}

document.getElementById('close__box').addEventListener('click', () => {
    document.getElementById('orders__detail__box').style.display = 'none'
})

const orders__detail__box__info__HTML = (date, customer, staff) => {
    return `<h2>INVOICE</h2>

            <div>
                <span>Create Date</span>
                <span>${date}</span>
            </div>

            <div>
                <span>Customer</span>
                <span>${customer}</span>
            </div>
            <div>
                <span>Staff</span>
                <span>${staff}</span>
            </div>`
}

const table__content__item__HTML = (name, amount, price, total) => {
    return `<div class="table__content__item">
                <div>
                    ${name}
                </div>
                <div>
                    ${amount}
                </div>
                <div>
                    ${price}
                </div>
                <div>
                    ${total}
                </div>
            </div>`
}
const invoice__address__HTML = (Recipient, Address, Phone) => {
    return `<div>
                <span>Recipient</span>
                <span>${Recipient}</span>
            </div>
            <div>
                <span>Address</span>
                <span>${Address}</span>
            </div>
            <div>
                <span>Phone</span>
                <span>${Phone}</span>
            </div>`
}

const invoice__money__HTML = (Provisional, Discount, Total) => {
    return `<div>
                <span>Provisional Amount</span>
                <span>${Provisional}</span>
            </div>
            <div>
                <span>Discount</span>
                <span>${Discount}</span>
            </div>
            <div>
                <span>Total</span>
                <span>${Total}</span>
            </div>`
}