ASP.NET Core Web API – Gyakorlati feladat 

Téma: Student Course API 

Cél: 

Készíts egy egyszerű Web API-t, amely hallgatók és kurzusok adatait kezeli. 

A cél, hogy az API képes legyen az alapvető CRUD (Create, Read, Update, Delete) műveletek elvégzésére mindkét entitáson. 


Feladatleírás 

Hozz létre egy új ASP.NET Core Web API projektet. 

A projektben valósítsd meg az alábbiakat: 

1. Modellek létrehozása 

Hozz létre két osztályt a Models mappában: 

Student 

Id (int) 

Name (string) 

Age (int) 

Email (string) 

Course 

Id (int) 

Title (string) 

Credits (int) 

 

 

2. In-memory adatforrás 

A feladat egyszerűsítése érdekében az adatok tárolása in-memory listában történjen (nem szükséges adatbázis). 

Például: 

2 hallgató (pl. Anna, Bence) 

2 kurzus (pl. "C# Programming", "Web Development") 

 

 

3. Controller-ek 

Készíts két controllert az alábbi funkciókkal: 

StudentsController 

GET /api/students → összes hallgató lekérdezése 

GET /api/students/{id} → hallgató lekérdezése ID alapján 

POST /api/students → új hallgató hozzáadása 

PUT /api/students/{id} → meglévő hallgató módosítása 

DELETE /api/students/{id} → hallgató törlése 

CoursesController 

Ugyanezeket a CRUD műveleteket valósítsd meg kurzusokra. 

 

 

4. Tesztelés 

A kész API-t Swagger vagy Postman segítségével teszteld: 

Hozz létre új hallgatót és kurzust. 

Módosítsd egy hallgató életkorát. 

Törölj egy kurzust. 

Ellenőrizd, hogy az adatok helyesen frissülnek a listában. 

 

 

5. Extra feladatok 

Ha elkészültél az alapfeladattal, próbálj meg legalább egyet a következők közül megvalósítani: 

Keresés név alapján: 

GET /api/students?name=Anna – csak a megadott névhez illő hallgatókat listázza. 

Rendezés: 

Kérd le a hallgatókat név vagy kor szerint növekvő sorrendben. 

Egyszerű statisztika: 

Készíts egy új végpontot (pl. /api/students/averageAge), ami visszaadja a hallgatók átlagéletkorát. 

Adatellenőrzés (validáció): 

Ne lehessen üres Name vagy hibás Email mezővel új hallgatót létrehozni. 

Különleges route: 

Készíts olyan végpontot, ami visszaadja az összes kurzus címét nagybetűvel (/api/courses/titles). 

 

 

 Tipp 

Használd a beépített Swagger UI-t a teszteléshez. 

Figyelj a helyes HTTP státuszkódok visszaadására (200 OK, 201 Created, 404 NotFound, stb.). 

Az adatok egy static listában tárolhatók, az órán nem szükséges adatbázis használata. 

 

 
 Leadási feltételek 

A projekt fut és Swaggerben tesztelhető. 

Legalább a StudentsController minden CRUD művelete működik. 

A kód átlátható, helyesen tagolt. 

 

 

Időkeret: kb. 90 perc 

Cél: működő, tesztelhető Web API alkalmazás készítése in-memory adattárolással. 
