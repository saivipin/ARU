import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule }   from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {MenuComponent}from './shared/menu/menu.component'
import { DashboardComponent } from './dashboard/dashboard.component'
import {InventoryComponent} from './Inventory/Inventory.component'
import { CustomersComponent } from './customers/customers.component'

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    DashboardComponent,
    InventoryComponent,
    CustomersComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
