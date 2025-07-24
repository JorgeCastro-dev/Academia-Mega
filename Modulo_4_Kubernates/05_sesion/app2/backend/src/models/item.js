const {Schema, model} = require('mongoose');

const itemSchema = new Schema({
    name: {type: String, requiere: true},
    price: {type: Number, require: true}
});

module.exports = model('Item', itemSchema);