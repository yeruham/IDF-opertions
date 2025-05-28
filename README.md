# 🪖 IDF Operations

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

