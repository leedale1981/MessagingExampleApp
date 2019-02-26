/* eslint-disable no-console */
/* eslint-disable import/no-commonjs */

import express from 'express';
import OrderRoute from './routes/order-route';

const app = express();
const hostname = '127.0.0.1';
const port = 3000;

const router = express.Router();
const orderRoute = new OrderRoute(router)

app.use('orders', orderRoute.router)

app.listen(port, hostname, () => {    
    console.log(`MessagingExampleApp Query Service listening at ${hostname}:${port}`)
});