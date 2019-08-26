import { Injectable } from '@angular/core';
import {Book} from '../models/book-model';
import {Observable} from 'rxjs';
import {MatTableModule} from '@angular/material/table';
import {Subject} from 'rxjs';
import { HttpClient } from 'selenium-webdriver/http';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http: HttpClient) { }

  readonly ApiUrl = "https://localhost:44393/api";
}
