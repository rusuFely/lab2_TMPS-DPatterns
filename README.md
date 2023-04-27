# lab2_TMPS-DPattern

### **Tiparele de proiectare** 
(sau "design patterns" în engleză) sunt soluții comune și testate în practică pentru problemele care apar în procesul de dezvoltare software. Acestea oferă o abordare clară și structurată pentru proiectarea și implementarea software-ului. Tiparele de proiectare sunt împărțite în trei categorii principale: creationale, structurale și comportamentale Tiparele creationale sunt utilizate pentru crearea obiectelor, tiparele structurale pentru compunerea obiectelor, iar tiparele comportamentale pentru interacțiunea între obiecte.


Exemple de **tipare de proiectare creationale** includ *Singleton, Factory Method, Abstract Factory, Builder, Prototype și Object Pool*. Aceste tipare oferă o modalitate clară de a crea și gestiona obiecte într-un mod structurat și eficient, îmbunătățind astfel performanța și extensibilitatea aplicației.


 #### **Singleton**:
 Este unul dintre cele mai simple modele de design. Înseamnă că o singură instanță poate fi instanțiată dintr-o clasă dată. 
 Se asigură că o clasă are o singură instanță și oferă un punct de acces global la această instanță particulară. Modelul Singleton ajută la salvarea memoriei , 
 deoarece obiectul nu este creat la fiecare cerere. Fie creează un obiect nou, fie returnează un obiect existent care a fost deja creat.
 
 #### **Builder**:  
 Separă construcția obiectului complex de reprezentarea sa. Acesta ascunde structura internă de utilizatorul final și oferă o interfață ușoară cu lumea exterioară.
 Modelul Builder se concentrează pe construirea progresivă a unui produs complex . Este conceput ca o compoziție a unuia sau mai multor obiecte similare cu 
 funcționalitate similară. Ne permite să producem diferite tipuri de obiect folosind același cod.
 
 #### **Prototype**: 
 Creează o instanță complet inițializată care poate fi clonată. Ne permite să copiem obiecte deja existente fără a face codul dependent de alte clase. 
 Un model de prototip construiește un produs prin copierea stării inițiale a unui obiect prototip.
 
 #### **Object Pooling**: 
 Ajută la reutilizarea obiectelor care sunt costisitoare de creat prin reciclarea obiectelor care nu mai sunt utilizate. 
 Este cel mai eficient în situațiile în care rata și costul instanțierii unei clase sunt ridicate. Un caz comun de utilizare a modelului Object Pool este atunci 
 când există mai mulți clienți care au nevoie de aceeași resursă în momente diferite. De exemplu, dacă trebuie să deschidem multe conexiuni la o bază de date, 
 este nevoie de mai mult timp pentru a crea o instanță nouă și serverul bazei de date va fi supraîncărcat.
 
#### **Factory Method**: 
Creează o instanță a mai multor clase derivate aparținând unei singure familii de obiecte . Ajută la crearea de obiecte într-o superclasă, dar permite și subclaselor
să modifice tipul de obiecte care sunt create. Putem ascunde existența claselor de utilizatorul final folosind modelul Factory Method.

#### **Abstract Factory**: 
Creează un obiect din mai multe familii de clase . Ne permite să producem familii de obiecte înrudite fără a specifica clasele lor concrete.

***In aceasta lucrare de laborator am creat un proiect in care am utilizat Singleton, Builder si Abstract Factory.***

Fisierul principal Program.cs conține metoda Main, care este punctul de intrare în aplicație. Acesta demonstrează utilizarea modelului de design Singleton,
   Builder și Abstract Factory prin crearea și utilizarea obiectelor din clasele School, Student și Teacher.
   
   Singleton: Clasa School este accesată folosind proprietatea School.Instance, care returnează instanța singleton a clasei. Proprietatea Instance este implementată 
folosind modelul de design Singleton pentru a asigura că se creează doar o singură instanță a clasei pe parcursul duratei de viață a aplicației.
   
   Builder: Clasa StudentBuilder este utilizată pentru a construi un obiect Student. Aceasta oferă o abordare pas cu pas pentru construirea unui obiect complex prin 
setarea proprietăților sale. StudentBuilder este responsabil pentru inițializarea proprietăților obiectului Student și returnarea obiectului construit.
   
   Abstract Factory: este utilizat în clasele Student și Teacher. Acest pattern este utilizat atunci când dorim să creăm o familie de obiecte care trebuie să fie 
compatibile între ele, astfel încât să putem utiliza aceleași metode sau proprietăți în toate obiectele create. În acest exemplu, clasa abstractă PersonFactory 
definește metodele pentru crearea obiectelor Student și Teacher, în timp ce clasa SchoolPersonFactory oferă implementarea concretă pentru aceste metode, creând 
obiecte Student și Teacher specifice unei școli. Acest pattern ne permite să schimbăm comportamentul de creare a obiectelor fără a afecta codul client.




