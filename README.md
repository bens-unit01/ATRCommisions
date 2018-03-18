
   AssureToutRisque Commissions
==================================



This is a C# program meant for an insurance company to manage agent`s commissions and residual
payments. All the transactions and the program's data are presisted on an Oracle data base. The
calculation of the payments is made on the 1st of each month, we implemented some business rules
regarding the calculation of the commisions and the residual payments.


The business rules depends on time parameters, for example, when an insurance policy is sold, the
first payment is a commission, for the next months it's a residual payment. The residual
payments will stop after a period of 5 years or if the insurance policy is canceled.

The major problem we faced is that we cannot test the application since all the business rules
are time relative. We cannot for example wait 5 years to see if the residual payment will really
stop. The option of changing the system time wasn't taken since we cannot assume that we will
have an administrator profile on the testing environement.

The solution we found is to add another layer on our application for the time system and this is why
we added the TimeMachine module. Using the TimeMachine we can change the system time and we can test
the behaviour of our application. That way, our application is completely independent from the
system time. Of course, before deploying our application we need to take off this TimeMachine module
and replace it with a production module to wire our application to the production environment.

Here are some screenshots : 

![Alt text]( /screenshots/AdminScreen.PNG?raw=true "Cours")
![Alt text]( /screenshots/AdminScreen2.PNG?raw=true "Cours")
![Alt text]( /screenshots/AdminScreen3.PNG?raw=true "Cours")
![Alt text]( /screenshots/AdminScreen5.PNG?raw=true "Cours")
![Alt text]( /screenshots/AgenTScreen1.PNG?raw=true "Cours")
![Alt text]( /screenshots/AgenTScreen2.PNG?raw=true "Cours")
![Alt text]( /screenshots/AgenTScreen3.PNG?raw=true "Cours")
![Alt text]( /screenshots/AgenTScreen4.PNG?raw=true "Cours")
![Alt text]( /screenshots/TimeMachine.PNG?raw=true "Cours")



## Remarque : 
Prérequis : pour vous logguer à l'application en tant qu'administrateur : 
 - Num employe : 1
 - Mot de passe : 1111
 
  en tant qu'agent : 
  
     - Num employe : 2
     - Mot de passe : 1111
     
L'application TimeMachine sert à changer la date du système et déclencher un 
trigger le 1er de chaque mois pour le calcul des commissions et les paiements 
résiduels. 




