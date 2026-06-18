CREATE TABLE INSTITUCIJA (
    Id      NUMBER PRIMARY KEY,
    Naziv   VARCHAR2(100) NOT NULL,
    Adresa  VARCHAR2(150) NOT NULL
);

CREATE SEQUENCE SEQ_INSTITUCIJA
START WITH 1
INCREMENT BY 1
NOCACHE;

CREATE OR REPLACE TRIGGER TRG_INSTITUCIJA
BEFORE INSERT ON INSTITUCIJA
FOR EACH ROW
BEGIN
    IF :NEW.Id IS NULL THEN
        :NEW.Id := SEQ_INSTITUCIJA.NEXTVAL;
    END IF;
END;
/

CREATE TABLE ISTRAZIVAC (
    Id                                  NUMBER PRIMARY KEY,
    Ime                                 VARCHAR2(50)  NOT NULL,
    Prezime                             VARCHAR2(50)  NOT NULL,
    Datum_Rodjenja                      DATE          NOT NULL,
    Drzava                              VARCHAR2(50)  NOT NULL,
    Status_Naloga                       VARCHAR2(30)  NOT NULL,
    Naucno_Zvanje                       VARCHAR2(50)  NOT NULL,
    Naucna_Oblast                       VARCHAR2(50)  NOT NULL,
    Je_Autor                            NUMBER(1)     DEFAULT 0 NOT NULL
        CHECK (Je_Autor IN (0, 1)),
    Je_Recenzent                        NUMBER(1)     DEFAULT 0 NOT NULL
        CHECK (Je_Recenzent IN (0, 1)),
    Je_Urednik                          NUMBER(1)     DEFAULT 0 NOT NULL
        CHECK (Je_Urednik IN (0, 1)),
    Je_Admin     NUMBER(1)     DEFAULT 0 NOT NULL
        CHECK (Je_Admin IN (0, 1)),
    Je_Rukovodilac_Projekta             NUMBER(1)     DEFAULT 0 NOT NULL
        CHECK (Je_Rukovodilac_Projekta IN (0, 1)),
    ORCID                               VARCHAR2(19),
    Oblast_Ekspertize                   VARCHAR2(100),
    Uredjivacka_Sekcija                 VARCHAR2(100),
    Administratorska_Ovlascenja         VARCHAR2(100)
);

CREATE SEQUENCE SEQ_ISTRAZIVAC
START WITH 1
INCREMENT BY 1
NOCACHE;

CREATE OR REPLACE TRIGGER TRG_ISTRAZIVAC
BEFORE INSERT ON ISTRAZIVAC
FOR EACH ROW
BEGIN
    IF :NEW.Id IS NULL THEN
        :NEW.Id := SEQ_ISTRAZIVAC.NEXTVAL;
    END IF;
END;
/

CREATE TABLE PUBLIKACIJA (
    Id                          NUMBER PRIMARY KEY,
    Naslov                      VARCHAR2(300)   NOT NULL,
    Apstrakt                    CLOB,
    Jezik                       VARCHAR2(50)    NOT NULL,
    Datum_Objavljivanja         DATE,
    Datum_Kreiranja_Zapisa      DATE            NOT NULL,
    Status                      VARCHAR2(30)    NOT NULL
        CHECK (Status IN ('u pripremi', 'poslat na recenziju',
                          'u reviziji', 'prihvacen', 'odbijen',
                          'objavljen', 'arhiviran')),
    Vidljivost                  VARCHAR2(30)    NOT NULL
);

CREATE SEQUENCE SEQ_PUBLIKACIJA
START WITH 1
INCREMENT BY 1
NOCACHE;

CREATE OR REPLACE TRIGGER TRG_PUBLIKACIJA
BEFORE INSERT ON PUBLIKACIJA
FOR EACH ROW
BEGIN
    IF :NEW.Id IS NULL THEN
        :NEW.Id := SEQ_PUBLIKACIJA.NEXTVAL;
    END IF;
END;
/

CREATE TABLE IZVOR (
    Id      NUMBER PRIMARY KEY,
    Naziv   VARCHAR2(200) NOT NULL
);

CREATE SEQUENCE SEQ_IZVOR
START WITH 1
INCREMENT BY 1
NOCACHE;

CREATE OR REPLACE TRIGGER TRG_IZVOR
BEFORE INSERT ON IZVOR
FOR EACH ROW
BEGIN
    IF :NEW.Id IS NULL THEN
        :NEW.Id := SEQ_IZVOR.NEXTVAL;
    END IF;
