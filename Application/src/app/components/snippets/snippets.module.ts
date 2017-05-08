import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { SnippetsComponent }  from './snippets.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ SnippetsComponent ],
  bootstrap:    [ SnippetsComponent ]
})
export class SnippetsModule { }
