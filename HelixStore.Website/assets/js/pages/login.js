const axios = window.axios

const CreateAccount = async () => {
    let _phone = document.getElementById('phone').value
    let _password = document.getElementById('password').value

    if (_password.length == 0 || _phone.length == 0) {
        alert('Enter your information')
        return
    }

    let _url = `http://localhost:5000/api/Users/Login`

    await axios({
        method: 'post',
        url: _url,
        params: {
            phone: _phone,
            password: _password
        }
    })
        .then(res => {

            let user = res.data
            sessionStorage.setItem('userLogin', JSON.stringify(user))
            window.location = '../../../index.html'

        })
        .catch(err => {
            alert("Wrong login information")
        });
}
document.getElementById('login').addEventListener('click', () => {
    CreateAccount()
})