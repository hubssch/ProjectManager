# ProjectManager#
Opis projektu:
Celem projektu jest stworzenie aplikacji do zarządzania projektami w firmie. Aplikacja umożliwia rejestrację i logowanie użytkowników, tworzenie projektów, edycję i usuwanie istniejących projektów oraz przeglądanie ich szczegółowych informacji.

# Wymagania:
Do uruchomienia projektu wymagane są następujące technologie:

* SQL
* Visual Studio 2022
* .NET 6
* Microsoft.AspNetCore.Identity.EntityFrameworkCore
* Microsoft.AspNetCore.Identity.UI
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools
* Microsoft.VisualStudio.Web.CodeGeneration.Design
* Swashbuckle.AspNetCore

# Instalacja:
Aby zainstalować projekt należy wykonać następujące kroki:

1. Sklonować repozytorium z projektem.
2. Otworzyć projekt w programie Visual Studio 2022.
3. Uruchomić konsolę menedżera pakietów i wykonać komendę Update-Database, aby utworzyć bazę danych.
4. Uruchomić projekt w programie Visual Studio 2022.

# Konfiguracja:
Do poprawnego działania projektu należy skonfigurować połączenie z bazą danych. W tym celu należy:

1. Otworzyć plik `appsettings.json`.
2. Wprowadzić w nim właściwy connection string do bazy danych w formacie:

```json
"ApplicationDBContextConnection": "Server=localhost;Database=master;Database=ProjectManager;Trusted_Connection=True;"
```

# Testowe użytkownicy i hasła:
Do testowania aplikacji można użyć następujących danych logowania:

* Login:  [admin@gmail.com](mailto:admin@gmail.com) 
* Hasło: Ma4bach!

# Opis działania aplikacji z punktu widzenia użytkownika:
Aby korzystać z aplikacji należy wykonać następujące kroki:

1. Rejestracja użytkownika:
a. Kliknąć przycisk “Register”.
b. Wypełnić pola: “FirstName”, “LastName”, “Email”, “Password”, “Confirm Password”.
c. Kliknąć przycisk “Register”.
d. Potwierdzić założenie konta na pojawiającej się stronie.

2. Logowanie użytkownika:
 Kliknąć przycisk “Login”.
 Wprowadzić dane logowania: “Email” i “Password”.
 Kliknąć przycisk “Login”.

3. Zarządzanie projektem: użytkownik może przejść do zakładki “Lista projektów”, gdzie ma do wyboru opcje:
“Create new” - umożliwia utworzenie nowego projektu. Użytkownik wypełnia pola “Name”, “Description”, “Category” i “Employee” i potwierdza utworzenie projektu klikając “Create”. Po utworzeniu projektu użytkownik może powrócić do listy projektów klikając “Back to list”.
“Edit” - umożliwia edycję aktualnego projektu. Użytkownik może zmienić wartości pól takich jak “Name”, “Description”, “Category” i “Employee”, a następnie potwierdzić zmianę klikając “Save”. Po zapisaniu zmian użytkownik może powrócić do listy projektów klikając “Back to list”.
“Details” - umożliwia podgląd informacji o projekcie w ładnie sformatowanej wersji. Użytkownik może kliknąć “Edit” aby edytować informacje o projekcie lub kliknąć “Back to list” aby powrócić do listy projektów.
“Delete” - umożliwia usunięcie projektu. Użytkownik potwierdza swój zamiar klikając na “Delete” na stronie z sformatowanymi danymi projektu.




