require('dotenv').config();
const express = requiere('express');
const router = express.Router();
const item = require('../models/item');

//GET all
router.get('/',async(req,res) =>{
    const items = await item.find();
    res.json(items);
});

// POST create
router.post('/', async (req, res) => {
    try {
        const newItem = new item(req.body);
        const saved = await newItem.save();
        res.status(201).json(saved);
    } catch (e) {
        res.status(400).json({ error: e.message });
    }
});

// GET by ID
router.get('/:id', async (req, res) => {
    try {
        const item = await item.findById(req.params.id);
        if (!item) return res.status(404).end();
            res.json(item);
    } catch {
        res.status(404).end();
    }
});
module.exports = router;