import { Injectable } from '@angular/core';
import {Book} from '../models/book-model';
import {Observable} from 'rxjs';
import {MatTableModule} from '@angular/material/table';
import {Subject} from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BookService {

 public formData: Book;
  constructor(private http: HttpClient) {
    this.formData = new Book();
    this.formData.Id = '';
    this.formData.Author = '';
    this.formData.NameBook = '';
    this.formData.Page = 0;
   }

  readonly ApiUrl = "https://localhost:44393/api";

private listners = new Subject<any>();
listen(): Observable<any> {
  return this.listners.asObservable();
}
filter(filterBy: string) {
  this.listners.next(filterBy);
}

getBookList(): Observable<Book[]> {
  return this.http.get<Book[]>(this.ApiUrl + '/book');
}

addBook(update: Book) {
  return this.http.post(this.ApiUrl + '/book', update);
}
}
