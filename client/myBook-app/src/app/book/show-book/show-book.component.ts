import { Component, OnInit , ViewChild} from '@angular/core';
import {MatTableDataSource, MatSort} from '@angular/material';
import { BookService } from 'src/app/api/book.service';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import {MatDialog, MatDialogConfig} from '@angular/material';
import {MatDialogModule} from '@angular/material/dialog';
import { AddBookComponent } from '../add-book/add-book.component';
import {MatTableModule} from '@angular/material/table';

@Component({
  selector: 'app-show-book',
  templateUrl: './show-book.component.html',
  styleUrls: ['./show-book.component.css']
})
export class ShowBookComponent implements OnInit {

  constructor(private service: BookService, private dialog: MatDialog) {
    this.service.getBookList().subscribe((m: any) => {
      console.log(m);
      this.getBookList();
    });
   }
  listData: MatTableDataSource<any>;
  displayedColumns: string[] = [ 'Id', 'NameBook', 'Author', 'Page'];

@ViewChild(MatSort, null) sort: MatSort;


  applyFilter(filterValue: string) {
    this.listData.filter = filterValue.trim().toLowerCase();
  }

getBookList() {
this.service.getBookList().subscribe(data => {
this.listData = new MatTableDataSource(data);
this.listData.sort = this.sort;
});

}

  ngOnInit() {
    this.getBookList();
  }

onAdd() {
  const dialogConfig = new MatDialogConfig();
  dialogConfig.disableClose = true;
  dialogConfig.autoFocus = true;
  dialogConfig.width = "90%";
  this.dialog.open(AddBookComponent, dialogConfig);
}
}
