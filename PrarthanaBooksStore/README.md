# PrarthanaBooksStore
<--------------------------------------------------PART 1---------------------------------------------->
2021/11/03

Start time 5.00

5:00- Create new core Mvc application. Named PrarthanasBookStore 
5:05- Review all the files which created by default in project
5.20- Create a git respository and push into github
5.30- Start debugging
5.31- Set breakpoint to IAction Index and Privacy and run the program
5.45- Start Bootstrap
5.46- go to watch.com select theme vapor download css for this file and replace the existing bootstrap.css file with th downloaded file
5.56- replace the css file with content given in main css file
6.00- change the file name from bootstap.min.css to bootstrap.css in Views>shared>_layout.cshtml file
6.02- Change nav class from nav-dark to nav-light 
6.05- Add additional properties to footer class 
6.15- Modify _loginPartial.cshtml file remove all references to text-dark
6.18- Run a project to review changes
6.20- Add additional stylesheets and scripts to layout.cshtml
6.25- Add a  drop down to the navbar
6.30- save refresh and run th project to review the changes
6.35- Add three project .NET Core class library to the application
6.40- copy the data folder and paste it to .DataAccess project
6.50- install nuget packages and delete migration folder from it 
6.52- modify the namespace to reflect the project
6.55- delete the class1.cs file from all project
7.00 - run the project

Total Time:3hrs 25 min

2021/11/03
Start Time: 8.00

8.00- Add project reference to all the three project
8.05- Rename models folder to viewmodels
8.10- Chnage the ErrorViewModels.cs namespace .Models.ViewModels
8.15- Build the project......suceed building.....run project .....review error
8.20- Remove the using statement for data from startup.cs file
8.25- correct all the default refernce to ErrorModelView to .Models.ViewModels.Error.VieModels
8.30-  All the error are resoled.......run the project again.....review th browser representation
8.35- In utility project add new class file name SD.cs
8.37- Modify properties of the class.................Add Customer area to areas 
8.42- Modify startup.cs file  for route as mention in scaffoldingReadMe.txt file
8.45- Move the homecontroller.cs to the area>customer>controller folder and delete data and models folder
8.47- Edit homecontroller.cs to explicitly define that controller in the customer area
8.50- Move views>home and modify homecontroller namespace
8.55- Run the applcation...Review the change browser representation
9.00- Copy _viewimport and _Viewstart to customer area
9.05- Modify the ViewStart.cshtml to reflect the new path
9.07- Run the application.............Review the change browser representation.
9.10- Add new admin area to areas....Add proper view files.......Delete data and models folder.
9.15- delete controller folder.....update the github repo....Done with part 1 of assignment 2

Total time:1hr 20min

<------------------------------------------------------PART2------------------------------------------------------------>

2021/11/09
Start time:5.00

5.00- Started part 2 for assignment....first step to create migration and update the database name..
	......oops find errors in add migrations.....changes the dafault project to .DataAccess the run again the migration add in console....still error......
	....Started new project go through all the steps in part 1
9.00- Start the part 2 
9.05- Add migration AddDefaultIdentityMigration package to .DataAccess project..oops error occure for project target not match to migraation assembly....change the 
	default project in  pm console to .DataAccess .....run again Add migration AddDefaultIdentityMigration package......finally build succeded....
9.15- Move to the next step....Review the file for sql syntax,statements,columns, primary key....
9.25- in console update the database and Build started...Build succeeded.....Done.
9.30- Add new class to .Models project name category.cs...define the table...and push it to database..
9.35- add the migrations via PM console by run  add-migration AddCategoryToDb....Build started...
		.....Build succeeded.
9.40- Update new migration file and add using statement in it....Rerun ....add-migration AddCategoryToDb.....
		Build started...Build succeeded....review the changes to AddCategoryToDb
9.50- Start to implement Repository in .DataAccess project....add one class file for class implementation and another for
	.....interfaces implementation
9.55- Add new item to the folder and name it IRespository.cs
9.56- Modify it ....using statement.....method are use for CRUD operations...implement a class that implement the respository
		.....include all the using statement for implements interfaces.
10.00- Modify the code to create constructors and dependency injection.
10.05- Create individual repos for category and all potential models to be added in future .....
		CategoryRepository.cs
		ICategoryRepository.cs
