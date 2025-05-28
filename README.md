# 🪖 IDF Operations


![IDF Strike](https://raw.githubusercontent.com/yeruham/IDF-opertions/master/ChatGPT%20Image%20May%2028,%202025,%2012_02_38%20PM.png)

מערכת המדמה מבצע צבאי של צה"ל, תוך שימוש בכלי נשק, מטוסים, מל"טים ויחידות לוחמה שונות.

---

## 📁 מבנה הפרויקט

- **Interfaces**:
  - `Iweapon.cs`: מגדיר תכונות בסיסיות לכלי נשק.
  - `IBomberWeapon.cs`: מגדיר תכונות ייחודיות לכלי הפצצה.
  - `Ifighter.cs`: מגדיר תכונות ללוחמים.
  - `Iorganization.cs`: מגדיר תכונות לארגונים.

- **Classes**:
  -  `Artillery.cs`,`Drone.cs`, `plane.cs`: מייצגות כלי תקיפה שונים.
  - `F16.cs`, `Zik.cs`, `Cannon.cs`, `Knife.cs`, `Rifle.cs`: מייצגות סוגי כלי נשק.
  - `Hamas.cs`, `AMAN.cs`: מייצגות ארגונים.
  - `IDFfirePower.cs`: מנהלת את כוח האש של צה"ל.
  - `command.cs`: מנהלת פקודות.
  - `Menu.cs`: מנהלת את תפריט המשתמש.
  - `Program.cs`: נקודת הכניסה הראשית של התוכנית.

---
## 🔍 הסבר על מחלקות ופונקציות

### `Iweapon.cs`

- **מטרה**: אינטרפייס המגדיר תכונות בסיסיות לכלי נשק.
- **תכונות**:
  - `Name`: שם הנשק.
  - `PowerLevel`: רמת העוצמה של הנשק.
  - `EffectiveFor`: סוג היעד שהנשק יעיל נגדו.

### `IBomberWeapon.cs`

- **מטרה**: אינטרפייס המגדיר תכונות ייחודיות לכלי הפצצה.
- **תכונות**:
  - `Bombweight`: משקל הפצצה.
  - `BombsAtOnce`: מספר הפצצות שניתן לשחרר בו זמנית.
  - `FuelSupply`: כמות הדלק.
  - `BombBalance`: איזון הפצצות.

### `Ifighter.cs`

- **מטרה**: אינטרפייס המגדיר תכונות ללוחמים.
- **תכונות**:
  - `Name`: שם הלוחם.
  - `Weapon`: הנשק שבשימוש הלוחם.

### `Iorganization.cs`

- **מטרה**: אינטרפייס המגדיר תכונות לארגונים.
- **תכונות**:
  - `Name`: שם הארגון.
  - `Fighters`: רשימת הלוחמים בארגון.

### `plane.cs`

- **מטרה**: מחלקת בסיס לכלי טיס.
- **תכונות**:
  - `Name`, `PowerLevel`, `EffectiveFor`, `Bombweight`, `BombsAtOnce`, `FuelSupply`, `BombBalance`.

### `F16.cs`

- **מטרה**: מחלקה המייצגת מטוס F16.
- **ירושה**: יורשת מ-`plane`.

### `Drone.cs`

- **מטרה**: מחלקת בסיס למל"טים.
- **תכונות**:
  - `Name`, `PowerLevel`, `EffectiveFor`.

### `Zik.cs`

- **מטרה**: מחלקה המייצגת מל"ט מסוג זיק.
- **ירושה**: יורשת מ-`Drone`.

### `Artillery.cs`, `Cannon.cs`, `Knife.cs`, `Rifle.cs`

- **מטרה**: מחלקות המייצגות סוגי כלי נשק שונים.
- **ירושה**: מממשות את האינטרפייס `Iweapon`.

### `Hamas.cs`, `AMAN.cs`

- **מטרה**: מחלקות המייצגות ארגונים שונים.
- **ירושה**: מממשות את האינטרפייס `Iorganization`.

### `IDFfirePower.cs`

- **מטרה**: מחלקה המנהלת את כוח האש של צה"ל.
- **תכונות**:
  - `Weapons`: רשימת כלי הנשק.
- **פונקציות**:
  - `AddWeapon(Iweapon weapon)`: מוסיפה נשק לרשימה.
  - `CalculateTotalPower()`: מחשבת את העוצמה הכוללת של כל הנשקים.

### `command.cs`

- **מטרה**: מחלקה המנהלת פקודות.
- **פונקציות**:
  - `ExecuteAttack(Iorganization target)`: מבצעת תקיפה על ארגון יעד.

### `Menu.cs`

- **מטרה**: מחלקה המנהלת את תפריט המשתמש.
- **פונקציות**:
  - `DisplayMainMenu()`: מציגה את התפריט הראשי.
  - `HandleUserSelection()`: מטפלת בבחירת המשתמש.

### `Program.cs`

- **מטרה**: נקודת הכניסה הראשית של התוכנית.
- **פונקציה**:
  - `Main(string[] args)`: מפעילה את התוכנית ומציגה את התפריט הראשי.

---

## 🔧 הוראות שימוש

1. **התקנה**:
   - ודא שיש לך את .NET Framework מותקן.
   - פתח את הקובץ `IDF opertions.sln` באמצעות Visual Studio.

2. **הרצה**:
   - הפעל את התוכנית דרך Visual Studio או באמצעות קובץ ההרצה שנוצר.

---

## 🧠 עקרונות OOP בשימוש

- **Encapsulation**: שמירה על פרטיות המשתנים באמצעות `private` וחשיפה באמצעות `public` לפי הצורך.
- **Inheritance**: ירושת תכונות והתנהגויות בין מחלקות, לדוגמה, `F16` יורש מ-`plane`.
- **Polymorphism**: מימוש שונה של מתודות זהות במחלקות שונות.
- **Abstraction**: שימוש באינטרפייסים כדי להגדיר חוזים למחלקות.

---

## 🔧 הוראות שימוש

1. **התקנה**:
   - ודא שיש לך את .NET Framework מותקן.
   - פתח את הקובץ `IDF opertions.sln` באמצעות Visual Studio.

2. **הרצה**:
   - הפעל את התוכנית דרך Visual Studio או באמצעות קובץ ההרצה שנוצר.

---

## 🧠 עקרונות OOP בשימוש

- **Encapsulation**: שמירה על פרטיות המשתנים באמצעות `private` וחשיפה באמצעות `public` לפי הצורך.
- **Inheritance**: ירושת תכונות והתנהגויות בין מחלקות, לדוגמה, `F16` יורש מ-`plane`.
- **Polymorphism**: מימוש שונה של מתודות זהות במחלקות שונות.
- **Abstraction**: שימוש באינטרפייסים כדי להגדיר חוזים למחלקות.

---

## 📸 תמונות

*ניתן להוסיף תמונות או דיאגרמות כאן להמחשת מבנה המערכת או תוצאות הריצה.*

---

## 📄 רישיון

קוד פתוח לשימוש חופשי למטרות לימוד ופיתוח.

