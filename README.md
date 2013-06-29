## AngularJS + ASP.NET Web Api + TypeScript

This project is an application skeleton for a simple AngularJS app. You can use it to bootstrap you AngularJS web
application projects in Visual Studio environment.

This seed contains AngularJS libraries, test libraries and a bunch of scripts all preconfigured for instant web
development gratification. Just clone the repo (or download the zip/tarball), open it in Visual Studio 2012 and
you are ready to develop and test your web application.

This seed doesn't do much, just shows how to write two controllers and views together. You can check it out by
running App project in Visual Studio.

![AngularJS + Web Api Single Page App (SPA) Starter Kit](http://i.imgur.com/NvR6uyz.png)

### Technologies

 - [AngularJS](http://www.angularjs.org) MV* family JavaScript Framework
 - [ASP.NET Web Api](http://asp.net/web-api) library for building RESTful services
 - [ASP.NET Web Pages](http://www.asp.net/web-pages) adds Razor syntax to your HTML views
 - [ASP.NET Web Optimization Framework](https://aspnetoptimization.codeplex.com/) bundles and minifies JavaScript/CSS files
 - [TypeScript](http://www.typescriptlang.org) adds static typing to JavaScript and better IDE goodies
 - [LESS CSS](http://lesscss.org/) extends CSS with dynamic behavior

### Prerequisites

 - [Visual Studio 2012](http://www.visualstudio.com) with [Update 2](http://www.microsoft.com/en-us/download/details.aspx?id=38188) and extensions:
   - [NuGet](http://www.nuget.org) Package Manager
   - [Web Tools 2012.2](http://go.microsoft.com/fwlink/?LinkId=282650)
   - [Web Essentials 2012](http://visualstudiogallery.msdn.microsoft.com/07d54d12-7133-4e15-becb-6f451ea3bea6)
   - [TypeScript](http://www.typescriptlang.org)

*Hint: make sure that you have the latest version and updates for Visual Studio and required extensions installed*

### How to Get Started

Clone the [angular-vs](https://github.com/kriasoft/angular-vs) repository and start hacking...

When you open this porject in Visual Studio for the first time, right-click on the solution in solution explorer,
then in the context menu select Manage NuGet Packages and in the opened dialog click Restore Packages. This way
all the referenced libraries are going to be downloaded into the project's folder from nuget.org

### Q & A

 - **Why this project doesn't use ASP.NET MVC?**

   If you're building a single page application (SPA), you're already using an MVC framework, no need to use both.
   You still can use routing and web pages (.cshtml) with Razor syntax for your views.

 - **Why it doesn't use ServiceStack?**

   There is no tight dependency on ASP.NET Web Api, you can easily replace it with ServiceStack if you want to,
   though keep in mind that with Web Api you have a better degree of configurability and control over your RESTful
   services.

### To-Do

 - Add angular.d.ts
 - Setup and configure unit and e2e tests

### Contact

Please check out [AngularJS forums](http://groups.google.com/group/angular) or drop me an email at [hello@tarkus.me](mailto:hello@tarkus.me)