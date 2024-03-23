const express = require('express')
const app = express()
const port = 8080

app.set("view engine", "ejs")
app.use(express.static("public"))
app.get("/", (req, res) => {
    res.render("home", { hoTen: 'Vinh', tuoi: 32 })
})
app.get("/login", (req, res) => {
    res.render("login")
})
app.get("/products", (req, res) => {
    let dssp = [
        { tenSP: 'IPHONE 15 PRO MAX', giaTien: 250000000 },
        { tenSP: 'IPAD PRO M2', giaTien: 210000000 }
    ]
    res.render("products", { dssp: dssp })
})
app.listen(port, () => {
    console.log(`Server da chay voi port ${port}`)
})