USE MASTER
GO
IF EXISTS(SELECT NAME FROM sys.databases WHERE NAME = 'AR_EL_Travail_1')
DROP DATABASE AR_EL_Travail_1

CREATE DATABASE AR_EL_Travail_1
GO

USE AR_EL_Travail_1
GO

CREATE PROCEDURE Ajouter_Essence
@Nom_Essence nvarchar(100)
AS
IF not exists(select Nom from tbl_Essences_Arbre where Nom = @Nom_Essence)
INSERT INTO Tbl_Essences_Arbre(Nom)
VALUES (@Nom_Essence)
ELSE
return (99)
GO

CREATE PROCEDURE Modifier_Essence
@Ancien_Nom_Essence nvarchar(100),
@Nouveau_Nom_Essence nvarchar(100)
AS
IF  exists(select Nom from tbl_Essences_Arbre where Nom = @Ancien_Nom_Essence)
UPDATE tbl_Essences_Arbre
SET Nom = @Nouveau_Nom_Essence
WHERE Nom = @Ancien_Nom_Essence
RETURN (94)
GO

CREATE PROCEDURE Ajout_Entente
@Nom_Fournisseur NVARCHAR(100),
@Nom_Essence NVARCHAR(100), 
@Annee_Entente INT,
@Prix MONEY,
@Quantite_Disponible INT
AS
IF not exists(SELECT no_Items from tbl_Items where No_Fournisseur=(SELECT No_Fournisseur FROM tbl_Fournisseur WHERE Nom = @Nom_Fournisseur)and No_Essences_Arbre=(SELECT No_Essences_Arbre FROM tbl_Essences_Arbre WHERE Nom = @Nom_Essence)and Annee_Entente=(SELECT Annee_Entente FROM tbl_Items WHERE Annee_Entente = @Annee_Entente and No_Fournisseur=(SELECT No_Fournisseur FROM tbl_Fournisseur WHERE Nom = @Nom_Fournisseur)and No_Essences_Arbre=(SELECT No_Essences_Arbre FROM tbl_Essences_Arbre WHERE Nom = @Nom_Essence)) )
INSERT INTO Tbl_Items(Prix, Quantite_Disponible, Annee_Entente, No_Fournisseur, No_Essences_Arbre)
VALUES (@Prix, @Quantite_Disponible, @Annee_Entente, (SELECT No_Fournisseur FROM tbl_Fournisseur WHERE Nom = @Nom_Fournisseur), (SELECT No_Essences_Arbre FROM tbl_Essences_Arbre WHERE Nom = @Nom_Essence))
ELSE
RETURN(98)
GO

CREATE PROCEDURE Detruire_Essence
@Nom_Essence nvarchar(100)
AS
IF NOT EXISTS (SELECT No_Essences_Arbre from tbl_Essences_Arbre where Nom = @Nom_Essence)
RETURN (95) 
ELSE IF not exists(SELECT no_Items from tbl_Items where No_Essences_Arbre= (SELECT No_Essences_Arbre from tbl_Essences_Arbre where Nom = @Nom_Essence))
DELETE FROM Tbl_Essences_Arbre
WHERE Nom = @Nom_Essence
ELSE
RETURN (97) 
GO

CREATE PROCEDURE Ajouter_Fournisseur
@Nom_Fournisseur nvarchar(100)
AS
IF not exists(select No_Fournisseur from tbl_Fournisseur where Nom = @Nom_Fournisseur)
INSERT INTO tbl_Fournisseur
VALUES (@Nom_Fournisseur)
ELSE
RETURN (96)
GO
/*
declare @error int 
exec @error = Ajout_Entente 'Allo','Sapin',2019,10.00,100
select @error

select * from tbl_Items
*/
CREATE TABLE tbl_Client(
	No_Client INT not null PRIMARY KEY IDENTITY,
	Nom NVARCHAR(100) not null DEFAULT 'inconnue',
	Prenom NVARCHAR(100) not null DEFAULT 'inconnue',
	Telephone NVARCHAR(100) not null DEFAULT 'inconnue'
	)
GO

/*Toute les insctructions dans le create (Numero 3)*/
CREATE TABLE tbl_Reservation(
	No_Reservation INT not null PRIMARY KEY IDENTITY,
	Date_Reservation DATE null DEFAULT GETDATE(),
	Prix_Total MONEY not null,
	No_Client INT not null FOREIGN KEY REFERENCES tbl_Client(No_Client) ON UPDATE CASCADE,	 
	)