END;
/

CREATE TABLE CASOPIS (
    Id_Izvora       NUMBER PRIMARY KEY,
    ISSN            VARCHAR2(8),
    Broj_Sveske     NUMBER,
    Broj_Izdanja    NUMBER,
    CONSTRAINT FK_CASOPIS_IZVOR
        FOREIGN KEY (Id_Izvora) REFERENCES IZVOR(Id)
);

CREATE TABLE KONFERENCIJA (
    Id_Izvora   NUMBER PRIMARY KEY,
    ISBN        VARCHAR2(17),
    CONSTRAINT FK_KONFERENCIJA_IZVOR
        FOREIGN KEY (Id_Izvora) REFERENCES IZVOR(Id)
);

CREATE TABLE NAUCNI_RAD (
    Id_Publikacije  NUMBER PRIMARY KEY,
    DOI             VARCHAR2(100),
    Tip_Rada        VARCHAR2(50),
    Stranice        VARCHAR2(20),
    Id_Izvora       NUMBER NOT NULL,
    CONSTRAINT FK_NAUCNI_RAD_PUBLIKACIJA
        FOREIGN KEY (Id_Publikacije) REFERENCES PUBLIKACIJA(Id),
    CONSTRAINT FK_NAUCNI_RAD_IZVOR
        FOREIGN KEY (Id_Izvora) REFERENCES IZVOR(Id)
);

CREATE TABLE KNJIGA (
    Id_Publikacije  NUMBER PRIMARY KEY,
    Izdavac         VARCHAR2(100),
    Mesto_Izdanja   VARCHAR2(100),
    CONSTRAINT FK_KNJIGA_PUBLIKACIJA
        FOREIGN KEY (Id_Publikacije) REFERENCES PUBLIKACIJA(Id)
);

CREATE TABLE POGLAVLJE_U_KNJIZI (
    Id_Publikacije  NUMBER PRIMARY KEY,
    Izdavac         VARCHAR2(100),
    Mesto_Izdanja   VARCHAR2(100),
    CONSTRAINT FK_POGLAVLJE_PUBLIKACIJA
        FOREIGN KEY (Id_Publikacije) REFERENCES PUBLIKACIJA(Id)
);

CREATE TABLE DOKTORSKA_DISERTACIJA (
    Id_Publikacije  NUMBER PRIMARY KEY,
    CONSTRAINT FK_DOKTORSKA_PUBLIKACIJA
        FOREIGN KEY (Id_Publikacije) REFERENCES PUBLIKACIJA(Id)
);

CREATE TABLE DATASET (
    Id_Publikacije      NUMBER PRIMARY KEY,
    Broj_Zapisa         NUMBER,
    Velicina            NUMBER,
    Opis_Strukture      CLOB,
    Format              VARCHAR2(50),
    Licenca_Koriscenja  VARCHAR2(100),
    Datum_Od            DATE,
    Datum_Do            DATE,
    CONSTRAINT FK_DATASET_PUBLIKACIJA
        FOREIGN KEY (Id_Publikacije) REFERENCES PUBLIKACIJA(Id)
);

CREATE TABLE SOFTVERSKI_ARTEFAKT (
    Id_Publikacije          NUMBER PRIMARY KEY,
    Programski_Jezik        VARCHAR2(50),
    Dokumentacija           CLOB,
    Link_Ka_Repozitorijumu  VARCHAR2(500),
    Nacin_Licenciranja      VARCHAR2(100),
    CONSTRAINT FK_SA_PUBLIKACIJA
        FOREIGN KEY (Id_Publikacije) REFERENCES PUBLIKACIJA(Id)
);

CREATE TABLE OBRAZOVNI_MATERIJAL (
    Id_Publikacije  NUMBER PRIMARY KEY,
    CONSTRAINT FK_OBRAZOVNI_PUBLIKACIJA
        FOREIGN KEY (Id_Publikacije) REFERENCES PUBLIKACIJA(Id)
);

CREATE TABLE PREZENTACIJA (
    Id_Publikacije  NUMBER PRIMARY KEY,
    CONSTRAINT FK_PREZENTACIJA_PUBLIKACIJA
        FOREIGN KEY (Id_Publikacije) REFERENCES PUBLIKACIJA(Id)
);

