import { Component, OnInit } from '@angular/core';
import {MatDialogRef} from '@angular/material';
import {MatFormFieldModule} from '@angular/material/form-field';
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


  resetForm(form?: NgForm) {
    if (form != null) {
    form.resetForm();
    }

    this.service.formData = {
      Id: 0,
    NameBook: '',
      Author: '',
      Page: 0
    };
    }
    onSabmit(form: NgForm) {
      this.service.addBook(form.value).subscribe(res => {
        this.resetForm(form);
        alert(res);
      });
    }

    onClose() {
      this.dialogbox.close();
      this.service.filter('Register click');
    }


}
