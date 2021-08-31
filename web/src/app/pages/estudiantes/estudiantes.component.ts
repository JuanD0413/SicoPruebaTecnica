import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';
import { DataService } from '../../services/data.service';
import { Students } from '../../interfaces/students';

@Component({
  selector: 'app-estudiantes',
  templateUrl: './estudiantes.component.html',
  styleUrls: ['./estudiantes.component.scss']
})
export class EstudiantesComponent implements AfterViewInit {
  public students:Array<Students> = [];
  displayedColumns: string[] = ['id', 'TipoIdentificacion', 'Identificacion', 'nombre1', 'apellido1'];
  dataSource: MatTableDataSource<Students> = new MatTableDataSource();

  //@ViewChild(MatPaginator) paginator: MatPaginator = new MatPaginator();
  @ViewChild(MatSort) sort: MatSort = new MatSort();
  constructor(private _api:DataService) { }

  ngAfterViewInit() {
    //this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
    this.getAll();
  }

  ngOnInit(): void {
    this.getAll();
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  getAll() {
    this._api.getAllStudents().subscribe(response => {
      console.log(response);
      if(response) {
        this.students = response;
        this.dataSource = new MatTableDataSource(this.students);
      }
    })
  }
}
