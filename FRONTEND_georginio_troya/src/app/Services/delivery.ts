import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class DeliveryService {
  constructor(private http: HttpClient) {}
  createDelivery(customerId: number, orderId: number, payload: any) {
    const url = `http://localhost:5048/api/customers/${customerId}/orders/${orderId}/deliveries`;
    return this.http.post(url, payload);
  }
}
