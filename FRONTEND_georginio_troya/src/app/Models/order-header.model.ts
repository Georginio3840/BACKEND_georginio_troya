import { App } from '../app';
import { ICustomer } from './customer.model';
import { IDelivery } from './delivery.model';
export interface IOrderHeader {
  OrderId: number;
  OrderDate: Date;
  OrderTime: string; // TimeSpan se puede manejar como string "hh:mm:ss"
  CustomerId: number;
  Customer: ICustomer;
  Deliveries: IDelivery[];
}