CREATE TABLE TEHNICKI_IZVESTAJ (
    Id_Publikacije  NUMBER PRIMARY KEY,
    CONSTRAINT FK_TEHNICKI_PUBLIKACIJA
        FOREIGN KEY (Id_Publikacije) REFERENCES PUBLIKACIJA(Id)
);

CREATE SEQUENCE seq_verzija START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE VERZIJA (
    Id_Verzije NUMBER NOT NULL,
    Broj_Verzije NUMBER NOT NULL,
    Id_Publikacije NUMBER NOT NULL,
    Datum_Postavljanja DATE,
    Opis_Izmene VARCHAR2(1000),
    Odgovorna_Osoba VARCHAR2(255),
    CONSTRAINT pk_verzija PRIMARY KEY (Id_Verzije),
    CONSTRAINT uq_verzija UNIQUE (Broj_Verzije, Id_Publikacije),
    CONSTRAINT fk_verzija_pub FOREIGN KEY (Id_Publikacije)
        REFERENCES PUBLIKACIJA(Id)
        ON DELETE CASCADE
);

CREATE INDEX ix_verzija_id_publikacije ON VERZIJA (Id_Publikacije);

CREATE OR REPLACE TRIGGER trg_verzija_id
BEFORE INSERT ON VERZIJA
FOR EACH ROW
BEGIN
    IF :NEW.Id_Verzije IS NULL THEN
        :NEW.Id_Verzije := seq_verzija.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_runda_recenzije START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE RUNDA_RECENZIJE (
    Id_Runde_Recenzije NUMBER NOT NULL,
    Broj_Runde NUMBER NOT NULL,
    Id_Publikacije NUMBER NOT NULL,
    Datum DATE,
    Konacna_Odluka VARCHAR2(255),
    Id_Urednika NUMBER,
    CONSTRAINT pk_runda_recenzije PRIMARY KEY (Id_Runde_Recenzije),
    CONSTRAINT uq_runda_recenzije UNIQUE (Broj_Runde, Id_Publikacije),
    CONSTRAINT fk_runda_pub FOREIGN KEY (Id_Publikacije)
        REFERENCES PUBLIKACIJA(Id)
        ON DELETE CASCADE,
    CONSTRAINT fk_runda_urednik FOREIGN KEY (Id_Urednika)
        REFERENCES ISTRAZIVAC(Id)
        ON DELETE SET NULL
);

CREATE INDEX ix_runda_recenzije_id_pub ON RUNDA_RECENZIJE (Id_Publikacije);
CREATE INDEX ix_runda_recenzije_id_urednika ON RUNDA_RECENZIJE (Id_Urednika);

CREATE OR REPLACE TRIGGER trg_runda_recenzije_id
BEFORE INSERT ON RUNDA_RECENZIJE
FOR EACH ROW
BEGIN
    IF :NEW.Id_Runde_Recenzije IS NULL THEN
        :NEW.Id_Runde_Recenzije := seq_runda_recenzije.NEXTVAL;
    END IF;
END;
/


CREATE SEQUENCE seq_inst_mail START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE INSTITUCIJA_KONTAKT_MAIL (
    Id_Inst_Mail NUMBER NOT NULL,
    Id_Institucije NUMBER NOT NULL,
    Kontakt_Mail VARCHAR2(255) NOT NULL,
    CONSTRAINT pk_inst_mail PRIMARY KEY (Id_Inst_Mail),
    CONSTRAINT uq_inst_mail UNIQUE (Id_Institucije, Kontakt_Mail),
    CONSTRAINT fk_inst_mail_inst FOREIGN KEY (Id_Institucije)
        REFERENCES INSTITUCIJA(Id)
        ON DELETE CASCADE
);

CREATE INDEX ix_inst_mail_id_institucije ON INSTITUCIJA_KONTAKT_MAIL (Id_Institucije);

CREATE OR REPLACE TRIGGER trg_inst_mail_id
BEFORE INSERT ON INSTITUCIJA_KONTAKT_MAIL
FOR EACH ROW
BEGIN
    IF :NEW.Id_Inst_Mail IS NULL THEN
        :NEW.Id_Inst_Mail := seq_inst_mail.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_inst_tel START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE INSTITUCIJA_KONTAKT_TEL (
    Id_Inst_Tel NUMBER NOT NULL,
    Id_Institucije NUMBER NOT NULL,
    Kontakt_Tel VARCHAR2(50) NOT NULL,
    CONSTRAINT pk_inst_tel PRIMARY KEY (Id_Inst_Tel),
    CONSTRAINT uq_inst_tel UNIQUE (Id_Institucije, Kontakt_Tel),
    CONSTRAINT fk_inst_tel_inst FOREIGN KEY (Id_Institucije)
        REFERENCES INSTITUCIJA(Id)
        ON DELETE CASCADE
);

