import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { SnippetTreeComponent }  from './snippetTree.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ SnippetTreeComponent ],
  bootstrap:    [ SnippetTreeComponent ]
})
export class SnippetTreeModule { }
