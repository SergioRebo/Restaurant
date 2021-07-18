## VUELING EXAM
------------------------------------------------------------------------
This project is about a Student CRUD (create, read, update and delete) using WCF Services and saving all data in a txt file.


### STATEMENT
-----------------------------------
The porpuse of this project is to learn how to manage data treatment in a txt file while using WCF Service. 


### STRUCTURE
-----------------------------------
This project has been built using the **DDD Arquitecture** where it was divided in two different tiers, Presentation Tier and Backend Tier. You can see the structure [here](https://github.com/SergioRebo/Restaurant/blob/master/Assets/VuelingExam.png). 

The presentation tier is what the client will see while the Backend Tier is where we built our service. 
The Backend Tier is separated in different layers:
- Distributed Service Layer: Where our service is.
- AppService Layer: This will be our Business and Logic layer.
- Domain Layer: This layer is where our entities will be. Besides, another project has been created in order to apply log using the Adapted Pattern. You can see our Adapted Pattern structure in the following [image](https://github.com/SergioRebo/Restaurant/blob/master/Assets/AdapterPatternVueling.png).
- Infrastructure Layer: In this layer is where the repositories and the data treatment are.


### DEVELOPMENT
-----------------------------------
To manage this project, the **SOLID** Principles have been followed.For example, the Single-Responsibility - Principle has been applied in the Adapter Pattern and also Interface - Segregation - Principle to separate the ICrud interface in different interfaces, each of them having one of the ICrud funcionalities, in order to avoid coupling. Another example of Solid Principle will be dependence injections using Autofac, in orther to avoid strong coupling in our project. 
In order to follow DRY Principles (Don't Repeat Yourself), we use Generics so that we could write reusable code. However, we created the ICrud interfaces both in Infrastructure and AppService Layer as we wanted those interfaces to be specific for their layers.
CleanCode and YAGNI (Your Aren't Gonna Need It) Principals have also been used.


### TESTING
-----------------------------------
Some Unit Tests have been done in order to check the funcionalities of ur project. They've been implemented using Mocking and Autofac.


### TOOLS
-----------------------------------
* .NET Framework 7.2
* Visual Studio 2019


### AUTHOR
------------------------------------
* Sergio Rebolledo --> [GitHub](https://github.com/SergioRebo)
