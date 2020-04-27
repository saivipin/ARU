import { Component, OnInit } from '@angular/core';
import { ARUService } from '../service/service'

@Component({
    selector: 'customers',
    templateUrl: './customers.component.html'
})
export class CustomersComponent implements OnInit {

    customers: any[] = [];

    constructor(
        private _ARUService: ARUService,
    ) {

    }

    ngOnInit() {
        this.loadCustomer();
    }

    private loadCustomer() {
        this._ARUService.getCustomers().subscribe(res => {
            console.log(res);
            this.customers = res;
        });
    }
}