GO

CREATE TABLE tbl_Fournisseur(
	No_Fournisseur INT not null PRIMARY KEY IDENTITY,
	Nom NVARCHAR(100) not null UNIQUE
	)
GO

/*D�finie dans le create avec 2 alter table (Numero 4)*/
CREATE TABLE tbl_Essences_Arbre(
	No_Essences_Arbre INT not null IDENTITY,
	Nom NVARCHAR(100) not null 
	)
GO

ALTER TABLE	tbl_Essences_Arbre
ADD CONSTRAINT PK_No_Essences_Arbre PRIMARY KEY (No_Essences_Arbre),
	CONSTRAINT UN_Nom_Essences UNIQUE(Nom)
GO

/*Toute les insctructions dans le create (Numero 3)*/
CREATE TABLE tbl_Items(
	No_Items INT not null PRIMARY KEY IDENTITY,
	Prix MONEY not null,
	Quantite_Disponible int not null,
	Annee_Entente INT /*CHECK (Annee_Entente >= Year(getDate()))*/,
	No_Fournisseur INT not null FOREIGN KEY REFERENCES tbl_Fournisseur(No_Fournisseur) ON UPDATE CASCADE,
	No_Essences_Arbre INT not null FOREIGN KEY REFERENCES tbl_Essences_Arbre(No_Essences_Arbre) ON UPDATE CASCADE UNIQUE (No_Fournisseur, No_Essences_Arbre, Annee_Entente)
	
	)
GO
ALTER TABLE tbl_Items
ADD CONSTRAINT CK_Annee_entente CHECK (Annee_Entente >= Year(getDate()))
GO

/*D�finie dans le create avec plusieurs alter table (Numero 4)*/
CREATE TABLE tbl_Reservation_Par_Items(
	No_Reservation INT not null, 
	No_Items INT not null,
	Quantite INT null,
	Livree NVARCHAR(100) null 
	)
GO

ALTER TABLE tbl_Reservation_Par_Items
ADD CONSTRAINT PK_No_Reservation_No_Items PRIMARY KEY (No_Reservation, No_Items),
	CONSTRAINT FK_No_Reservation FOREIGN KEY (No_Reservation) REFERENCES tbl_Reservation(No_Reservation) ON UPDATE CASCADE ON DELETE CASCADE, 
	CONSTRAINT FK_No_Items FOREIGN KEY (No_Items) REFERENCES tbl_Items(No_Items) ON UPDATE CASCADE,
	CONSTRAINT DEF_Livree DEFAULT 'Non' FOR Livree,
	CONSTRAINT CK_Livree_Status CHECK (Livree in ('Oui','Non')),
	CONSTRAINT CK_Quantite CHECK (Quantite > 0 and Quantite < 100)
GO

ALTER TABLE tbl_Reservation_Par_Items ALTER COLUMN Quantite INT not null /*champs null � not null (Num�ro 9)*/
GO

INSERT INTO tbl_Client(nom,prenom,Telephone)
SELECT nom, prenom, telephone
FROM lt_classe.dbo.etudiants
GO

INSERT INTO tbl_Client(Nom,Prenom,Telephone)
VALUES('Morin','William','418-555-5555')
GO

INSERT INTO	tbl_Fournisseur(Nom)
VALUES('P�pini�re Verdoyante'),
	  ('Grande r�colte')
GO

INSERT INTO tbl_Essences_Arbre(Nom)
VALUES('Sapin'),
	  ('Bouleau'),
	  ('Tremble')
GO

INSERT INTO tbl_Items(Prix,Quantite_Disponible,Annee_Entente,No_Fournisseur,No_Essences_Arbre)
VALUES(0,'100','2019',(select No_Fournisseur from tbl_Fournisseur where Nom ='P�pini�re Verdoyante'),(select No_Essences_Arbre from tbl_Essences_Arbre where Nom ='Sapin')),
	  (0,'50','2019',(select No_Fournisseur from tbl_Fournisseur where Nom ='P�pini�re Verdoyante'),(select No_Essences_Arbre from tbl_Essences_Arbre where Nom ='Tremble')),
	  (0,'15','2019',(select No_Fournisseur from tbl_Fournisseur where Nom ='Grande r�colte'),(select No_Essences_Arbre from tbl_Essences_Arbre where Nom ='Bouleau'))
