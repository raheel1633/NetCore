import { ClientEntity } from './ClientEntity';

export interface Order {
    orderid: number;
    cleintId: number;
    orderNo: string;
    poNumber: string;
    customer: string;
    startDate: string;
    endDate: string;
    billtoCliententity?: ClientEntity;
}
