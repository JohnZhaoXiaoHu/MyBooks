import { Component, OnInit } from '@angular/core';
import {MatTableDataSource, MatSort} from '@angular/material';

@Component({
  selector: 'app-show-book',
  templateUrl: './show-book.component.html',
  styleUrls: ['./show-book.component.css']
})
export class ShowBookComponent implements OnInit {

  constructor() { }
  listData: MatTableDataSource<any>;
  displayedColumns: string[] = [ 'Id', 'NameBook', 'Author', 'Page'];


  ngOnInit() {
  }

}
