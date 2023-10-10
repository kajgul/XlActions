# XlActions

[PL]
Aplikacja do generowania wydruków w Comarch ERP XL za pomocą Comarch XL API.

Do obsługi API wykorzystano .NET w wersji 4.72, a API zostało podłączone przez obiekty COM. Wykorzystano dostęp do bazy danych przez micro-ORM Dapper oraz framework Json.NET to zapisywania konfiguracji do bazy danych oraz do API

W gałęzi master znajduje się biblioteka klas, w która zawiera funkcjonalność pozwalająca na logowanie, utworzenie sesji, wylogowywanie się oraz wywoływanie i zapisywanie wydruku faktur do pliku pdf dla programu Comarch ERP XL. 

W gałęzi WPFController znajduje się aplikacja utworzona w WPF, która zapisuje nowe dane potrzebne do połączenie z Comarch EPR XL API oraz bazą danych do pliku JSON.

W gałęzi WPFController.Test znajdują się testy aplikacji utworzone w xUnit.

W gałęzi main_programm znajduje się aplikacja konsolowa, która wywołuje akcje znajdujące się w bibliotexe klas. Aplikacja konsolowa uruchamiana może być za pomocą Task Manager w systemie Windows

[ENG]
An application for generating printouts in Comarch ERP XL using the Comarch XL API.

The API is accessed using .NET version 4.72, connected through COM objects. Database access is achieved through the micro-ORM Dapper, and the Json.NET framework is used for saving configurations to the database and communicating with the API.

The 'master' branch contains a class library that provides functionality for logging in, creating sessions, logging out, and invoking and saving invoice printouts as PDF files for Comarch ERP XL.

The 'WPFController' branch contains a WPF application that saves new data required for connecting to the Comarch ERP XL API and the database to a JSON file.

In the WPFController.Test branch, there are tests for an application created in xUnit.

The 'main_programm' branch contains a console application that calls actions found in the class library. The console application can be launched using the Task Manager in the Windows operating system.