CREATE INDEX ix_inst_tel_id_institucije ON INSTITUCIJA_KONTAKT_TEL (Id_Institucije);

CREATE OR REPLACE TRIGGER trg_inst_tel_id
BEFORE INSERT ON INSTITUCIJA_KONTAKT_TEL
FOR EACH ROW
BEGIN
    IF :NEW.Id_Inst_Tel IS NULL THEN
        :NEW.Id_Inst_Tel := seq_inst_tel.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_inst_oblast START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE INSTITUCIJA_NAUCNE_OBLASTI (
    Id_Inst_Oblast NUMBER NOT NULL,
    Id_Institucije NUMBER NOT NULL,
    Naucna_Oblast VARCHAR2(255) NOT NULL,
    CONSTRAINT pk_inst_oblast PRIMARY KEY (Id_Inst_Oblast),
    CONSTRAINT uq_inst_oblast UNIQUE (Id_Institucije, Naucna_Oblast),
    CONSTRAINT fk_inst_oblast_inst FOREIGN KEY (Id_Institucije)
        REFERENCES INSTITUCIJA(Id)
        ON DELETE CASCADE
);

CREATE INDEX ix_inst_oblast_id_institucije ON INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije);

CREATE OR REPLACE TRIGGER trg_inst_oblast_id
BEFORE INSERT ON INSTITUCIJA_NAUCNE_OBLASTI
FOR EACH ROW
BEGIN
    IF :NEW.Id_Inst_Oblast IS NULL THEN
        :NEW.Id_Inst_Oblast := seq_inst_oblast.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_istr_tel START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE ISTRAZIVAC_TELEFONI (
    Id_Istr_Tel NUMBER NOT NULL,
    Id_Istrazivaca NUMBER NOT NULL,
    Telefon VARCHAR2(50) NOT NULL,
    CONSTRAINT pk_istr_tel PRIMARY KEY (Id_Istr_Tel),
    CONSTRAINT uq_istr_tel UNIQUE (Id_Istrazivaca, Telefon),
    CONSTRAINT fk_istr_tel_istr FOREIGN KEY (Id_Istrazivaca)
        REFERENCES ISTRAZIVAC(Id)
        ON DELETE CASCADE
);

CREATE INDEX ix_istr_tel_id_istrazivaca ON ISTRAZIVAC_TELEFONI (Id_Istrazivaca);

CREATE OR REPLACE TRIGGER trg_istr_tel_id
BEFORE INSERT ON ISTRAZIVAC_TELEFONI
FOR EACH ROW
BEGIN
    IF :NEW.Id_Istr_Tel IS NULL THEN
        :NEW.Id_Istr_Tel := seq_istr_tel.NEXTVAL;
    END IF;
END;
/


CREATE SEQUENCE seq_istr_email START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE ISTRAZIVAC_EMAIL (
    Id_Istr_Email NUMBER NOT NULL,
    Id_Istrazivaca NUMBER NOT NULL,
    Email VARCHAR2(255) NOT NULL,
    CONSTRAINT pk_istr_email PRIMARY KEY (Id_Istr_Email),
    CONSTRAINT uq_istr_email UNIQUE (Id_Istrazivaca, Email),
    CONSTRAINT fk_istr_email_istr FOREIGN KEY (Id_Istrazivaca)
        REFERENCES ISTRAZIVAC(Id)
        ON DELETE CASCADE
);

CREATE INDEX ix_istr_email_id_istrazivaca ON ISTRAZIVAC_EMAIL (Id_Istrazivaca);

