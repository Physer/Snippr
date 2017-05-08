import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule }    from '@angular/http';

import { AppComponent }  from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { SnippetTreeComponent } from './components/snippetTree/snippetTree.component';
import { SnippetsComponent } from './components/snippets/snippets.component';


@NgModule({
  imports:      [ BrowserModule, HttpModule ],
  declarations: [ 
    AppComponent,
    HeaderComponent,
    SnippetTreeComponent,
    SnippetsComponent
    ],
  bootstrap:    [ 
    AppComponent,
     HeaderComponent,
     SnippetTreeComponent,
     SnippetsComponent
    ]
})
export class AppModule { }
