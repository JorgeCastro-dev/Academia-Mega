const express = require('express');

const app = express();

const PORT = process.env.PORT || 3000;

app.get('/', (req, res) => {
    res.send("Saludos desde Docker. Att. Jorge Castro")
});

app.listen(PORT, () => {
    console.log(`Servidor de node escuchando en el puerto ${PORT}`)
})