CREATE OR REPLACE TRIGGER trg_istr_email_id
BEFORE INSERT ON ISTRAZIVAC_EMAIL
FOR EACH ROW
BEGIN
    IF :NEW.Id_Istr_Email IS NULL THEN
        :NEW.Id_Istr_Email := seq_istr_email.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_pub_rec START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE PUBLIKACIJA_KLJUCNE_RECI (
    Id_Pub_Rec NUMBER NOT NULL,
    Id_Publikacije NUMBER NOT NULL,
    Kljucna_Rec VARCHAR2(255) NOT NULL,
    CONSTRAINT pk_pub_rec PRIMARY KEY (Id_Pub_Rec),
    CONSTRAINT uq_pub_rec UNIQUE (Id_Publikacije, Kljucna_Rec),
    CONSTRAINT fk_pub_rec_pub FOREIGN KEY (Id_Publikacije)
        REFERENCES PUBLIKACIJA(Id)
        ON DELETE CASCADE
);

CREATE INDEX ix_pub_rec_id_publikacije ON PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije);

CREATE OR REPLACE TRIGGER trg_pub_rec_id
BEFORE INSERT ON PUBLIKACIJA_KLJUCNE_RECI
FOR EACH ROW
BEGIN
    IF :NEW.Id_Pub_Rec IS NULL THEN
        :NEW.Id_Pub_Rec := seq_pub_rec.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_sa_platforma START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE SA_PODRZANE_PLATFORME (
    Id_SA_Platforma NUMBER NOT NULL,
    Id_Publikacije NUMBER NOT NULL,
    Podrzana_Platforma VARCHAR2(255) NOT NULL,
    CONSTRAINT pk_sa_platforma PRIMARY KEY (Id_SA_Platforma),
    CONSTRAINT uq_sa_platforma UNIQUE (Id_Publikacije, Podrzana_Platforma),
    CONSTRAINT fk_sa_platforma_pub FOREIGN KEY (Id_Publikacije)
        REFERENCES SOFTVERSKI_ARTEFAKT(Id_Publikacije)
        ON DELETE CASCADE
);

CREATE INDEX ix_sa_platforma_id_pub ON SA_PODRZANE_PLATFORME (Id_Publikacije);

CREATE OR REPLACE TRIGGER trg_sa_platforma_id
BEFORE INSERT ON SA_PODRZANE_PLATFORME
FOR EACH ROW
BEGIN
    IF :NEW.Id_SA_Platforma IS NULL THEN
        :NEW.Id_SA_Platforma := seq_sa_platforma.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_fajlovi START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE FAJLOVI (
    Id_Fajla NUMBER NOT NULL,
    Id_Verzije NUMBER NOT NULL,
    Fajl VARCHAR2(500) NOT NULL,
    CONSTRAINT pk_fajlovi PRIMARY KEY (Id_Fajla),
    CONSTRAINT fk_fajlovi_verzija FOREIGN KEY (Id_Verzije)
        REFERENCES VERZIJA(Id_Verzije)
        ON DELETE CASCADE
);

CREATE INDEX ix_fajlovi_id_verzije ON FAJLOVI (Id_Verzije);

CREATE OR REPLACE TRIGGER trg_fajlovi_id
BEFORE INSERT ON FAJLOVI
FOR EACH ROW
BEGIN
    IF :NEW.Id_Fajla IS NULL THEN
        :NEW.Id_Fajla := seq_fajlovi.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_knjiga_urednik START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE KNJIGA_UREDNICI (
    Id_Knjiga_Urednik NUMBER NOT NULL,
    Id_Publikacije NUMBER NOT NULL,
    Urednik VARCHAR2(255) NOT NULL,
    CONSTRAINT pk_knjiga_urednik PRIMARY KEY (Id_Knjiga_Urednik),
    CONSTRAINT uq_knjiga_urednik UNIQUE (Id_Publikacije, Urednik),
    CONSTRAINT fk_knjiga_urednik_pub FOREIGN KEY (Id_Publikacije)
        REFERENCES KNJIGA(Id_Publikacije)
        ON DELETE CASCADE
);

CREATE INDEX ix_knjiga_urednici_id_pub ON KNJIGA_UREDNICI (Id_Publikacije);

CREATE OR REPLACE TRIGGER trg_knjiga_urednik_id
BEFORE INSERT ON KNJIGA_UREDNICI
FOR EACH ROW
BEGIN
    IF :NEW.Id_Knjiga_Urednik IS NULL THEN
        :NEW.Id_Knjiga_Urednik := seq_knjiga_urednik.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_poglavlje_urednik START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE POGLAVLJE_UREDNICI (
    Id_Poglavlje_Urednik NUMBER NOT NULL,
    Id_Publikacije NUMBER NOT NULL,
    Urednik VARCHAR2(255) NOT NULL,
    CONSTRAINT pk_poglavlje_urednik PRIMARY KEY (Id_Poglavlje_Urednik),
    CONSTRAINT uq_poglavlje_urednik UNIQUE (Id_Publikacije, Urednik),
    CONSTRAINT fk_poglavlje_urednik_pub FOREIGN KEY (Id_Publikacije)
        REFERENCES POGLAVLJE_U_KNJIZI(Id_Publikacije)
        ON DELETE CASCADE
);