GO

INSERT INTO tbl_Reservation(Date_Reservation,Prix_Total,No_Client)
VALUES('28/01/19',0,(Select No_Client from tbl_Client where Prenom= 'William'and Nom= 'Morin')),
	  ('29/01/19',0,(Select No_Client from tbl_Client where Prenom= 'Chloe'and Nom= 'Noel'and Telephone='222-212-1212'))
GO
INSERT INTO tbl_Reservation_Par_Items(No_Reservation,No_Items,Quantite,Livree)
VALUES((select no_Reservation from tbl_Reservation where (No_Client =(Select No_Client from tbl_Client where Prenom= 'William'and Nom= 'Morin'and Telephone='418-555-5555'))),(select No_Items from tbl_Items where(No_Essences_Arbre=(select No_Essences_Arbre from tbl_Essences_Arbre where Nom='Sapin'and (No_Fournisseur=(Select No_Fournisseur from tbl_Fournisseur where Nom = 'P�pini�re Verdoyante'))))),3,'non'),	  
	  ((select no_Reservation from tbl_Reservation where (No_Client =(Select No_Client from tbl_Client where Prenom= 'William'and Nom= 'Morin'and Telephone='418-555-5555'))),(select No_Items from tbl_Items where(No_Essences_Arbre=(select No_Essences_Arbre from tbl_Essences_Arbre where Nom='Bouleau'and (No_Fournisseur=(Select No_Fournisseur from tbl_Fournisseur where Nom = 'Grande r�colte'))))),2,'non'),
	  ((select no_Reservation from tbl_Reservation where (No_Client =(Select No_Client from tbl_Client where Prenom= 'William'and Nom= 'Morin'and Telephone='418-555-5555'))),(select No_Items from tbl_Items where(No_Essences_Arbre=(select No_Essences_Arbre from tbl_Essences_Arbre where Nom='Tremble'and (No_Fournisseur=(Select No_Fournisseur from tbl_Fournisseur where Nom = 'P�pini�re Verdoyante'))))),5,'non'),	  
	  ((select no_Reservation from tbl_Reservation where (No_Client =(Select No_Client from tbl_Client where Prenom= 'Chloe'and Nom= 'Noel'and Telephone='222-212-1212'))),(select No_Items from tbl_Items where(No_Essences_Arbre=(select No_Essences_Arbre from tbl_Essences_Arbre where Nom='Sapin'and (No_Fournisseur=(Select No_Fournisseur from tbl_Fournisseur where Nom = 'P�pini�re Verdoyante'))))),2,'non')
GO

SELECT        tbl_Client.No_Client, tbl_Client.Nom, tbl_Client.Prenom, tbl_Client.Telephone, tbl_Essences_Arbre.No_Essences_Arbre, tbl_Essences_Arbre.Nom AS Expr1, tbl_Fournisseur.No_Fournisseur, tbl_Fournisseur.Nom AS Expr2, 
                         tbl_Reservation_Par_Items.No_Reservation, tbl_Reservation_Par_Items.No_Items, tbl_Reservation_Par_Items.Quantite, tbl_Reservation_Par_Items.Livree, tbl_Reservation.Date_Reservation, tbl_Reservation.Prix_Total, 
                         tbl_Items.Prix, tbl_Items.Quantite_Disponible
FROM            tbl_Reservation INNER JOIN
                         tbl_Client ON tbl_Reservation.No_Client = tbl_Client.No_Client INNER JOIN
                         tbl_Reservation_Par_Items ON tbl_Reservation.No_Reservation = tbl_Reservation_Par_Items.No_Reservation INNER JOIN
                         tbl_Items INNER JOIN
                         tbl_Essences_Arbre ON tbl_Items.No_Essences_Arbre = tbl_Essences_Arbre.No_Essences_Arbre INNER JOIN
                         tbl_Fournisseur ON tbl_Items.No_Fournisseur = tbl_Fournisseur.No_Fournisseur ON tbl_Reservation_Par_Items.No_Items = tbl_Items.No_Items



