const express = require('express');
const app = express();
const port = 8080;
const connection = require('./connection');

app.set('view engine', 'ejs');
app.use(express.static('public'));
app.use(express.urlencoded());

app.get('/accounts', (req, res) => {
    let conn = connection.create();
    conn.connect();

    conn.query('SELECT * FROM accounts', (err, result) => {
        if (err) throw err;
        res.render('accounts', { accounts: result });
    });

    conn.end();
});

app.get('/accounts/detail/:id', (req, res) => {
    let conn = connection.create();
    conn.connect();

    let sql = 'SELECT * FROM accounts WHERE Id=?';
    let params = [req.params.id];
    conn.query(sql, params, (err, result) => {
        if (err) throw err;
        if (result.length > 0) {
            res.render('accountDetail', { account: result[0] });
        }
        else {
            res.render('NoPage');
        }
    });

    conn.end();
});

app.get('/accounts/add', (req, res) => {
    res.render('accountAdd');
});

app.post('/accounts/add', (req, res) => {
    let conn = connection.create();
    conn.connect();

    let sql = 'INSERT INTO accounts (Username, Password, Email, Phone, FullName) VALUES (?, ?, ?, ?, ?)';
    let params = [req.body.username, req.body.password, req.body.email, req.body.phone, req.body.fullName];
    conn.query(sql, params, (err, result) => {
        if (err) throw err;
        if (result.affectedRows == 1) {
            res.redirect('/accounts');
        }
    });

    conn.end();
});

app.get('/accounts/edit/:id', (req, res) => {
    let conn = connection.create();
    conn.connect();

    let sql = 'SELECT * FROM accounts WHERE Id=?';
    let params = [req.params.id];
    conn.query(sql, params, (err, result) => {
        if (err) throw err;
        if (result.length > 0) {
            res.render('accountEdit', { account: result[0] });
        }
        else {
            res.render('NoPage');
        }
    });

    conn.end();
});

app.post('/accounts/edit/:id', (req, res) => {
    let conn = connection.create();
    conn.connect();

    let sql = 'UPDATE accounts SET Username=?, Email=?, Phone=?, FullName=? WHERE Id=?';
    let params = [req.body.username, req.body.email, req.body.phone, req.body.fullName, req.params.id];
    conn.query(sql, params, (err, result) => {
        if (err) throw err;
        if (result.affectedRows == 1) {
            res.redirect('/accounts');
        }
    });

    conn.end();
});

app.post('/accounts/delete/:id', (req, res) => {
    let conn = connection.create();
    conn.connect();

    let sql = 'DELETE FROM accounts WHERE Id=?';
    let params = [req.params.id];
    conn.query(sql, params, (err, result) => {
        if (err) throw err;
        if (result.affectedRows == 1) {
            res.redirect('/accounts');
        }
    });
});

app.listen(port, () => {
    console.log(`Server đã chạy với port ${port}`);
});