CREATE INDEX ix_poglavlje_urednici_id_pub ON POGLAVLJE_UREDNICI (Id_Publikacije);

CREATE OR REPLACE TRIGGER trg_poglavlje_urednik_id
BEFORE INSERT ON POGLAVLJE_UREDNICI
FOR EACH ROW
BEGIN
    IF :NEW.Id_Poglavlje_Urednik IS NULL THEN
        :NEW.Id_Poglavlje_Urednik := seq_poglavlje_urednik.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_angazovanje START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE ANGAZOVANJE (
    Id_angazovanja NUMBER NOT NULL,
	Id_institucije NUMBER NOT NULL,
	Id_istrazivaca NUMBER NOT NULL,
	Organizaciona_jedinica VARCHAR2(100),
	Tip_angazovanja VARCHAR2(100),
	Naziv_pozicije VARCHAR2(100),
	Datum_pocetka DATE NOT NULL,
	Datum_zavrsetka DATE,

	CONSTRAINT PK_ANGAZOVANJE
		PRIMARY KEY (Id_angazovanja),

	CONSTRAINT FK_ANGAZOVANJE_INSTITUCIJA
		FOREIGN KEY (Id_institucije)
		REFERENCES INSTITUCIJA(Id),

	CONSTRAINT FK_ANGAZOVANJE_ISTRAZIVAC
		FOREIGN KEY (Id_istrazivaca)
		REFERENCES ISTRAZIVAC(Id),

	CONSTRAINT CHK_ANGAZOVANJE_DATUMI
		CHECK (Datum_zavrsetka IS NULL OR Datum_zavrsetka >= Datum_pocetka)
);

CREATE OR REPLACE TRIGGER trg_angazovanje_id
BEFORE INSERT ON ANGAZOVANJE
FOR EACH ROW
BEGIN
    IF :NEW.Id_angazovanja IS NULL THEN
        :NEW.Id_angazovanja := seq_angazovanje.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_autorstvo START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE AUTORSTVO (
    Id_autorstva NUMBER NOT NULL,
	Id_publikacije NUMBER NOT NULL,
	Id_autora NUMBER NOT NULL,
	Redosled_autora NUMBER NOT NULL,
	Tip_doprinosa VARCHAR2(100),
	Uloga VARCHAR2(100),

	CONSTRAINT PK_AUTORSTVO PRIMARY KEY (Id_autorstva),

	CONSTRAINT FK_AUTORSTVO_PUBLIKACIJA
		FOREIGN KEY (Id_publikacije)
		REFERENCES PUBLIKACIJA(Id),

	CONSTRAINT FK_AUTORSTVO_AUTOR
        FOREIGN KEY (Id_autora)
        REFERENCES ISTRAZIVAC(Id)
);

CREATE OR REPLACE TRIGGER trg_autorstvo_id
BEFORE INSERT ON AUTORSTVO
FOR EACH ROW
BEGIN
    IF :NEW.Id_autorstva IS NULL THEN
        :NEW.Id_autorstva := seq_autorstvo.NEXTVAL;
    END IF;
END;
/


CREATE SEQUENCE seq_povezan_sa START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE POVEZAN_SA (
    Id_povezan NUMBER NOT NULL,
    Id_publikacije_1 NUMBER NOT NULL,
    Id_publikacije_2 NUMBER NOT NULL,
    Tip_povezanosti VARCHAR2(100) NOT NULL,

    CONSTRAINT PK_POVEZAN_SA
        PRIMARY KEY (Id_povezan),

    CONSTRAINT FK_POVEZAN_SA_PUB1
        FOREIGN KEY (Id_publikacije_1)
        REFERENCES PUBLIKACIJA(Id),

    CONSTRAINT FK_POVEZAN_SA_PUB2
        FOREIGN KEY (Id_publikacije_2)
        REFERENCES PUBLIKACIJA(Id)
);

