const express = require('express');
const app = express();
const port = 3000;
const mysql = require('mysql');
const connection = require('./connection')
app.set('view engine', 'ejs');
app.use(express.static('public'));
app.use(express.urlencoded());

app.get('/accounts', (req, res) => {
    let conn = connection.create()
    conn.connect();

    conn.query('SELECT * FROM accounts', (err, result) => {
        if (err) throw err;
        res.render('accounts', { accounts: result });
    });

    conn.end();
});

app.get('/accounts/detail/:id', (req, res) => {
    let conn = connection.create()
    conn.connect()

    let sql = `SELECT * FROM accounts WHERE Id = ?`
    let params = [req.params.id]
    conn.query(sql, params, (err, result) => {
        if(err) throw err
        res.render('accountDetail', {account : result[0]})
    })

    conn.end()
})
app.post('/accounts/delete/:id', (req, res) => {
    let conn = connection.create()
    conn.connect()

    let sql = `DELETE FROM accounts WHERE Id = ?`
    let params = [req.params.id]
    conn.query(sql, params, (err, result) => {
        if(err) throw err
        if(result.affectedRows > 0) {
            res.redirect('/accounts')
        }
    })
    
    conn.end()
})
app.get('/login', (req, res) => {
    res.render('login', { msg: '' });
});

app.post('/login', (req, res) => {
    let conn = connection.create()

    conn.connect();

    let sql = 'SELECT * FROM accounts WHERE Username=?'
    let params = [req.body.username]
    conn.query(sql, params, (err, result) => {
        if (err) throw err;
        if (result.length == 0 || result[0].Password != req.body.password) {
            res.render('login', { msg: 'Đăng nhập thất bại' });
        }
        else {
            res.redirect('/accounts');
        }
    });

    conn.end();
});

app.listen(port, () => {
    console.log(`Server đã chạy với port ${port}`);
});