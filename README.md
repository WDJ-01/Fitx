# FitX

## To view a live example, **[click here](https://t0d00.netlify.app/)**

## Descriptions

FitX is a functional ecommerce store built in Angular(frontend), ASP.NET Core(backend) and Microsoft Sql Server(database). The below document contains information on how to replicate this project or use parts of it as desired.

## Contents

### Angular(angular_ecom)

#### Contains:

* Home page - gallery style
* Login, signup pages
* Sidenav with navigation buttons
* Different pages for products in different categories - men, women, running, weightlifting
* Single product page
* Cart
* Favorites page
* User profile

#### Built With

Here is a list of resources used:
* Angular
* HTML
* CSS
* JavaScript
* TypeScript
* Bootstrap

### .Net(UseApi)

#### Contains:

* Api's for respective functions such as signing in, creating user, getting products ect.
* Creating JWT token
* Authentication
* Hashing and salting of passwords

#### Built With

Here is a list of resources used:
* .Net Core
* C#

## Microsoft Sql Server

#### Contains:

* Database
* Tables for Users, Products, Categories - each contains:
  * Users: User_id, User_username, User_firstname, User_lastname, User_email, User_mobile, User_phone, User_address, User_password,                  User_token, User_password_salt
  * Products: Products_id, Category_id_ref, Products_name, Products_price, Products_desc, Products_cover
  * Categries: Category_id, Category_name

#### Built With

* Microsoft Sql Server

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## How To Use

You'll need [Git](https://git-scm.com) and [Node.js](https://nodejs.org/en/download/) (which comes with [npm](http://npmjs.com)) installed on your computer.

### Steps

1. Fork this repoistory and clone it to your local machine.
```bash
$ git clone https://github.com/<your-username>/My-Portfolio.git
``` 
2. Go into the repository
```bash
$ cd my-portfolio
```

3. Install dependencies
```bash
$ npm install
```

### Serve

* Start's development server
```bash
$ npm run serve
```

### Build

* Create build (uses Wepback). Find build in dist/ folder.
```bash
$ npm run build
```
<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Acknowledgments

* react-router
* react-icons
* react-hooks


<p align="right">(<a href="#readme-top">back to top</a>)</p>