10.11- modify CategoryRepository.....modify ICategoryRepository interface....
		Implement the interface tp update in IcategoryRepositiry.cs
10.22- Complete remaining modifications....build...build succeded...push commits to gitHub...

Total Time:6hrs

2021/11/11
Start time: 1.30

1.37 - Add new interface in IRepository folder named ISP_Call.ca that extends IDisposable
1.38- Argument dynamicsParameters shows error so include dapper NuGet Package for dapper and using statement....Error resolved...implement this interface with 
		a new class in the repository folder.
1.45 - Add new classs SP_Call.cs to Repository folder by including using stattement...using Dapper...implement the ISP_Call interface...
	Add the connection to database using additional using statement ...modify the ISP_Call interface implementation.
-----------------------------------------
Total Time: 1hr
-----------------------------------------

2021/11/12 
Start time: 2.00

2.10- Add new interface to IRepository folder and update the code 
2.30 - implement this interface in UnitOfwork and include the require package using statement

13/11/2021
11.00- Modify the code in class implements the interface.....
11.18- Modify startup.cs to accessible class UnitOf Work by project with  services.AddScoped<UnitOfWork,UnitOfWork>();
11.19- Build the project....build succeded.....push commits to Github.
------------------------------------------
Total Time: 6hrs
------------------------------------------
2021/11/14

Start time:10.00

10.00- Opps.....error in startup.cs....UnitOfWork not found.....Generate new interface IUnitOfWork....try to solve error...
		spend 2 hrs to solve error......finally reslove and build suceeded....
12.10- Start next step....Add new controller to Area/Admin....CategoryController.cs...Modify the code to use the IUnitOfWork from the .DataAccess project..... 
		and IRepository folder.
12.25- Add new view "Index" to the folder ...modify the code of index.cshtml with the code in Assignment2/IndexView.txt
12.50- Save the application and run ....build sucessfully....In layout.cshtml move the category link to the content management dropdown
12.55- run the application and review the changes to the navigation....push to github...
1.15- modify the index.cshtml to add icons in the category..using font awesome...
1.20- delete it and add to the javascript file from assignemtn2 into wwwroot/js folder 
1.30- In index.cshtml add the @section to the category.js script and run the application
1.40-opppppssss....Error......Microsoft.Data.SqlClient.SqlException: 'Invalid object name 'Categories'.'
5.00- Try to slove but not solver the error so move to the next part without pushing github....create a new catergory using the upsert action 
		in categorycontroller.cs....Add new view name...Upsert.cshtml.....add and copy the code from blackboard.......Create a partial view in views/shared/ folder 
		for EDIT/BACK.....Add asp-action in partial view named CreateAndBackToListButton.cshtml
5.25- Create another partial view _EditAndBackToListButton and modify the code and code addition of the @model razor statement...add @model to upsert.cshtml
	Add the asp-action to the Index.cshtml page and run the application.

----------------------------------
Total Time: 5hr 30min
----------------------------------

2021/11/18
Start time 9.00

9.05: Modify data and model folder....
9.30- Bulid the project...build sucessful.....push to github
1.00- Start the remaining changes of part 3 
1.05- Create a new Upsert post method to categoryController.cs
1.15- Add new void save method to UnitOfWork file....Remove _Db_Savechanges methos from categoryRepository.cs...And add To CategoryControoler.cs with return To Redirectaction method...
		......Check the error...no error....start Building....Build Succeded...finally added the category to the database....
1.30- Add new API  call for HTTPDelete in CategoryController.cs

2021/11/20
11.00- implement the HTTPDelete with the delete method in category.js file and add functionality to the application and call API with onclick event to the delete function ..
		Add the Delete(url) function code to the category.js file .....chec for error no error ....test the application.....
		....opppppssss.....the delete button not work and edit also.....update readme....push changes to github....
----------------------------------------------
Total Time: 7hrs
----------------------------------------------

2021/11/22

2.00- Start reviwwing all the ppt from part1 For solve errors in upsert file for edit function........not done.....

2021/11/29
Start Time: 2.00PM

