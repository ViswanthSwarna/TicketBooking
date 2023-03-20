import { user } from './user.model';

export interface ticketRequestBody {
    ticketId: number;
    busId: number;
    userId: number;
    fare: number;
    isPaymentDone: boolean;
    user: user;
}