CREATE OR REPLACE TRIGGER trg_povezan_sa_id
BEFORE INSERT ON POVEZAN_SA
FOR EACH ROW
BEGIN
    IF :NEW.Id_povezan IS NULL THEN
        :NEW.Id_povezan := seq_povezan_sa.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_citira START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE CITIRA (
    Id_citata NUMBER NOT NULL,
    Id_citira NUMBER NOT NULL,
    Id_citirana NUMBER NOT NULL,
    Tip_citata VARCHAR2(100),
    Mesto_citiranja VARCHAR2(100),
    Tekstualni_kontekst VARCHAR2(1000),

    CONSTRAINT PK_CITIRA
        PRIMARY KEY (Id_citata),

    CONSTRAINT FK_CITIRA_PUB
        FOREIGN KEY (Id_citira)
        REFERENCES PUBLIKACIJA(Id),

    CONSTRAINT FK_CITIRA_CITAT
        FOREIGN KEY (Id_citirana)
        REFERENCES PUBLIKACIJA(Id),

    CONSTRAINT CHK_CITIRA
        CHECK (Id_citira <> Id_citirana)
);

CREATE OR REPLACE TRIGGER trg_citira_id
BEFORE INSERT ON CITIRA
FOR EACH ROW
BEGIN
    IF :NEW.Id_citata IS NULL THEN
        :NEW.Id_citata := seq_citira.NEXTVAL;
    END IF;
END;
/

CREATE SEQUENCE seq_vrsi_recenziju START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE VRSI_RECENZIJU (
    Id_Recenzije NUMBER NOT NULL,
    Id_Runde_Recenzije NUMBER NOT NULL,
    Id_recenzenta NUMBER NOT NULL,
    Preporuka VARCHAR2(50),

    CONSTRAINT PK_VRSI_RECENZIJU
        PRIMARY KEY (Id_Recenzije),

    CONSTRAINT FK_VRSI_RECENZIJU_RUNDA
        FOREIGN KEY (Id_Runde_Recenzije)
        REFERENCES RUNDA_RECENZIJE(Id_Runde_Recenzije),

    CONSTRAINT FK_VRSI_RECENZIJU_RECENZENT
        FOREIGN KEY (Id_recenzenta)
        REFERENCES ISTRAZIVAC(Id),

    -- CONSTRAINT UQ_VRSI_RECENZIJU_RUNDA
    --     UNIQUE (Id_Runde_Recenzije),
    --
    -- CONSTRAINT UQ_VRSI_RECENZIJU_RECENZENT
    --     UNIQUE (Id_recenzenta)
    CONSTRAINT UQ_VRSI_REC_RUNDA_RECENZENT
    UNIQUE (Id_Runde_Recenzije, Id_recenzenta)
);

CREATE OR REPLACE TRIGGER trg_vrsi_recenziju_id
BEFORE INSERT ON VRSI_RECENZIJU
FOR EACH ROW
BEGIN
    IF :NEW.Id_Recenzije IS NULL THEN
        :NEW.Id_recenzije := seq_vrsi_recenziju.NEXTVAL;
    END IF;
END;
/


CREATE SEQUENCE seq_niz_ocena START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

CREATE TABLE NIZ_OCENA (
    Id_Ocene NUMBER NOT NULL,
    Id_Runde_Recenzije NUMBER NOT NULL,
    Id_recenzenta NUMBER NOT NULL,
    Kriterijum VARCHAR2(50) NOT NULL, -- u relacioni model mora da se uvede kriterijum kao PK da bi jedan recenzent mogao da da vise ocena u jednoj rundi
    Ocena NUMBER NOT NULL,

    CONSTRAINT PK_NIZ_OCENA
        PRIMARY KEY (Id_Ocene),

    CONSTRAINT FK_NIZ_OCENA_RECENZIJA
        FOREIGN KEY (Id_Runde_Recenzije, Id_recenzenta)
        REFERENCES VRSI_RECENZIJU(Id_Runde_Recenzije, Id_recenzenta),

    CONSTRAINT CHK_OCENA
        CHECK (Ocena BETWEEN 1 AND 10)
);

CREATE OR REPLACE TRIGGER trg_niz_ocena_id
BEFORE INSERT ON NIZ_OCENA
FOR EACH ROW
BEGIN
    IF :NEW.Id_Ocene IS NULL THEN
        :NEW.Id_Ocene := seq_niz_ocena.NEXTVAL;
    END IF;
END;
/
