# FitX

## To view a live example, **[click here](https://angular-ecom.netlify.app/)**

## Descriptions

FitX is a functional ecommerce store built in Angular(frontend), ASP.NET Core(backend) and Microsoft Sql Server(database). The below document contains information on how to replicate this project or use parts of it as desired. The angular front end is hosted on Netlify and ASP.NET Core API along with the sql database is hosted in [Microsoft Azure](https://azure.microsoft.com/en-gb/free/search/?ef_id=_k_Cj0KCQjw4NujBhC5ARIsAF4Iv6eMRmAZ8I1rhkA_Wtyt9lwQsjzbgor1dnzHkjQQvONn7VC8ac_aL4kaAufMEALw_wcB_k_&OCID=AIDcmmck5pq7og_SEM__k_Cj0KCQjw4NujBhC5ARIsAF4Iv6eMRmAZ8I1rhkA_Wtyt9lwQsjzbgor1dnzHkjQQvONn7VC8ac_aL4kaAufMEALw_wcB_k_&gclid=Cj0KCQjw4NujBhC5ARIsAF4Iv6eMRmAZ8I1rhkA_Wtyt9lwQsjzbgor1dnzHkjQQvONn7VC8ac_aL4kaAufMEALw_wcB).

## Contents

### Angular(angular_ecom)

#### Contains:

* Home page - gallery style.
* Login, signup pages.
* Sidenav with navigation buttons.
* Different pages for products in different categories - men, women, running, weightlifting.
* Single product page.
* Cart.
* Favorites page.
* User profile.

#### Built With

Here is a list of resources used:
* Angular
* HTML
* CSS
* JavaScript
* TypeScript
* Bootstrap

### How To Use(Angular)

You'll need [Git](https://git-scm.com) and [Node.js](https://nodejs.org/en/download/) (which comes with [npm](http://npmjs.com)) installed on your computer and I used [Visual Studio Code](https://code.visualstudio.com/) as a code editor.

#### Steps

1. Fork this repoistory and clone it to your local machine.
```bash
$ git clone https://github.com/<your-username>/FitX.git
``` 
2. Go into the repository
```bash
$ cd angular_ecom
```

3. Install dependencies
```bash
$ npm install
```

#### Serve

* Start's development server
```bash
$ npm start
```

#### Build

* Create build. Find build in dist/angular_ecom folder.
```bash
$ npm build
```

### How Host Angular Project

I used Netlify to host my [Angular](https://www.netlify.com/) frontend. Netlify is a good free alternative to hosting and is easy to use.
This article explains deploying a angular app from github to netlify - [here](https://www.makeuseof.com/angular-website-host-netlify-github/).

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### .Net(UseApi)

#### Contains:

* Api's for respective functions such as signing in, creating user, getting products ect.
* Creating JWT token.
* Authentication.
* Hashing and salting of passwords.

#### Built With

Here is a list of resources used:
* .Net Core
* C#
* 
### How To Use(UserApi)

I used [Visual Studio](https://visualstudio.microsoft.com/downloads/) for code editor.

#### Steps
To setup this project, you need to clone the git repo.

```sh
$ git clone https://github.com/FitX.git
$ cd UserApi
```

followed by

```sh
$ dotnet restore
```

## Microsoft Sql Server

#### Contains:

* Database
* Tables for Users, Products, Categories - each contains:
  * Users: User_id, User_username, User_firstname, User_lastname, User_email, User_mobile, User_phone, User_address, User_password,                  User_token, User_password_salt
  * Products: Products_id, Category_id_ref, Products_name, Products_price, Products_desc, Products_cover
  * Categries: Category_id, Category_name

#### Built With

* Microsoft Sql Server

### How To Host API and SQL

Hosting the api consist of two steps 
* Including sql database tables and column names and info, this happens in the migration folders.
* Publishing Api code to azure as a service.

NOTE - remember to add new Azure https in Angular project

* Video on hosting Api code to Azure - [here](https://www.youtube.com/watch?v=MP4zatl3jF8).
* Article for adding migration folder in project - [here](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application).

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Acknowledgments

* Bootstrap
* Unsplash Images
* Ng Material UI
* Font Awesome

<p align="right">(<a href="#readme-top">back to top</a>)</p>
