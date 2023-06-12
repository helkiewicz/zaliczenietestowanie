
<h3 align="center">Library system</h3>
## Testy

### UserContextTests
Celem tego testu jest upewnienie się, że konstruktor klasy `UserContext` poprawnie inicjalizuje obiekt `UserContext` z podanymi opcjami.

### LibraryModelTest
Te testy sprawdzają, czy pole 'Title' oraz 'Author' klasy `Library` rozpoczynają się wielką literą.

### LibraryControllerTest
Test jednostkowy `DeleteConfirmed_WithValidId_RedirectsToIndex` sprawdza, czy po usunięciu obiektu o poprawnym identyfikatorze następuje przekierowanie do akcji "Index".

Test jednostkowy `Details_WithInvalidId_ReturnsNotFoundResult` sprawdza, czy dla nieprawidłowego identyfikatora obiektu zwracany jest rezultat `NotFoundResult`.

### LibraryContextTest
Te testy sprawdzają, czy zbiór danych 'Books' oraz 'Tittle' w kontekście `LibraryContext` nie są nullem.

### HomeControllerTest
Test jednostkowy `Index_ReturnsViewResult` sprawdza, czy metoda 'Index' kontrolera `HomeController` zwraca obiekt typu `ViewResult`.

Test jednostkowy `Error_ReturnsViewResultWithModel` sprawdza, czy metoda 'Error' kontrolera `HomeController` zwraca obiekt typu `ViewResult` z modelem typu `ErrorViewModel`.

### ErrorViewModelTest
Test jednostkowy `ShowRequestId_ReturnsTrue_WhenRequestIdIsNotNullOrEmpty` sprawdza, czy właściwość 'ShowRequestId' klasy `ErrorViewModel` zwraca wartość `true`, gdy 'RequestId' nie jest ani null, ani pusty.

Test jednostkowy `ShowRequestId_ReturnsFalse_WhenRequestIdIsNullOrEmpty` sprawdza, czy właściwość 'ShowRequestId' klasy `ErrorViewModel` zwraca wartość `false`, gdy 'RequestId' jest null lub pusty.


<!-- ABOUT THE PROJECT -->
## About The Project


Final project for my class. Contains:

* connection to database,
* lists all the entitities in the database, 
* have a search funcnction, 
* login and registration system, 
* established roles for specific users that enable them to edit the database, 
* basic validation

### Built With

* Nuget, 
* Microsoft.EntityFrameworkCore.Tools, 
* Microsoft.EntityFrameworkCore.Tools,
*  Microsoft.AspNetCore.Identity.EntityFrameworkCore, 
*  Microsoft SQL Server Managment Studio, 
*  .NET core 3.1



















