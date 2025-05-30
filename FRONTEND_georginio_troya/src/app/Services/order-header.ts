import { Injectable } from '@angular/core';
import { IOrderHeader } from '../Models/order-header.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class OrderHeaderService {
  private url:string = 'http://localhost:5048/api/orders';

  constructor(private http: HttpClient) { }

  getOrders(){
    return this.http.get<IOrderHeader[]>(this.url);
  }
}
