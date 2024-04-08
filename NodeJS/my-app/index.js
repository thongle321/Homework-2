const express = require('express');
const app = express();

const path =require('path');

app.set('view engine', 'ejs');

app.use(express.static('public'));

app.get('/employees',(req,res)=>{
    let employees = [
    {id:1349, firstName:'Nguyễn Văn', lastName:'An',
     salary:2500000, coefficient:4.6, avatar: '1349.jpg'},
     {id:1825, firstName:'Trần Thanh', lastName:'Bình',
     salary:1490000, coefficient:6.5,avatar: '1825.jpg'},
     {id:2230, firstName:'Lê Hoàng', lastName:'Chinh',
     salary:2250000, coefficient:7.0,avatar: '2230.jpg'},
     {id:4861, firstName:'Nguyễn Ngọc', lastName:'Duy',
     salary:1830000, coefficient:3.8,avatar: '4861.jpg'},
    ]
    res.render('employees',{employees :employees});
});



app.get('/employees/:id', (req, res) => {
    const employee = employees.find(emp => emp.id === parseInt(req.params.id));
    res.render('employeeDetail', { employee:employee });
    
});

app.get('/accounts/login', (req, res) => {
    res.render('login',{msg:''});
});
app.listen(3000, () => {
    console.log(`Server đã chạy với port 3000`);
});