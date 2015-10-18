--
-- ���� ������������ � ������� SQLiteStudio v3.0.6 � �� ��� 2 14:51:59 2015
--
-- �������������� ��������� ������: windows-1251
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- �������: TOWNS
CREATE TABLE TOWNS (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,ID_TOWN VARCHAR(5),TOWN VARCHAR(100),REGION_ID INTEGER);

-- �������: DOKTORS
CREATE TABLE DOKTORS (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, FIO VARCHAR (50));

-- �������: DS
CREATE TABLE DS (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, NAZV  VARCHAR(100));

-- �������: LICENSES
CREATE TABLE LICENSES (ORGANISATION  VARCHAR(100), DEPARTMENT VARCHAR(100), NAZV_LKK VARCHAR(100),PERSON VARCHAR(100), SN VARCHAR(50));

-- �������: MEMBERS_LKK
CREATE TABLE MEMBERS_LKK (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, FIO VARCHAR(100), ACTIVE BOOLEAN);

-- �������: DEPARTMENTS
CREATE TABLE DEPARTMENTS(KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, NAZV VARCHAR(50));

-- �������: REGIONS
CREATE TABLE REGIONS (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, NAZV  VARCHAR(50));

-- �������: LKK
CREATE TABLE LKK (ID INTEGER NOT NULL PRIMARY KEY, DATA_LKK DATE, NOMER_PROT VARCHAR (20), OTDELENIE VARCHAR (50), DOKTOR VARCHAR (50), FIO VARCHAR (100), GOD_B INTEGER, AGE INTEGER, REGION VARCHAR (50), TOWN VARCHAR (100), ADDRESS VARCHAR (200), ADDR_RABOTA VARCHAR (200), DOLGNOST VARCHAR (200), DS_OSN VARCHAR (2000), LKK VARCHAR (2000), MSEK VARCHAR (2000), PRIMECHANIE VARCHAR (2000), SEX CHAR (2), STATUS INTEGER);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (2, '2005-03-03', '9', '��������', '���������� ', '����� ������� ��������', 1966, 42, '�����������', '�. ��������', NULL, '�� ������', NULL, '�������� ����� ���������������� ������, �������� �������, ��. ��������������. �������. ĳ�������� �������� �� ��� ��. ����� � ��. ĳ�������� ��������� �������� ������������ ��, ��������� ��.. �������� ���������� � ��. ����. ������ ���� ���� ����. ���. ����������������� ��������������, ���������������. ��0.', '������������� �� ������������ ����', NULL, NULL, '� ', 0);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (4, '2009-03-04', '9', '������������ �1', '����������', '���������� ������� �������', 1999, 9, '³��������', '�. ³�����', '� ����. �������������, 3', '���', '�������', '�������� �����, 1 ���, ��������� �������� � ������� �������, ������ ���������. ĳ��������� �����. ĳ��������� �������. �������� ���� ���', '������������� �� ��� �� ����� ����������  ����� ������ ��� ������ � 454/471/516 �� 08.11.01�. в� �.3,��.3.3, �� �� ����� �� ��������� ��������� �������� ������� �� 18-������ ���', NULL, NULL, '� ', 0);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (5, '2009-03-04', '9', '������������ �1', '����������', '����� ³���� �������������', 1992, 16, '����������', '�. ������', NULL, '���', '�����', '������� �����. ��������. �������� ��������� ��������. ������� ���������� ������� � ��.', '������������� �� ��� �� ����� ���������� ����� ������ ��� ������ �454/471/516 �� 08.11.01�. � XXI, �. 3, ��.3.25.,Q87,1 �� �� ����� �� ��������� ��������� �������� ������� �� 18-������ ���.', NULL, NULL, '� ', 0);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (7, '2009-03-04', '9', '������������ �2', '������', '������ ����� ����������', 1957, 51, '�������������', '�. ��������', '���. �����������, 3', '�� ������', NULL, '�������� ����� ��� 2 , ����� �����, � ���䳿 ��������������. ĳ��������� �������. ��������������� ��������� ����������, ����������. ��������� ��������� ���� ����. ĳ�������� �������� �� ��� ��. ������������ ����� 0 ��.ĳ�������� ��������� �������� ������������ ��, ���� ��.ĳ�������� ��������� �V ��.ĳ�������� ��������� ��������� �����. ���. ϳ������������� ������������. ���������� ������� �� ��. ó��������� ������� ��� ��. (����������� ��) � ������������ ����� . �� � ��. �� ��. ��������������� ������������ �������� (���, ��, ��,  ������������) ������ � ��. ������� � ��. ����������-��������������� ������, ��������� ������. ��������������  ������������ ������, �������. ������� ����������� ��� � ��.', '������������� �� ����', NULL, NULL, '� ', 0);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (8, '2009-03-04', '9', '������������ �2', '������', '������ ����� ����������', 1957, 51, '�������������', '�. ��������', '���. �����������, 3', '�� ������', NULL, '�������� ����� ��� 2 , ����� �����, � ���䳿 ��������������. ĳ��������� �������. ��������������� ��������� ����������, ����������. ��������� ��������� ���� ����. ĳ�������� �������� �� ��� ��. ������������ ����� 0 ��.ĳ�������� ��������� �������� ������������ ��, ���� ��.ĳ�������� ��������� �V ��.ĳ�������� ��������� ��������� �����. ���. ϳ������������� ������������. ���������� ������� �� ��. ó��������� ������� ��� ��. (����������� ��) � ������������ ����� . �� � ��. �� ��. ��������������� ������������ �������� (���, ��, ��,  ������������) ������ � ��. ������� � ��. ����������-��������������� ������, ��������� ������. ��������������  ������������ ������, �������. ������� ����������� ��� � ��.', '������������� �� ����', NULL, NULL, '� ', 0);
INSERT INTO LKK (ID, DATA_LKK, NOMER_PROT, OTDELENIE, DOKTOR, FIO, GOD_B, AGE, REGION, TOWN, ADDRESS, ADDR_RABOTA, DOLGNOST, DS_OSN, LKK, MSEK, PRIMECHANIE, SEX, STATUS) VALUES (167, '2009-04-14', '21', '��������', '��������', '�������� ����� �������������', 1990, 18, '�������������', NULL, '���. ��������� 7/2, ��. 94', '�� ������', NULL, '��������� �����������.', ' ������������� �� ����.', NULL, NULL, '� ', 0);

-- �������: VIV_LKK
CREATE TABLE VIV_LKK (KOD INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, VIVOD VARCHAR(1000));

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