/*
select* 
from tbl_Client
insert into tbl_Client(Nom,Prenom,Telephone)
values('bob','Marley')
go
select* 
from tbl_Essences_Arbre
insert into tbl_Essences_Arbre(Nom)
values('Tremble')
go
select* 
from tbl_Fournisseur
insert into tbl_Fournisseur(Nom)
values('P�pini�re Verdoyante')
go
select* 
from tbl_Items
insert into tbl_Items(Prix,Quantite_Disponible,Annee_Entente,No_Fournisseur,No_Essences_Arbre)
values(0,0,'2018',100,100)
go
select* 
from tbl_Reservation
insert into tbl_Reservation(No_Reservation,Date_Reservation,Prix_Total,No_Client)
values(-3,,125,1)
go
select* 
from tbl_Reservation_Par_Items
insert into tbl_Reservation_Par_Items(No_Reservation,No_Items,Quantite,Livree)
values(1,1,0,'ok')
go
*/
use AR_EL_Travail_1


select * from tbl_Fournisseur

/*********************************************************************************************************************************************************************************************/
/*Travail 2*/

ALTER TABLE Tbl_Items
DROP COLUMN Prix
GO

ALTER TABLE Tbl_Reservation
DROP COLUMN Prix_Total
GO

/*--Vue--*/
CREATE VIEW View_Entente AS
SELECT tbl_Items.No_Items, tbl_Essences_Arbre.No_Essences_Arbre, tbl_Essences_Arbre.Nom AS 'Essence',
	   tbl_Fournisseur.No_Fournisseur, tbl_Fournisseur.Nom AS 'Fournisseur', Quantite_Disponible, tbL_Somme.Quantite,
	   Annee_Entente 
	   FROM tbl_Items INNER JOIN tbl_Essences_Arbre
ON tbl_Essences_Arbre.No_Essences_Arbre = tbl_Items.No_Essences_Arbre
INNER JOIN tbl_Fournisseur
ON tbl_Fournisseur.No_Fournisseur = tbl_Items.No_Fournisseur
LEFT OUTER JOIN (SELECT SUM(Quantite) AS 'Quantite', tbl_Reservation_Par_Items.No_Items FROM tbl_Reservation_Par_Items 
			RIGHT OUTER JOIN tbl_Items ON tbl_Items.No_Items = tbl_Reservation_Par_Items.No_Items
			WHERE tbl_Items.No_Items = tbl_Reservation_Par_Items.No_Items
			GROUP BY tbl_Reservation_Par_Items.No_Items) AS tbL_Somme
ON tbL_Somme.No_Items = tbl_Items.No_Items
WHERE tbl_Items.Annee_Entente >= Year(getDate()) 
WITH CHECK OPTION
GO

CREATE PROCEDURE maj_quantite
@No_Items INT,
@Quantite_Disponible INT
AS
UPDATE View_Entente
SET  Quantite_Disponible = @Quantite_Disponible
WHERE (No_Items = @No_Items)
GO
SELECT * FROM View_Entente

/*exec maj_quantite 4,30
go*/
/*--------------Donn�e test------------------*/

SELECT * FROM tbl_Items
SELECT * FROM tbl_Fournisseur
SELECT * FROM tbl_Essences_Arbre
GO

INSERT INTO tbl_Essences_Arbre(Nom)
VALUES('Test_Arbre1'),
	('Test_Arbre2'),
	('Test_Arbre3'),
	('aaaaaaaa')
GO

INSERT INTO tbl_Fournisseur(Nom)
VALUES('Test_Fournisseur1'),
	('Test_Fournisseur2'),
	('Test_Fournisseur3')
GO

INSERT INTO tbl_Items(Quantite_Disponible,Annee_Entente,No_Fournisseur,No_Essences_Arbre)
VALUES(50,2020,3,4),
	(50,2020,4,5),
	(50,2020,5,6)
GO

INSERT INTO tbl_Items(Quantite_Disponible,Annee_Entente,No_Fournisseur,No_Essences_Arbre)
VALUES(50,2019,3,4)	
GO

ALTER TABLE tbl_Items
DROP CONSTRAINT CK_Annee_entente
GO

INSERT INTO tbl_Items(Quantite_Disponible,Annee_Entente,No_Fournisseur,No_Essences_Arbre) 
VALUES(50,2018,3,4),
	  (50,2018,3,5)
GO

ALTER TABLE tbl_Items WITH NOCHECK
ADD CONSTRAINT CK_Annee_entente CHECK (Annee_Entente >= Year(getDate())) 
GO

SELECT * FROM tbl_Reservation_Par_Items
INSERT INTO tbl_Reservation_Par_Items(No_Reservation,No_Items,Quantite,Livree)
VALUES(1,9,5,'non')
GO

