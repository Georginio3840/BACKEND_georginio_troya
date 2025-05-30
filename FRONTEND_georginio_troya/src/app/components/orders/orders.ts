import { Component, OnInit } from '@angular/core';
import { IOrderHeader } from '../../Models/order-header.model';
import { OrderHeaderService } from '../../Services/order-header';
import { DatePipe, NgFor, NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatCardModule } from '@angular/material/card';
import { IDelivery } from '../../Models/delivery.model';
import { DeliveryService } from '../../Services/delivery';

@Component({
  selector: 'app-orders',
  imports: [NgIf, NgFor, DatePipe, FormsModule, MatCardModule],
  templateUrl: './orders.html',
  styleUrl: './orders.css',
})
export class Orders implements OnInit {
  orders: IOrderHeader[] = [];

  customerId: number = 0;
  orderId: number = 0;

  delivery: IDelivery = {
    Type: '',
    Status: '',
    Departure: '',
    Arrival: '',
  };
  constructor(
    private orderService: OrderHeaderService,
    private deliveryService: DeliveryService
  ) {}

  ngOnInit(): void {
    this.loadOrders();
  }

  loadOrders() {
    this.orderService.getOrders().subscribe({
      next: (data: IOrderHeader[]) => {
        this.orders = data;
        console.log('Orders loaded:', this.orders);
      },
      error: (err) => {
        console.error('Error loading orders:', err);
      },
    });
  }

  submitDelivery(): void {

this.deliveryService.createDelivery(this.customerId, this.orderId, this.delivery)
    .subscribe({
      next: (response) => {
        console.log('Delivery created successfully:', response);
        alert('Delivery created successfully');
        this.delivery = { Type: '', Status: '', Departure: '', Arrival: '' }; // Reset form
      },
      error: (error) => {
        console.error('Error creating delivery:', error);
        alert('Error creating delivery: ' + error.message);
      }
    });
  }
}
