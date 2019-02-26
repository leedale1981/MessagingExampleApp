/* eslint-disable class-methods-use-this */
export default class OrderRoute {

    constructor(router) {
        router.get('/', (req, res) => {
            this.searchOrders(req, res);
        });
    }

    searchOrders(req, res) {
        res.send('Searched for orders');
    }
}