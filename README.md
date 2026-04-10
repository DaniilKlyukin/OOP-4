# Объектно-ориентированное программирование (4 семестр)

Учебный репозиторий для студентов 2 курса (4 семестр) направления **«Прикладная математика и информатика»**. Курс посвящен углубленному изучению принципов проектирования ПО, тестированию, многопоточности, асинхронности и технологии LINQ.

**Преподаватель:** Клюкин Даниил Анатольевич  
**Кафедра:** ПМиИТ  
**GitHub:** [DaniilKlyukin](https://github.com/DaniilKlyukin)

---

## 📚 Содержание лекций

| № | Тема | Ключевые концепции |
|:---:|:---|:---|
| 1 | **[Принципы проектирования](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B5%D0%BA%D1%86%D0%B8%D0%B8/%D0%9E%D0%9E%D0%9F%201%20%D0%BB%D0%B5%D0%BA%201.pptx)** | Отношения классов (Ассоциация, Композиция), SOLID, GRASP, чистый код. |
| 2 | **[Тестирование ПО](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B5%D0%BA%D1%86%D0%B8%D0%B8/%D0%9E%D0%9E%D0%9F%201%20%D0%BB%D0%B5%D0%BA%202.pptx)** | Модульные тесты (NUnit), паттерн AAA, Mock-объекты (библиотека Moq), TDD. |
| 3 | **[Контроль версий Git](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B5%D0%BA%D1%86%D0%B8%D0%B8/%D0%9E%D0%9E%D0%9F%201%20%D0%BB%D0%B5%D0%BA%203.pptx)** | Работа с ветками (`merge`, `rebase`), разрешение конфликтов, Pull Requests, GitHub Projects. |
| 4 | **[Многопоточность](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B5%D0%BA%D1%86%D0%B8%D0%B8/%D0%9E%D0%9E%D0%9F%201%20%D0%BB%D0%B5%D0%BA%204.pptx)** | Класс `Thread`, синхронизация (`lock`, `Monitor`), межпроцессная синхронизация (`Mutex`). |
| 5 | **[Параллельное программирование](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B5%D0%BA%D1%86%D0%B8%D0%B8/%D0%9E%D0%9E%D0%9F%201%20%D0%BB%D0%B5%D0%BA%205.pptx)** | TPL (`Task`), параллельные циклы (`Parallel.For`), отмена задач (`CancellationToken`). |
| 6 | **[Асинхронное программирование](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B5%D0%BA%D1%86%D0%B8%D0%B8/%D0%9E%D0%9E%D0%9F%201%20%D0%BB%D0%B5%D0%BA%206.pptx)** | Модель `async`/`await`, управление цепочками задач (`WhenAll`, `WhenAny`), отзывчивый UI. |
| 7 | **[Технология LINQ](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B5%D0%BA%D1%86%D0%B8%D0%B8/%D0%9E%D0%9E%D0%9F%201%20%D0%BB%D0%B5%D0%BA%207.pptx)** | Fluent API и Query Syntax, фильтрация, проекция (`Select`), группировка и агрегация. |

---

## 🧪 Лабораторные работы (ЛР)

| № | Тема | Задание (Docx) |
|:---:|:---|:---:|
| 1 | Основы совместной разработки. Система управления версиями Git | [Скачать ЛР №1](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D1%8B%D0%B5/%D0%9B%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0%201.docx) |
| 2 | Параллельное программирование и библиотека TPL | [Скачать ЛР №2](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D1%8B%D0%B5/%D0%9B%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0%202.docx) |
| 3 | Асинхронное программирование | [Скачать ЛР №3](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D1%8B%D0%B5/%D0%9B%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0%203.docx) |
| 4 | Коллекции данных и LINQ | [Скачать ЛР №4](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9B%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D1%8B%D0%B5/%D0%9B%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0%204.docx) |

---

## 📝 Практические работы (ПР)

| № | Тема | Задание (Docx) |
|:---:|:---|:---:|
| 1 | Unit-тестирование (NUnit) | [Скачать ПР №1](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9F%D1%80%D0%B0%D0%BA%D1%82%D0%B8%D0%BA%D0%B8/%D0%9F%D1%80%D0%B0%D0%BA%D1%82%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0%201.docx) |
| 2 | Параллельные вычисления | [Скачать ПР №2](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9F%D1%80%D0%B0%D0%BA%D1%82%D0%B8%D0%BA%D0%B8/%D0%9F%D1%80%D0%B0%D0%BA%D1%82%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0%202.docx) |
| 3 | Многопоточные расчеты | [Скачать ПР №3](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9F%D1%80%D0%B0%D0%BA%D1%82%D0%B8%D0%BA%D0%B8/%D0%9F%D1%80%D0%B0%D0%BA%D1%82%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0%203.docx) |
| 4 | Упражнения по LINQ | [Скачать ПР №4](https://github.com/DaniilKlyukin/OOP-1/blob/master/%D0%9F%D1%80%D0%B0%D0%BA%D1%82%D0%B8%D0%BA%D0%B8/%D0%9F%D1%80%D0%B0%D0%BA%D1%82%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0%204.docx) |

---

## 🛠 Инструменты и требования

*   **Среда разработки:** Visual Studio Community.
*   **Платформа:** .NET 8.0 / 9.0 / 10.0.
*   **Система контроля версий:** Git (используйте [GitHub Desktop](https://desktop.github.com/) или консоль).
*   **Библиотеки:** 
    *   NUnit (для тестирования).
    *   Moq (для создания имитаций).

---

## 🎓 Аттестация (4 семестр)

*   **Форма контроля:** Зачет.
*   **Условия допуска:** Защищенные лабораторные работы и отсутствие долгов по практике.
*   **Экзаменационные билеты:** [Просмотреть список вопросов](Билеты.docx).

---

## 📚 Литература

1.  **Рихтер Дж.** — «CLR via C#. Программирование на платформе .NET».
2.  **Мартин Р.** — «Чистый код: создание, анализ и рефакторинг».
3.  **Павловская Т. А.** — «C#. Программирование на языке высокого уровня».
4.  **Албахари Дж.** — «C# 12 in a Nutshell. The Definitive Reference».
5.  **Git Documentation:** [git-scm.com](https://git-scm.com/book/ru/v2).
