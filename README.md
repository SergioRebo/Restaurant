## VUELING EXAM
------------------------------------------------------------------------
This project is about a Student CRUD (create, read, update and delete) using WCF Services and saving all data in a txt file.

### STATEMENT
-----------------------------------
The porpuse of this project is to learn how to manage data treatment in a txt file while using WCF Service. 

### STRUCTURE
-----------------------------------
This project has been built using the DDD Arquitecture where it was divided in two different tiers, Presentation Tier and Backend Tier. You can see the structure [here](https://github.com/SergioRebo/Restaurant/blob/master/Assets/VuelingExam.png). 

The presentation tier is what the client will see while the Backend Tier is where we built our service. 
The Backend Tier is separated in different layers:
- Distributed Service Layer: Where our service is.
- AppService Layer: This will be our Business and Logic layer.
- Domain Layer: This layer is where our entities will be. Besides, another project has been created in order to apply log using the Adapted Pattern. You can see our Adapted Pattern structure in the following [image](https://github.com/SergioRebo/Restaurant/blob/master/Assets/AdapterPatternVueling.png).
- Infrastructure Layer: In this layer we have the repositories and all the data treatment.


