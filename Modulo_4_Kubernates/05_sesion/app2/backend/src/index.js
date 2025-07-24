require('dotenv').config();
const express = require('express');
const mongoose = require('mongoose');
const cors = require('cors');

const app = express();

const port = process.env.PORT || 3000;

app.use(cors());
app.use(express.json);

mongoose.connect('mongodb://localhost:27017/myappdb', {
    useNewUrlParser: true,
    useUnifiedTopology: true
})
.then (()=> console.log('Conectando a MongoDB'))
.catch(err => console.error('Error al conectar a MongoDB', err));


const itemRouter = require('./routes/items');
app.use('/api/items', itemRouter);

app.listen(port,() => console.log('API corriendo en http://localhost:'+ port));