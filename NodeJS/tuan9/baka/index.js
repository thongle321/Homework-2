const express = require('express');
const app = express();
const port = 8080;

app.set('view engine', 'ejs');

app.use(express.static('public'));

const employees = [
    {
        id: 1349, firstName: 'Nguyễn Văn', lastName: 'An',
        Luong: 2500000, coefficient: 4.6, avatar: '1349.png'
    },
    {
        id: 1825, firstName: 'Trần Thanh', lastName: 'Bình',
        Luong: 1490000, coefficient: 6.5, avatar: '1825.png'
    },
    {
        id: 2230, firstName: 'Lê Hoàng', lastName: 'Chinh',
        Luong: 2250000, coefficient: 7.0, avatar: '2230.png'
    },
    {
        id: 4861, firstName: 'Nguyễn Ngọc', lastName: 'Duy',
        Luong: 1830000, coefficient: 3.8, avatar: '4861.png'
    },

];

app.get('/employees', (req, res) => {
    res.render('employees', { employees: employees });
});

app.get('/employees/:id', (req, res) => {
    const employee = employees.find(emp => emp.id === parseInt(req.params.id));
    res.render('employeeDetail', { employee: employee });

});
app.get('/accounts/login', (req, res) => {
    res.render('login', { msg: '' });
});
app.listen(port, () => {
    console.log(`Server đã chạy với port ${port}`);
});