CREATE PROCEDURE destruction_client
@noClient INT
AS
DECLARE @cpt_error INT
SET @cpt_error = 0
BEGIN TRANSACTION
DELETE FROM tbl_Reservation_Par_Items
WHERE No_Reservation = (SELECT No_Reservation FROM tbl_Reservation WHERE No_Client = @noClient)
SET @cpt_error = @cpt_error + @@ERROR
DELETE FROM tbl_Reservation
WHERE No_Client = @noClient
SET @cpt_error = @cpt_error + @@ERROR
DELETE FROM tbl_Client
WHERE No_Client = @noClient
SET @cpt_error = @cpt_error + @@ERROR
--INSERT INTO tbl_Client(No_Client,Nom,Prenom,Telephone)
--VALUES (9999999, 'Mario','Mario', '418-418-4184')
--SET @cpt_error = @cpt_error + @@ERROR
IF @cpt_error = 0 
	COMMIT TRANSACTION
ELSE 
	 BEGIN
	 RAISERROR ('Erreur d�tect�, suppression annul�e',16,1)
	 ROLLBACK
END
GO

EXEC destruction_client '1'
GO

CREATE TRIGGER QuantiteDisponible_EssenceParFournisseur
ON tbl_Reservation_Par_Items
FOR INSERT, UPDATE
AS		
SET NOCOUNT ON
IF UPDATE(Quantite)
BEGIN 
IF EXISTS (SELECT SUM(tbl_Reservation_Par_Items.Quantite), tbl_Reservation_Par_Items.No_Items
	FROM tbl_Reservation_Par_Items INNER JOIN inserted ON inserted.No_Items = tbl_Reservation_Par_Items.No_Items AND inserted.No_Reservation = tbl_Reservation_Par_Items.No_Reservation
	INNER JOIN tbl_Items ON inserted.No_Items = tbl_Items.No_Items
	GROUP BY tbl_Reservation_Par_Items.No_Items, Quantite_Disponible
	HAVING  SUM(tbl_Reservation_Par_Items.Quantite) > Quantite_Disponible)	
BEGIN 
RAISERROR('Impossible d''ajouter la quantit� d�sir�e, celle-ci est plus grande que la quantit� disponible',16,1)
ROLLBACK
END
END
SET NOCOUNT OFF
GO

/*
--UNITAIRE NON FONCTIONNEL
INSERT INTO tbl_Reservation_Par_Items(No_Reservation,No_Items,Quantite,Livree)
VALUES ('3','8','65','Non')
GO

--UNITAIRE FONCTIONNEL
INSERT INTO tbl_Reservation_Par_Items(No_Reservation,No_Items,Quantite,Livree)
VALUES ('3','8','10','Non')
GO

--BATCH NON FONCTIONNEL
INSERT INTO tbl_Reservation_Par_Items(No_Reservation,No_Items,Quantite,Livree)
VALUES ('3','7','45','Non'),
		('3','6','30','Non'),
		('5','7','25','Non')
GO

--BATCH FONCTIONNEL
INSERT INTO tbl_Reservation_Par_Items(No_Reservation,No_Items,Quantite,Livree)
VALUES ('3','7','15','Non'),
		('3','6','30','Non'),
		('5','7','25','Non')
GO

DELETE FROM tbl_Reservation_Par_Items
WHERE No_Reservation = 3
GO
DELETE FROM tbl_Reservation_Par_Items
WHERE No_Reservation = 5
GO
DELETE FROM tbl_Reservation_Par_Items
WHERE No_Reservation = 8
GO
*/

CREATE PROCEDURE arbre_et_fournisseur
@annee INT
AS
SELECT tbl_Essences_Arbre.Nom+' | '+tbl_Fournisseur.Nom AS'arbre_fournisseur', tbl_Items.No_Items
FROM tbl_Essences_Arbre INNER JOIN tbl_Items ON tbl_Essences_Arbre.No_Essences_Arbre = tbl_Items.No_Essences_Arbre 
INNER JOIN tbl_Fournisseur ON tbl_Items.No_Fournisseur = tbl_Fournisseur.No_Fournisseur
WHERE Annee_Entente = @annee
GO

SELECT * FROM tbl_Reservation_Par_Items
SELECT * FROM tbl_Items
SELECT * FROM tbl_Reservation
SELECT * FROM tbl_Client