import { Component, OnInit } from '@angular/core';
import { ARUService } from '../service/service'
import { inventory } from '../models/arumodels'
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
declare var $: any;
@Component({
  selector: 'inventory',
  templateUrl: './inventory.component.html'
})
export class InventoryComponent implements OnInit {

  inventories: any[] = [];
  inventoryForm: FormGroup;

  constructor(
    private _ARUService: ARUService,
    private fb: FormBuilder
  ) {

    this.buildForm();
  }

  ngOnInit() {
    this.loadinventory();
  }

  private buildForm(): void {
    this.inventoryForm = this.fb.group({
      productname: [null, Validators.required],
      model: [null, Validators.required],
      price: [null, Validators.required]
    });
  }

  private loadinventory() {
    this._ARUService.getInventory().subscribe(res => {
      this.inventories = res;
      console.log(this.inventories);
    }
    );
  }
  private addinventory() {
    console.log(this.inventoryForm);

    var inv = {
      'name': this.inventoryForm.value.productname,
      'model': this.inventoryForm.value.model,
      'price': this.inventoryForm.value.price
    };

    console.log(inv);
    this.inventories = [inv, ...this.inventories];
    console.log(this.inventories);
    this.buildForm();
    $('#inventoryModal').modal('hide');
  }
}
