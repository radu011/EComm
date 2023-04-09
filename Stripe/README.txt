1. Deschizi cmd
2. Te muti in directorul curent (unde exista stripe.exe)
3. Rulezi programul
4. Te loghezi: "stripe login"
5. Activezi forward 
	"stripe listen --forward-to https://localhost:7120/api/payment"
	
Acum trebuie sa functioneze!
Daca se foloseste un alt cont, trebuie schimbate key-urile de acces astfel:
i) Intri in Server -> Services -> PaymentService -> PaymentService.cs
ii) La linia 18: 'StripeConfiguration.ApiKey' trebuie adaugata cheia secreta generata pe site-ul stripe
iii) La linia 12: 'secret' trebuie adaugat secretul generat la pasul 5

Enjoy! :)