# PrarthanaBooksStore
11/3/2021
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

11/3/2021
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

9/11/2021
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

11/11/2021

1.37 - Add new interface in IRepository folder named ISP_Call.ca that extends IDisposable
1.38- Argument dynamicsParameters shows error so include dapper NuGet Package for dapper and using statement....Error resolved...implement this interface with 
		a new class in the repository folder.
1.45 - Add new classs SP_Call.cs to Repository folder by including using stattement...using Dapper...implement the ISP_Call interface...
	Add the connection to database using additional using statement ...modify the ISP_Call interface implementation.
 
12/11/2021 
2.10- Add new interface to IRepository folder and update the code 
2.30 - implement this interface in UnitOfwork and include the require package using statement

13/11/2021
11.00- Modify the code in class implements the interface.....
11.18- Modify startup.cs to accessible class UnitOf Work by project with  services.AddScoped<UnitOfWork,UnitOfWork>();
11.19- Build the project....build succeded.....push commits to Github.

14/11/2021
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
		

