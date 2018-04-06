Enviroment<br/>
Visual Studio 2017<br/>
ASP.NET MVC5(.NET Framework 4.6.1)<br/>
Entity Framework 6<br/>
PagedList.MVC<br/>
LocalDB<br/>

I installed several packages to create a bulletin board. Just run the command in the console window.<br/>

Tool->NuGet Package Manager->Package Manager Console<br/>

-Installed Entity Framework 6.<br/>
Install-Package EntityFramework<br/>

-Installed PagedList.MVC NuGet <br/>
Install-Package PagedList.Mvc<br/>

I implemented the CRUD function on the bulletin board, and I entered 100 people who were sent to Excel.<br/>

List of files added<br/>
/Controllers/HomeController.cs	<br/>
/Controllers/MemberController.cs	<br/>
/DAL/MemberContext.cs	<br/>
/DAL/MemberInitializer.cs	<br/>
/Views/Home/About.cshtml	<br/>
/Views/Home/Contact.cshtml	<br/>
/Views/Home/Index.cshtml	<br/>
/Views/Member/Create.cshtml	<br/>
/Views/Member/Delete.cshtml	<br/>
/Views/Member/Details.cshtml	<br/>
/Views/Member/Edit.cshtml	<br/>
/Views/Member/Index.cshtml	<br/>
/Views/Shared/Error.cshtml	<br/>
/Views/Shared/_Layout.cshtml	<br/>
/Views/Web.config	<br/>
/Views/_ViewStart.cshtml<br/>
/Web.config<br/>
<br/>
