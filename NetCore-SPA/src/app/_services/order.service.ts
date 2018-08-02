import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from '../../../node_modules/rxjs';
import { Order } from '../_models/order';
import { PaginatedResult } from '../_models/pagination';
import { map } from '../../../node_modules/rxjs/operators';

// const httpOptions = {
//   headers: new HttpHeaders({
//     'Authorization': 'Bearer ' + localStorage.getItem('token')
//   })
// };

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getOrders(page?, pageSize?): Observable<PaginatedResult<Order[]>> {
    console.log(page, pageSize);
    const paginatedResult: PaginatedResult<Order[]> = new PaginatedResult<Order[]>();
    let params = new HttpParams;

    if (page != null && pageSize != null) {
      params = params.append('pageNumber', page);
      params = params.append('pageSize', pageSize);
    }
    console.log(params, 'params');
    return this.http.get<Order[]>(this.baseUrl + 'orders', { observe: 'response', params})
    .pipe(
      map(response => {
        paginatedResult.result = response.body;
        if (response.headers.get('Pagination') != null) {
          paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
        }
        return paginatedResult;
      })
    );
  }
  getOrder(id): Observable<Order> {
    return this.http.get<Order>(this.baseUrl + 'orders/' + id);
  }
}
