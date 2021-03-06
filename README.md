# TestWEB-CRMGURU
Нужно сделать приложение, в котором пользователь по введенной стране будет получать по ней
информацию (Название, Код страны, Столица, Площадь, Население, Регион). Как вариант можно
использовать https://restcountries.eu/rest/v2/name/Ukraine либо другое API на ваш вкус.
Требования к заданию:
1. При запуске приложения должно быть 2 функциональности на выбор пользователя: Ввод
названия страны; вывод всех стран с БД. После ввода страны должно выдать информацию о
стране (Название, Код страны, Столица, Площадь, Население, Регион) либо если страна не
найдена выдать об этом сообщение.
2. Далее выдать предложение пользователю сохранить информацию в базу (MS SQL). Если
пользователь отказывается - не сохранять.
a. В БД должно быть 3 таблицы: Регионы(Id - идентификатор, Название - строка),
Города(Id - идентификатор, Название - строка), Страны – (Id - идентификатор, Название
– строка, Код страны – строка, Столица – идентификатор с таблицы Города, площадь –
дробное число, Население – целое число, Регион – идентификатор с таблицы Регионы)
b. Алгоритм добавления, следующий:
i. проверяем наличие Столицы в таблице Города, если найдена, то берем её
идентификатор, если нет, то добавляем;
ii. проверяем наличие Региона в таблице Регионов, если найден, то берем его
идентификатор, если нет, то добавляем;
iii. Проверяем наличие Страны в таблице стран по коду страны, если
страна не найдена – добавляем с идентификаторами, полученными выше,
если найдена обновляем значения.

3. При выборе вывода всех стран БД должен вывестись список всех стран в БД со следующими
полями: Название, Код страны, Столица, Площадь, Население, Регион. Прошу обратить
внимание, что Столицу и Регион тут нужно выводить название.
Требования к приложению:
1. Реализация на C#. Варианты реализации произвольные.
2. Получение информации по введенной стране через стороннее API.
3. Должен максимально соответствовать принципам SOLID
.(https://metanit.com/sharp/patterns/5.1.php).
4. Нужно реализовать обработку ошибок.
5. Библиотека для работы с БД на ваше усмотрение.
6. Должен работать с БД MS SQL.
7. Удобно редактируемый конфиг с подключением к БД внутри приложения.
8. Читабельный код.

Скриншоты реализации:

Стартовая страница

![Screenshot](https://github.com/dalaran111/TestWEB-CRMGURU/blob/master/Screenshots/HomePage.png)

Поиск страны по названию:

![Screenshot](https://github.com/dalaran111/TestWEB-CRMGURU/blob/master/Screenshots/Search.png)

Поиск страны с помощью API:

![Screenshot](https://github.com/dalaran111/TestWEB-CRMGURU/blob/master/Screenshots/Search%20via%20API.png)

Вывод всех стран из базы данных:

![Screenshot](https://github.com/dalaran111/TestWEB-CRMGURU/blob/master/Screenshots/AllCountriesFromDB.png)

Уведомление о том, что страна не найдена:

![Screenshot](https://github.com/dalaran111/TestWEB-CRMGURU/blob/master/Screenshots/Country%20nof%20found.png)
