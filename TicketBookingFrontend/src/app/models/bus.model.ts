import { city } from './city.model';

export interface bus {
    id: number;
    busName: string;
    sourceCity: city;
    destinationCity: city;
    startDateTime: string;
    endDateTime: string;
    type: string;
}
