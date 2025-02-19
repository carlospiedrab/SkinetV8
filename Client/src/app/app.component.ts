import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from "./layout/header/header.component";
import { Product } from './shared/models/product';
import { Pagination } from './shared/models/pagination';
import { ShopService } from './core/services/shop.service';
import { ShopComponent } from "./features/shop/shop.component";
import { FiltersDialogComponent } from "./features/shop/filters-dialog/filters-dialog.component";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, HeaderComponent, ShopComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent  {
title = 'Skinet';

}
