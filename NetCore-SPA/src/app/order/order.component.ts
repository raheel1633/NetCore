import { Component, OnInit } from '@angular/core';
import { HttpClient } from '../../../node_modules/@angular/common/http';


@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {
  orders: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getOrders();
  }

  getOrders() {
    this.http.get('http://localhost:5000/api/orders').subscribe(response => {
    this.orders = response;
    }, error => {
      console.log(error);
    });
  }

}
