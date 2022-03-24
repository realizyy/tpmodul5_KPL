// See https://aka.ms/new-console-template for more information

using tpmodul5_1302204035;

SayaTubeVideo vid1 = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Real Andri Faqih", 0);
vid1.IncreasePlayCount(100);
vid1.PrintVideoDetails();
SayaTubeVideo vid2 = new SayaTubeVideo("", 0);
SayaTubeVideo vid3 = new SayaTubeVideo("100 Char - Awokeoawkeaowekoawekaowkeoawkeoawkeaoaowkeoawkeoakweoawkeoakwekawoekaowekaowkeoawkeowaaweko", 0);
SayaTubeVideo vid4 = new SayaTubeVideo("11.000.000 Views", 1);
vid4.IncreasePlayCount(11000000);
