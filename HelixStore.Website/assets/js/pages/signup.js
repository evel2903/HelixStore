const axios = window.axios

const CreateAccount = async () => {
    let _name = document.getElementById('fullname').value
    let _gender = document.getElementById('gender').checked == true ? 'Male' : 'Female'
    let _phone = document.getElementById('phone').value

    if (_name.length == 0 || _phone.length == 0) {
        console.log('Enter your information');
        return
    }

    let _url = `http://localhost:5000/api/Users/Signup`

    await axios({
        method: 'post',
        url: _url,
        params: {
            fullname: _name,
            gender: _gender,
            phone: _phone
        }
    })
        .then(res => {
            alert(`Successful, Login with password '123456'`)
            window.location = "../../../views/account/login.html"
        })
        .catch(err => {
            alert("Error connecting to server")
        });
}
document.getElementById('signup').addEventListener('click', () => {
    CreateAccount()
})