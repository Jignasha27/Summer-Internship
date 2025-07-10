import { Injectable } from '@angular/core';
import {
  HttpEvent,
  HttpHandler,
  HttpInterceptor,
  HttpRequest,
  HttpErrorResponse,
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class TokenInterceptor implements HttpInterceptor {
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    // Clone the request and add auth token if needed
    const cloned = req.clone({
      setHeaders: {
        Authorization: `Bearer ${localStorage.getItem('token') || ''}`,
      },
    });

    return next.handle(cloned).pipe(
      catchError((error: HttpErrorResponse) => {
        console.error('HTTP error:', error); // ✅ Log the real error
        // return throwError(() => new Error('Some other error occurred')); ❌ Don't throw generic errors
        return throwError(() => error); // ✅ Proper error handling
      })
    );
  }
}
