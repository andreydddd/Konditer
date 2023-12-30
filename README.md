**Рукенглаз Андрей Алексеевич**
===============================
Группа: ИП-20-7К
-------------------------------
Тема: Web Api-Кондитерская
-------------------------------
![image](https://github.com/andreydddd/Konditer/assets/104488789/c631dfe6-7611-4b6f-8117-1d748d1ed160)
-------------------------------
```mermaid
erDiagram
    Pokupatel ||--o{ Nakladnaya : places
    Pokupatel {
        string Name
        int Number
    }
  
    Nakladnaya {
        int PokupatelId
        string Name
        string Description
    }
  Tovar ||--o{ Nakladnaya: is
    Tovar {
        string Name
        string Opis
        int Value
    }
 Postavshik ||--o{ Nakladnaya: is
  Postavshik {
    string Name
    string Adres
    int Number
    int Inn
    string Email
    int Index
    int RS
   }
Sushnost ||--o{ Nakladnaya: is
Sushnost {
string Name
int Price
}
```
