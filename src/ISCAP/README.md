# Git guide:

	- In order to use git with the Windows operating system you need to download the git bash through https://git-scm.com/downloads. 
	- I recommend using HTTPS instead of SSH because with Windows you have to take some extra steps to work with SSH.
	With HTTPS however all you need to do is login and you are all set. You do not have to log in every time you push.
	- After installation use the command git clone https://github.com/wtcis-software-systems-development/iscap.git to clone the project.
	- Please do not push to the master and instead push to a branch with your team name.
	
	In order to push to a branch run the following commands:
	
	- git checkout -b <branch name here>
	- git branch (to make sure that you are in the branch you created.)
	- git add .
	- git commit -m "<message here>" 
	- git push origin <branch name here> 
	

# Code first (Creating a local database with the entity classes in ISCAPLibrary):

	- The project in the master has all the dependencies that are needed, and as log as you are using visual studio 2015 and working with this project solution, 
	you shouldn't have any problems with packages. Just make sure NOT to update the packages in the project.json file. 
	- On the left of visual studio click on SQL Server Object Explorer => expand one of the SQL servers. Now you should see a file called Database. Right click Database folder => 
	Add New Database. Now right click on the newly created database => Properties then copy the connection string and past it in the Startup.cs 
	- Save and continue to Tools => NuGet Package Manager => Package Manager Console. In the console run the following command Add-Migration InitialMigration -context ISCAPContext
	If you get an error that says something about add migration not being a recognized command save all and close the project and open it again and it should work. Notice the new Migrations folder that has been created.
	- Now update the database by running the following command in the package manager console Update-Database Now you should see all your tables inside your database.
	
# Notes:

	- You will probably need to use the database during your work. Try to use the the entities in the library as your models and not create new ones unless necessary. 
	- Please communicate you concerns or questions to the rest of the class through slack.
	