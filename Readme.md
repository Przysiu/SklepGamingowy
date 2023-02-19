#OPIS APLIKACJI
Aplikacja s�u�y do przegl�dania produkt�w gamingowych oraz p�niejszego ich zakupu. Umo�liwia to centralna cz�� strony; wszystkie produkty, z podzia�em na strony- nr stron poni�ej produkt�w.Podukty mo�na r�wnie� ogranicza� do poszczeg�lnych kategorii za pomoc� panelu po lewej stronie strony. 
Poni�ej produkt�w znajduje si� infomracja o mo�liwo�ci wzi�cia udzia�u w turnieju (po klikni�ciu w link u�ytkownik jest przekierowany do formularza zg�oszeniowego).
Na stronie g��wnej w g�rnym prawym rogu znajduje si� grafika "kosza zakupowego", kt�ra prowadzi do koszyka. Je�eli produkt znajduje si� w koszyku to obok ikony widoczna jest kwota zam�wienia, oraz ilo�� umieszczonych w nim produkt�w.
Ka�dy produkt, przy oznaczeniu ceny, posiada mo�liwo�� dodania do koszyka. Po klikni�ci w przycisk "dodaj do koszyka" aplikacja przenosi u�ytkownika automatycznie do koszyka w kt�rym istnieje opcja wyboru "kontynuuj zakupy" lub "Z�� zam�wienie". Sk�adaj�c zam�wienie u�ytkownik uzupe�nia formularz z danymi.


#�a�cuch po��czenia z baz�:
Connection string z Pliku "appsettings.json
"ConnectionStrings": {
    "SklepGamingowyConnection": "Server=(localdb)\\MSSQLLocalDB;Database=SklepGamingowy;MultipleActiveResultSets=true",
    "IdentityConnection": "Server=(localdb)\\MSSQLLocalDB;Database=Identity;MultipleActiveResultSets=true"
  }


#Panel administratora jest dost�pny pod adrestem localhost:5000/admin. 
Login Admin, Has�o: $PanDa3$ 
Panel administratora umo�liwia przegl�d produkt�w oraz zam�wie�. Produkty mo�na usuwa�, przegl�da� szczeg�y, oraz za pomoc� formularzy edytowa� oraz wstawia� nowe produkty .


Poza baz� danych "Identity", w projekcie wykorzystywana jest baza "SklepGamingowy"(poni�ej diagram).

![Diagram Bazy SklepGamingowy](./images/DiagramBazySklepGamingowy.png)

W tabeli Products przechowywane s� dane o produktach dost�pnych w sklepie. Tabela Orders dotyczy zam�wie�(Imi� i Nazwisko zamawiaj�cego, Line1-3[adres]...). "CartLine" w relacji wiele-do-wielu jest tabel� pomostowo�(��cz�c�).




