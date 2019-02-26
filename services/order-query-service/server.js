/* eslint-disable import/no-commonjs */

require('babel-register')({
    presets: [ 'env' ]
});

module.exports = require('./app.js');