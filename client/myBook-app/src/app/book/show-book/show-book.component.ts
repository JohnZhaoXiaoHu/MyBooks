import { Component, OnInit } from '@angular/core';
import {MatTableDataSource, MatSort} from '@angular/material';
import { BookService } from 'src/app/api/book.service';

@Component({
  selector: 'app-show-book',
  templateUrl: './show-book.component.html',
  styleUrls: ['./show-book.component.css']
})
export class ShowBookComponent implements OnInit {

  constructor(private service: BookService) { }
  listData: MatTableDataSource<any>;
  displayedColumns: string[] = [ 'Id', 'NameBook', 'Author', 'Page'];

getBookList() {
this.service.getBookList().subscribe(data => {
this.listData = new MatTableDataSource(data);

});

}

  ngOnInit() {
    this.getBookList();
  }

}
