import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';
import { Snippet } from './../../components/snippets/snippet';

@Injectable()
export class SnippetService {
    constructor(private http: Http) { }

    public getSnippets() : Promise<Snippet[]> {
        return this.http.get("http://snippr.local/api/CodeSnippets").toPromise().then(response => response.json() as Snippet[]);
    }

    private handleError(error: any): Promise<any> {
    console.error('An error occurred', error);
    return Promise.reject(error.message || error);
  }
}