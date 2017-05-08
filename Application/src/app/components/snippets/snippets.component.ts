import { Component } from '@angular/core';
import { SnippetService } from './../../services/snippets/snippet.service';
import { Snippet } from './../snippets/snippet';

@Component({
  selector: 'snippets',
  templateUrl: './snippets.html',
  providers: [SnippetService]
})
export class SnippetsComponent  { 
    snippets: Snippet[];
    constructor(private snippetService: SnippetService) {
      this.getSnippets();
    }

    getSnippets(): void { this.snippetService.getSnippets().then(snippets => this.snippets = snippets) };
}
