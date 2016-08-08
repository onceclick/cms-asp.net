﻿import { Component } from '@angular/core';
import { ROUTER_DIRECTIVES, Router } from '@angular/router';
import { DashboardComponent } from './components/dashboard.component';
import { BlogComponent } from './components/blog.component';
import { GalleryComponent } from './components/gallery.component';
import { AboutComponent } from './components/about.component';

@Component({
    selector: 'my-app',
    templateUrl: 'app/components/component.cshtml',
    directives: [ROUTER_DIRECTIVES],
    precompile: [DashboardComponent, BlogComponent, GalleryComponent, AboutComponent]
})
export class AppComponent {
    title = 'App';
    constructor(private router: Router) { }
    gotoLogin() {
        this.router.navigate(['/login']);
    }
}