2.00- Modify the categoryController.cs ........try to solve error......Unreachable code exist......
4.00- Finally solve error ......changes in categoryController.cs.........Remoce extra return view.....
8.00- Start to figureout all the coding of file categoryController.cs ,UnitOfWork.cs, IUnitOfWork.cs, Upsert.cshtml....
9.00- Finally error resolve find in categoryController.cs line no 37 modify  return View(category);..........Error solve.....start build... ..
		....build succeded.....edit works......
-------------------------------------------
Total Time: 7hr
-------------------------------------------
---------------------------------------------------------PART 3--------------------------------------------------------------------

Start Time: 9.15

9.15- Create CRUD cover type with exact method used for category
9.20- Add CoverType.cs file in model folder Cover type model ID and Name
9.30- Add cover type to repository Add CoverTypeRepository class and ICoverTypeRepository interface.
9.45- Add CoverType to UnitOfWork and IUnitOfWork Push CoverType to the Database (Create migration and update the DB)
10.00- Add CoverType to NavBar and Add controller with all required action methods.
10.25- Add view Index for CoverType and upsert view for creating and updating CoverType
10.30- Delete CoverType is done using API CALLS .....Start Building.....error....in CoverTypeController.cs.....Try to solve....
		Build Suceeded......Create a cover type.......Exception....thrown....push to github....

2021/11/30

Start Time: 6.00PM

6.00- Start part 3 Again to solve error by review all slides for category for steps to follow for covertype.....
7.30- Finally solve error.....Forgot to add migration for Covertype ....Added....Update database ....push to git hub....finally...
		Build succeded.....Cover type create new added,edited,delete...Push to github...update readme...

9.00- Start section 2 for product....Create new class Product.cs inn Models.....Make a calss public and Add the code for class 
10.00- Add refernece to product in ApplicationDbContext.cs file...In PM console Add migration for ProductToDb And update databse...
		PM> Add-migration AddProductToDb
		Build started...
		Build succeeded.
		To undo this action, use Remove-Migration.
		PM> update-database
		Build started...
		Build succeeded.
		Done.

2021/12/01
Start Time: 6.00PM
............................................................
6.00- Add a controller Product in Areaa>admin>ProductController.cs
6,15- Add using Microsoft.AspNetCore.Hosting; for IWebHostEnvironment call.....Change the controller product public .....
		Create a viewmodel in model folder ProductVM select listype covertype and category......Create a cass ProductVM  and change it to public 
6.45- Install using Microsoft.AspNetCore.Mvc.Rendering; package ......Modify ProductController  so the IActionResult upsert calls to the ProductVM view model...
7.00- Include using Microsoft.AspNetCore.Mvc.Rendering;...comment out upsert post methos...modify API call include  the Category and CoverType Properties...
7.30- Add Indexview  code from View/Category and modify to the product List header,Create New product  and add the properties Title,
		ISBN, Price, Author, Category and refernce a new file product.js
8.00- Copy Category.js and paste and remane it product.js and modify the URL point to product.....Modify _Layout.cshtml to add new link..
		to the product....Start Building Aplication...Build succeded.....Run the application.....Throws an exception hit continue....
9.00- Create Upsert.cs for Products and modify file as assignment 2 files ....Run te application for create new product......error in creatin gnew product...
		System.InvalidOperationException: 'An error was generated for warning 'Microsoft.EntityFrameworkCore.Query.InvalidIncludePathError': Unable to find navigation
		' CoverType' specified in string based include path ' CoverType'. This exception can be suppressed or logged by passing event ID 'CoreEventId.InvalidIncludePathError' 
		to the 'ConfigureWarnings' method in 'DbContext.OnConfiguring' or'AddDbContext'.'

2021/12/01
Start Time: 9.00

9.00- Review all the steps and again start part 3 section 2 and section 3 ......go through the all steps and rerun again .....stilll showss...error...try to solve.....
		System.InvalidOperationException: 'An error was generated for warning 'Microsoft.EntityFrameworkCore.Query.InvalidIncludePathError': Unable to find navigation
		' CoverType' specified in string based include path ' CoverType'. This exception can be suppressed or logged by passing event ID 'CoreEventId.InvalidIncludePathError' 
		to the 'ConfigureWarnings' method in 'DbContext.OnConfiguring' or'AddDbContext'.'

-------------------------------------------
Total Time: 
-------------------------------------------