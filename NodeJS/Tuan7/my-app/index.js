const express = require('express')
const app = express()
const port = 8080

app.set('view engine', 'ejs')
app.use(express.static('public'))

app.get('/', (req, res) => {

})
app.get('/users', (req, res) => {
    let users = [
        {id: 1, username: 'admin', password: '123', avatar: '1.png'},
        {id: 2, username: 'customer', password: '456', avatar: '2.png'},
        {id: 3, username: 'customer', password: '456', avatar: '3.png'},
        {id: 4, username: 'customer', password: '456', avatar: '4.png'}
    ]
    res.render('users', {users : users})
})
app.get('/home', (req, res) => {
    res.render('home')
})
app.get('/users/:id', (req, res) => {
    let users = [
        {id: 1, username: 'admin', password: '123', avatar: '1.png'},
        {id: 2, username: 'customer', password: '456', avatar: '2.png'},
        {id: 3, username: 'customer', password: '456', avatar: '3.png'},
        {id: 4, username: 'customer', password: '456', avatar: '4.png'}
    ]
    let user = users.find(item => item.id == req.params.id)
    res.render('userDetails', {user : user})
})
app.listen(port, () => {
    console.log(`Server dang chay voi cong port ${port}`)
})