--
-- Файл сгенерирован с помощью SQLiteStudio v3.0.6 в Пт Жов 2 14:51:59 2015
--
-- Использованная кодировка текста: windows-1251
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Таблица: TOWNS
CREATE TABLE TOWNS (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,ID_TOWN VARCHAR(5),TOWN VARCHAR(100),REGION_ID INTEGER);

-- Таблица: DOKTORS
CREATE TABLE DOKTORS (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, FIO VARCHAR (50));

-- Таблица: DS
CREATE TABLE DS (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, NAZV  VARCHAR(100));

-- Таблица: LICENSES
CREATE TABLE LICENSES (ORGANISATION  VARCHAR(100), DEPARTMENT VARCHAR(100), NAZV_LKK VARCHAR(100),PERSON VARCHAR(100), SN VARCHAR(50));

-- Таблица: MEMBERS_LKK
CREATE TABLE MEMBERS_LKK (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, FIO VARCHAR(100), ACTIVE BOOLEAN);

-- Таблица: DEPARTMENTS
CREATE TABLE DEPARTMENTS(KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, NAZV VARCHAR(50));

-- Таблица: REGIONS
CREATE TABLE REGIONS (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, NAZV  VARCHAR(50));

-- Таблица: LKK
CREATE TABLE LKK (ID INTEGER NOT NULL PRIMARY KEY, DATA_LKK DATE, NOMER_PROT VARCHAR (20), OTDELENIE VARCHAR (50), DOKTOR VARCHAR (50), FIO VARCHAR (100), GOD_B INTEGER, AGE INTEGER, REGION VARCHAR (50), TOWN VARCHAR (100), ADDRESS VARCHAR (200), ADDR_RABOTA VARCHAR (200), DOLGNOST VARCHAR (200), DS_OSN VARCHAR (2000), LKK VARCHAR (2000), MSEK VARCHAR (2000), PRIMECHANIE VARCHAR (2000), SEX CHAR (2), STATUS INTEGER);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (2, '2005-03-03', '9', 'поліклініка', 'Слободянюк ', 'Лисий Михайло Іванович', 1966, 42, 'Хмільницький', 'с. Курилівка', NULL, 'не працює', NULL, 'Цукровий діабет панкреатогенного генезу, середньої важкості, ст. субкомпенсації. Гепатоз. Діабетична ангіопатія ніг ІІІ ст. Ішемія І ст. Діабетична дистальна сенсорна поліневропатія ніг, початкова ст.. Хронічний панкреатит в ст. ремісії. Слабка міопія обох очей. ІХС. Атеросклеротичний міокардіосклероз, коронаросклероз. СН0.', 'Направляється на консультацію МСЕК', NULL, NULL, 'ч ', 0);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (4, '2009-03-04', '9', 'терапевтичне №1', 'Тромпінська', 'Новохацька Антоніна Олегівна', 1999, 9, 'Вінницький', 'м. Вінниця', 'І пров. Стахановський, 3', 'ЗОШ', 'учениця', 'Цукровий діабет, 1 тип, глікемічний контроль з високим ризиком, вперше виявлений. Діабетичний кетоз. Діабетичний гепатоз. Дефіцити маси тіла', 'Направляється на ЛКК за місцем проживання  згідно Наказу МОЗ України № 454/471/516 від 08.11.01р. РІІ п.3,пп.3.3, що дає право на отримання соціальної допомоги строком до 18-річного віку', NULL, NULL, 'ж ', 0);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (5, '2009-03-04', '9', 'терапевтичне №1', 'Тромпінська', 'Жереб Віктор Володимирович', 1992, 16, 'Ямпільський', 'с. Довжок', NULL, 'ЗОШ', 'учень', 'Синдром Нунан. Субнанізм. Затримка статевого розвитку. Пролапс мітрального клапану І ст.', 'Направляється на ЛКК за місцем проживання згідно Наказу МОЗ україни №454/471/516 від 08.11.01р. Р XXI, п. 3, пп.3.25.,Q87,1 що дає право на отримання соціальної допомоги строком ло 18-річного віку.', NULL, NULL, 'ч ', 0);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (7, '2009-03-04', '9', 'терапевтичне №2', 'Отдєлок', 'Смішний Петро Олексійович', 1957, 51, 'Крижопільський', 'м. Крижопіль', 'вул. Котовського, 3', 'не працює', NULL, 'Цукровий діабет тип 2 , важка форма, в стадії субкомпенсації. Діабетичний гепатоз. Непроліферативна діабетична ретинопатія, макулопатія. Початкова катаракта обох очей. Діабетична ангіопатія ніг ІІІ ст. Невропатична стопа 0 ст.Діабетична дистальна сенсорна поліневропатія ніг, явна ст.Діабетична нефропатія ІV ст.Діабетична автономна невропатія серця. ІХС. Післяінфарктний кардіосклероз. Стенокардія напруги ІІ ФК. Гіпертонічна хвороба ІІІ ст. (перенесений ІМ) Г іпертензивне серце . СН І ст. ФК ІІ. Дисциркуляторна енцефалопатія змішаного (ЧМТ, ЦД, ГХ,  атеросклероз) генезу І ст. Ожиріння І ст. аліментарно-конституційного ґенезу, стабільний перебіг. Розповсюджений  остеохондроз хребта, цефалгія. Змішаний нетоксичний зоб І ст.', 'Направляється на МСЕК', NULL, NULL, 'ч ', 0);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (8, '2009-03-04', '9', 'терапевтичне №2', 'Отдєлок', 'Смішний Петро Олексійович', 1957, 51, 'Крижопільський', 'м. Крижопіль', 'вул. Котовського, 3', 'не працює', NULL, 'Цукровий діабет тип 2 , важка форма, в стадії субкомпенсації. Діабетичний гепатоз. Непроліферативна діабетична ретинопатія, макулопатія. Початкова катаракта обох очей. Діабетична ангіопатія ніг ІІІ ст. Невропатична стопа 0 ст.Діабетична дистальна сенсорна поліневропатія ніг, явна ст.Діабетична нефропатія ІV ст.Діабетична автономна невропатія серця. ІХС. Післяінфарктний кардіосклероз. Стенокардія напруги ІІ ФК. Гіпертонічна хвороба ІІІ ст. (перенесений ІМ) Г іпертензивне серце . СН І ст. ФК ІІ. Дисциркуляторна енцефалопатія змішаного (ЧМТ, ЦД, ГХ,  атеросклероз) генезу І ст. Ожиріння І ст. аліментарно-конституційного ґенезу, стабільний перебіг. Розповсюджений  остеохондроз хребта, цефалгія. Змішаний нетоксичний зоб І ст.', 'Направляється на МСЕК', NULL, NULL, 'ч ', 0);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (167, '2009-04-14', '21', 'поліклініка', 'Огороднік', 'Дзюбенко Андрій Олександрович', 1990, 18, 'Тростянецький', NULL, 'вул. Процишина 7/2, кв. 94', 'не працює', NULL, 'Первинний гіпогонадизм.', ' Направляється на МСЕК.', NULL, NULL, 'ч ', 0);

-- Таблица: VIV_LKK
CREATE TABLE VIV_LKK (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, VIVOD VARCHAR(1000));

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
