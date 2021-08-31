import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Course } from '../interfaces/course';
import { Students } from '../interfaces/students';

@Injectable({
  providedIn: 'root'
})

export class DataService {
  public baseUrl:String = environment.urlApi;
  constructor(private _http:HttpClient) { }

  //CURSOS
  getAllCourses() {
    return this._http.get<Array<Course>>(this.baseUrl + 'Cursos')
  }

  getOneCourse(id:number) {
    return this._http.get(this.baseUrl + 'Cursos/' + id)
  }

  InsertCourse(json:Course) {
    return this._http.post(
      this.baseUrl + 'Cursos',
      json
    )
  }

  updateCourse(json:Course) {
    return this._http.put(
      this.baseUrl + 'Cursos',
      json
    )
  }

  //ESTUDIANTES
  getAllStudents() {
    return this._http.get<Array<Students>>(this.baseUrl + 'Estudiantes');
  }

  InsertStudent(json:Students) {
    return this._http.post(
      this.baseUrl + 'Estudiantes',
      json
    )
  }

  getOneStudent(id:number) {
    return this._http.get<Students>(this.baseUrl + 'Estudiantes/' + id)
  }

  updateStudent(json:Students) {
    return this._http.put(
      this.baseUrl + 'Estudiantes',
      json
    )
  }

  deleteStudent(id:number) {
    return this._http.delete(this.baseUrl + 'Estudiantes/' + id)
  }
}
