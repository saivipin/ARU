import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
    providedIn: 'root'
})
export class ARUService {

    private url = environment.baseUrl + 'inventory/';

    constructor(public http: HttpClient) {

    }

    getInventory(): Observable<any> {
        return this.http.get(this.url)
            .pipe(
                map(res => res),
                catchError(this.handleError)
            );
    }

    getCustomers(): Observable<any> {

        let url = 'assets/masterdata.json';

        return this.http.get(url)
            .pipe(
                map(res => res['MasterData'].Customers),
                catchError(this.handleError)
            );
    }

    handleError(error: any): Promise<any> {
        return Promise.reject(error);
    }
}
