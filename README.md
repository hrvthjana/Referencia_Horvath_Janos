# Pontvadász ZH

## Windows Forms Application - User Interface

- **1x2p Az alkalmazásból a kilépés csak megerősítő kérdés után lehetséges:**
- **3x2p Olyan alkalmazás elrendezés, melyben gombok lenyomására UserControl-ok kerülnek elhelyezésre egy Panel vezérlőben, teljesen kitöltve azt. Minden gombra jár a pont, amennyiben az funckuonlalitással rendelkező UserControl-t tölt be** 
- **1x2p Anchorok alkalmazása: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület.**

### Tábla adatainak megjelenítése ListBox-ban

- **Adatok megjelenítése**
- **Ha az adatok tetszőleges módszerrel, pl. TextBox-on keresztül szűrhetőek.**

### Tábla adatainak megjelenítése DataGridView-ban

- **Adatok megjelenítése**
- **Ha a tábla idegen kulcsot is tartalmaz, melynek megjelenítése DataGridViewComboBoxColumn-on keresztül történik.**
- **Ha a tábla adatforrása saját osztály.**

### Adatkötés BindingSource-on keresztül

- **Működő BindingSource**

### Új rekord rögzítése

- **2x2p master-detail reláció detail táblájába ÉS/VAGY több-a-több kapcsolatban álló táblák kapcsolótáblájába**
- **1x1p Ha legalább egy nem kulcs mező, pl. Mennyiség is fel van véve**
- **1x2p Ellenőrzéshez kötött adatfelvitel (egyszerű validáció pl: String.IsNullOrEmpty())**
- **1x2p Felugró ablakon keresztül történik Ok és Mégse gombbal**
- **1x2p Ha az űrlap legördülő dobozon vagy listán keresztül beállítható idegen kulcsot is tartalmaz**
- **2x1p A kitöltési hiba ErrorProvider-en keresztül kerülnek köközlésre a felhasználóval, hibás kitöltés esetén nem enged rányomni az Ok gombra**
- **1x2p Regex alapú validáció**
- **1x1p Hibás kitöltés esetén nem lehet megynomni az Ok gombot.**

### Rekord törlése

- **1x2p Sikeres törlés**
- **1x2p Megerősítéshez kötött törlés**

### Diagram rajzolása, Excel munkafüzet generálása

- **5x1p Tetszőleges diagram rajzolása**
- **1x2p A diagram adatforrása tetszőleges módszerrel szűrhető**

### Saját Adatbázis

- **3x1p Az alkalmazásban használt táblánként pont**
- **1x1p Az adatbázis tartalmaz Constraint-eket (min 2)**
- **1x1p Az adatbázis adatainak forrásmegjelölése értsd: miből készült és hogyan**
- **2x2p Az adatbázis saját Azure SQL szerveren van**

### Egyéb, extra

- **1x1p Scaffold-DbContext használata (ajándék)**

