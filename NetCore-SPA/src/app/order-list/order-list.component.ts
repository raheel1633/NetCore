import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { OrderService } from '../_services/order.service';
import { Order } from '../_models/order';
import { AlertifyService } from '../_services/alertify.service';
import { PaginatedResult, Pagination } from '../_models/pagination';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.css']
})
export class OrderListComponent implements OnInit {

orders: Order[];
 pagination: Pagination;

pageNumber = 1;
pageSize = 15;

  constructor(private http: HttpClient, private orderService: OrderService, private alertify: AlertifyService) { }

  ngOnInit() {
    console.log('ngOnInit');
    this.getOrders(this.pageNumber, this.pageSize);
  }
  getOrders(pageNumber, pageSize) {
    // this.orderService.getOrders(this.pageNumber, this.pageSize).subscribe((orders: Order[]) => {
    //   this.orders = orders;
    // }, error => {
    //   this.alertify.error(error);
    // });
    this.orderService.getOrders(pageNumber, pageSize).subscribe((data: PaginatedResult<Order[]>) => {
      console.log(data, 'data');
      this.orders = data.result;
      this.pagination = data.pagination;
    }, error => {
      this.alertify.error(error);
    });
  }
  pageChanged(event: any): void {
    console.log('pageChangedEvent');
    this.pagination.currentPage = event.page;
    this.getOrders(this.pagination.currentPage, this.pagination.itemsPerPage);
  }
}
