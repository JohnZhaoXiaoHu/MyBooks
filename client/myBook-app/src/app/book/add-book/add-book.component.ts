import { Component, OnInit } from '@angular/core';
import {MatDialogRef} from '@angular/material';

import {BookService} from 'src/app/api/book.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {

  constructor(public dialogbox: MatDialogRef<AddBookComponent>,
              private service: BookService ) { }

  ngOnInit() {
  }

}
