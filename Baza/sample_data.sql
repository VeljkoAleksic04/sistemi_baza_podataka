-- ============================================================
-- SAMPLE PODACI
-- ============================================================

-- ------------------------------------------------------------
-- INSTITUCIJA
-- ------------------------------------------------------------
INSERT INTO INSTITUCIJA (Naziv, Adresa) VALUES ('Univerzitet u Beogradu', 'Studentski trg 1, Beograd');
INSERT INTO INSTITUCIJA (Naziv, Adresa) VALUES ('Univerzitet u Novom Sadu', 'Trg Dositeja Obradovica 5, Novi Sad');
INSERT INTO INSTITUCIJA (Naziv, Adresa) VALUES ('Univerzitet u Nisu', 'Univerzitetski trg 2, Nis');
INSERT INTO INSTITUCIJA (Naziv, Adresa) VALUES ('Institut Mihajlo Pupin', 'Volgina 15, Beograd');
INSERT INTO INSTITUCIJA (Naziv, Adresa) VALUES ('Institut za nuklearne nauke Vinca', 'Mike Petrovica Alasa 12-14, Beograd');

-- ------------------------------------------------------------
-- INSTITUCIJA_KONTAKT_MAIL
-- ------------------------------------------------------------
INSERT INTO INSTITUCIJA_KONTAKT_MAIL (Id_Institucije, Kontakt_Mail) VALUES (1, 'rektorat@bg.ac.rs');
INSERT INTO INSTITUCIJA_KONTAKT_MAIL (Id_Institucije, Kontakt_Mail) VALUES (1, 'nauka@bg.ac.rs');
INSERT INTO INSTITUCIJA_KONTAKT_MAIL (Id_Institucije, Kontakt_Mail) VALUES (1, 'medjunarodna@bg.ac.rs');
INSERT INTO INSTITUCIJA_KONTAKT_MAIL (Id_Institucije, Kontakt_Mail) VALUES (2, 'uns@uns.ac.rs');
INSERT INTO INSTITUCIJA_KONTAKT_MAIL (Id_Institucije, Kontakt_Mail) VALUES (2, 'nauka@uns.ac.rs');
INSERT INTO INSTITUCIJA_KONTAKT_MAIL (Id_Institucije, Kontakt_Mail) VALUES (3, 'info@ni.ac.rs');
INSERT INTO INSTITUCIJA_KONTAKT_MAIL (Id_Institucije, Kontakt_Mail) VALUES (3, 'nauka@ni.ac.rs');
INSERT INTO INSTITUCIJA_KONTAKT_MAIL (Id_Institucije, Kontakt_Mail) VALUES (4, 'office@pupin.rs');
INSERT INTO INSTITUCIJA_KONTAKT_MAIL (Id_Institucije, Kontakt_Mail) VALUES (5, 'vinca@vin.bg.ac.rs');
INSERT INTO INSTITUCIJA_KONTAKT_MAIL (Id_Institucije, Kontakt_Mail) VALUES (5, 'library@vin.bg.ac.rs');

-- ------------------------------------------------------------
-- INSTITUCIJA_KONTAKT_TEL
-- ------------------------------------------------------------
INSERT INTO INSTITUCIJA_KONTAKT_TEL (Id_Institucije, Kontakt_Tel) VALUES (1, '+381112630206');
INSERT INTO INSTITUCIJA_KONTAKT_TEL (Id_Institucije, Kontakt_Tel) VALUES (1, '+381112637244');
INSERT INTO INSTITUCIJA_KONTAKT_TEL (Id_Institucije, Kontakt_Tel) VALUES (2, '+38121485200');
INSERT INTO INSTITUCIJA_KONTAKT_TEL (Id_Institucije, Kontakt_Tel) VALUES (2, '+38121454024');
INSERT INTO INSTITUCIJA_KONTAKT_TEL (Id_Institucije, Kontakt_Tel) VALUES (3, '+38118257095');
INSERT INTO INSTITUCIJA_KONTAKT_TEL (Id_Institucije, Kontakt_Tel) VALUES (4, '+381113670131');
INSERT INTO INSTITUCIJA_KONTAKT_TEL (Id_Institucije, Kontakt_Tel) VALUES (5, '+381112453967');
INSERT INTO INSTITUCIJA_KONTAKT_TEL (Id_Institucije, Kontakt_Tel) VALUES (5, '+381112453968');

-- ------------------------------------------------------------
-- INSTITUCIJA_NAUCNE_OBLASTI
-- ------------------------------------------------------------
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (1, 'Racunarstvo i informatika');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (1, 'Matematika');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (1, 'Fizika');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (1, 'Hemija');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (2, 'Elektrotehnika');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (2, 'Racunarstvo i informatika');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (2, 'Poljoprivreda');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (3, 'Elektronika');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (3, 'Masinstvo');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (4, 'Telekomunikacije');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (4, 'Vestacka inteligencija');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (5, 'Nuklearna fizika');
INSERT INTO INSTITUCIJA_NAUCNE_OBLASTI (Id_Institucije, Naucna_Oblast) VALUES (5, 'Hemija materijala');

-- ------------------------------------------------------------
-- ISTRAZIVAC
-- ------------------------------------------------------------
INSERT INTO ISTRAZIVAC (Ime, Prezime, Datum_Rodjenja, Drzava, Status_Naloga, Naucno_Zvanje, Naucna_Oblast, Je_Autor, Je_Recenzent, Je_Urednik, Je_Admin, Je_Rukovodilac_Projekta, ORCID, Oblast_Ekspertize, Uredjivacka_Sekcija, Administratorska_Ovlascenja)
VALUES ('Marko', 'Petrovic', DATE '1975-03-15', 'Srbija', 'aktivan', 'Redovni profesor', 'Racunarstvo i informatika', 1, 1, 1, 0, 1, '0000-0001-2345-6789', 'Masinsko ucenje, NLP', 'Vestacka inteligencija', NULL);

INSERT INTO ISTRAZIVAC (Ime, Prezime, Datum_Rodjenja, Drzava, Status_Naloga, Naucno_Zvanje, Naucna_Oblast, Je_Autor, Je_Recenzent, Je_Urednik, Je_Admin, Je_Rukovodilac_Projekta, ORCID, Oblast_Ekspertize)
VALUES ('Ana', 'Jovanovic', DATE '1982-07-22', 'Srbija', 'aktivan', 'Vanredni profesor', 'Racunarstvo i informatika', 1, 1, 0, 0, 0, '0000-0002-3456-7890', 'Baze podataka, cloud computing');

INSERT INTO ISTRAZIVAC (Ime, Prezime, Datum_Rodjenja, Drzava, Status_Naloga, Naucno_Zvanje, Naucna_Oblast, Je_Autor, Je_Recenzent, Je_Urednik, Je_Admin, Je_Rukovodilac_Projekta, ORCID, Oblast_Ekspertize)
VALUES ('Stefan', 'Nikolic', DATE '1990-11-05', 'Srbija', 'aktivan', 'Docent', 'Elektrotehnika', 1, 0, 0, 0, 0, '0000-0003-4567-8901', 'Internet of Things, embedded sistemi');

INSERT INTO ISTRAZIVAC (Ime, Prezime, Datum_Rodjenja, Drzava, Status_Naloga, Naucno_Zvanje, Naucna_Oblast, Je_Autor, Je_Recenzent, Je_Urednik, Je_Admin, Je_Rukovodilac_Projekta, ORCID, Oblast_Ekspertize, Uredjivacka_Sekcija)
VALUES ('Jelena', 'Markovic', DATE '1978-05-30', 'Srbija', 'aktivan', 'Redovni profesor', 'Matematika', 1, 1, 1, 0, 1, '0000-0004-5678-9012', 'Numerička analiza, optimizacija', 'Primenjena matematika');

INSERT INTO ISTRAZIVAC (Ime, Prezime, Datum_Rodjenja, Drzava, Status_Naloga, Naucno_Zvanje, Naucna_Oblast, Je_Autor, Je_Recenzent, Je_Urednik, Je_Admin, Je_Rukovodilac_Projekta, ORCID, Oblast_Ekspertize)
VALUES ('Nikola', 'Stojanovic', DATE '1988-02-14', 'Srbija', 'aktivan', 'Naucni saradnik', 'Fizika', 1, 0, 0, 0, 0, '0000-0005-6789-0123', 'Kvantna fizika, fotonika');

INSERT INTO ISTRAZIVAC (Ime, Prezime, Datum_Rodjenja, Drzava, Status_Naloga, Naucno_Zvanje, Naucna_Oblast, Je_Autor, Je_Recenzent, Je_Urednik, Je_Admin, Je_Rukovodilac_Projekta, ORCID, Oblast_Ekspertize)
VALUES ('Milica', 'Djordjevic', DATE '1993-09-18', 'Srbija', 'aktivan', 'Istrazivac saradnik', 'Racunarstvo i informatika', 1, 0, 0, 0, 0, '0000-0006-7890-1234', 'Bezbednost informacionih sistema');

INSERT INTO ISTRAZIVAC (Ime, Prezime, Datum_Rodjenja, Drzava, Status_Naloga, Naucno_Zvanje, Naucna_Oblast, Je_Autor, Je_Recenzent, Je_Urednik, Je_Admin, Je_Rukovodilac_Projekta, ORCID, Oblast_Ekspertize, Administratorska_Ovlascenja)
VALUES ('Ivan', 'Popovic', DATE '1970-12-01', 'Srbija', 'aktivan', 'Redovni profesor', 'Elektronika', 0, 1, 1, 1, 0, '0000-0007-8901-2345', 'Digitalna elektronika, FPGA', 'Upravljanje korisnicima, konfiguracija sistema');

INSERT INTO ISTRAZIVAC (Ime, Prezime, Datum_Rodjenja, Drzava, Status_Naloga, Naucno_Zvanje, Naucna_Oblast, Je_Autor, Je_Recenzent, Je_Urednik, Je_Admin, Je_Rukovodilac_Projekta, ORCID, Oblast_Ekspertize)
VALUES ('Maja', 'Ilic', DATE '1985-06-25', 'Srbija', 'aktivan', 'Docent', 'Hemija', 1, 1, 0, 0, 0, '0000-0008-9012-3456', 'Organska hemija, biomaterijali');

INSERT INTO ISTRAZIVAC (Ime, Prezime, Datum_Rodjenja, Drzava, Status_Naloga, Naucno_Zvanje, Naucna_Oblast, Je_Autor, Je_Recenzent, Je_Urednik, Je_Admin, Je_Rukovodilac_Projekta, ORCID, Oblast_Ekspertize)
VALUES ('Aleksandar', 'Vukovic', DATE '1980-04-10', 'Srbija', 'aktivan', 'Vanredni profesor', 'Telekomunikacije', 1, 1, 0, 0, 1, '0000-0009-0123-4567', '5G mreze, bezicne komunikacije');

INSERT INTO ISTRAZIVAC (Ime, Prezime, Datum_Rodjenja, Drzava, Status_Naloga, Naucno_Zvanje, Naucna_Oblast, Je_Autor, Je_Recenzent, Je_Urednik, Je_Admin, Je_Rukovodilac_Projekta, ORCID, Oblast_Ekspertize)
VALUES ('Dragana', 'Lazic', DATE '1991-08-07', 'Srbija', 'aktivan', 'Istrazivac saradnik', 'Vestacka inteligencija', 1, 0, 0, 0, 0, '0000-0010-1234-5678', 'Duboko ucenje, racunarski vid');

-- ------------------------------------------------------------
-- ISTRAZIVAC_EMAIL
-- ------------------------------------------------------------
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (1, 'marko.petrovic@matf.bg.ac.rs');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (1, 'm.petrovic@gmail.com');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (2, 'ana.jovanovic@uns.ac.rs');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (2, 'a.jovanovic@yahoo.com');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (3, 'stefan.nikolic@etf.rs');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (4, 'jelena.markovic@pmf.ni.ac.rs');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (4, 'j.markovic@uns.ac.rs');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (5, 'nikola.stojanovic@vin.bg.ac.rs');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (6, 'milica.djordjevic@fon.bg.ac.rs');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (7, 'ivan.popovic@etf.bg.ac.rs');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (8, 'maja.ilic@tmf.bg.ac.rs');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (9, 'aleksandar.vukovic@pupin.rs');
INSERT INTO ISTRAZIVAC_EMAIL (Id_Istrazivaca, Email) VALUES (10, 'dragana.lazic@pupin.rs');

-- ------------------------------------------------------------
-- ISTRAZIVAC_TELEFONI
-- ------------------------------------------------------------
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (1, '+381641234567');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (1, '+381112630300');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (2, '+381652345678');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (3, '+381603456789');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (4, '+381694567890');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (5, '+381615678901');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (6, '+381626789012');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (7, '+381637890123');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (7, '+381118901234');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (8, '+381648901234');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (9, '+381659012345');
INSERT INTO ISTRAZIVAC_TELEFONI (Id_Istrazivaca, Telefon) VALUES (10, '+381660123456');

-- ------------------------------------------------------------
-- ANGAZOVANJE
-- ------------------------------------------------------------
INSERT INTO ANGAZOVANJE (Id_Institucije, Id_Istrazivaca, Organizaciona_Jedinica, Tip_Angazovanja, Naziv_Pozicije, Datum_Pocetka)
VALUES (1, 1, 'Matematicki fakultet', 'Stalno', 'Redovni profesor', DATE '2010-10-01');

INSERT INTO ANGAZOVANJE (Id_Institucije, Id_Istrazivaca, Organizaciona_Jedinica, Tip_Angazovanja, Naziv_Pozicije, Datum_Pocetka)
VALUES (2, 2, 'Fakultet tehnickih nauka', 'Stalno', 'Vanredni profesor', DATE '2013-10-01');

INSERT INTO ANGAZOVANJE (Id_Institucije, Id_Istrazivaca, Organizaciona_Jedinica, Tip_Angazovanja, Naziv_Pozicije, Datum_Pocetka)
VALUES (2, 3, 'Fakultet tehnickih nauka', 'Stalno', 'Docent', DATE '2018-03-01');

INSERT INTO ANGAZOVANJE (Id_Institucije, Id_Istrazivaca, Organizaciona_Jedinica, Tip_Angazovanja, Naziv_Pozicije, Datum_Pocetka)
VALUES (3, 4, 'Prirodno-matematicki fakultet', 'Stalno', 'Redovni profesor', DATE '2008-10-01');

INSERT INTO ANGAZOVANJE (Id_Institucije, Id_Istrazivaca, Organizaciona_Jedinica, Tip_Angazovanja, Naziv_Pozicije, Datum_Pocetka)
VALUES (5, 5, 'Laboratorija za nuklearnu fiziku', 'Stalno', 'Naucni saradnik', DATE '2016-06-01');

INSERT INTO ANGAZOVANJE (Id_Institucije, Id_Istrazivaca, Organizaciona_Jedinica, Tip_Angazovanja, Naziv_Pozicije, Datum_Pocetka)
VALUES (1, 6, 'Fakultet organizacionih nauka', 'Stalno', 'Istrazivac saradnik', DATE '2019-09-01');

INSERT INTO ANGAZOVANJE (Id_Institucije, Id_Istrazivaca, Organizaciona_Jedinica, Tip_Angazovanja, Naziv_Pozicije, Datum_Pocetka)
VALUES (1, 7, 'Elektrotehnicki fakultet', 'Stalno', 'Redovni profesor', DATE '2005-10-01');

INSERT INTO ANGAZOVANJE (Id_Institucije, Id_Istrazivaca, Organizaciona_Jedinica, Tip_Angazovanja, Naziv_Pozicije, Datum_Pocetka)
VALUES (1, 8, 'Tehnoloski metalurski fakultet', 'Stalno', 'Docent', DATE '2015-02-01');

INSERT INTO ANGAZOVANJE (Id_Institucije, Id_Istrazivaca, Organizaciona_Jedinica, Tip_Angazovanja, Naziv_Pozicije, Datum_Pocetka)
VALUES (4, 9, 'Centar za telekomunikacije', 'Stalno', 'Vanredni profesor', DATE '2012-04-01');

INSERT INTO ANGAZOVANJE (Id_Institucije, Id_Istrazivaca, Organizaciona_Jedinica, Tip_Angazovanja, Naziv_Pozicije, Datum_Pocetka)
VALUES (4, 10, 'Laboratorija za AI', 'Projektno', 'Istrazivac saradnik', DATE '2020-01-01');

-- ------------------------------------------------------------
-- IZVOR
-- ------------------------------------------------------------
INSERT INTO IZVOR (Naziv) VALUES ('Journal of Machine Learning Research');
INSERT INTO IZVOR (Naziv) VALUES ('IEEE Transactions on Neural Networks');
INSERT INTO IZVOR (Naziv) VALUES ('ETRAN 2023 - Konferencija o elektronici, telekomunikacijama, racunarstvu');
INSERT INTO IZVOR (Naziv) VALUES ('YuInfo 2024 - Informatika i informacione tehnologije');
INSERT INTO IZVOR (Naziv) VALUES ('Expert Systems with Applications');

-- ------------------------------------------------------------
-- CASOPIS
-- ------------------------------------------------------------
INSERT INTO CASOPIS (Id_Izvora, ISSN, Broj_Sveske, Broj_Izdanja) VALUES (1, '15337928', 24, 3);
INSERT INTO CASOPIS (Id_Izvora, ISSN, Broj_Sveske, Broj_Izdanja) VALUES (2, '10459227', 35, 1);
INSERT INTO CASOPIS (Id_Izvora, ISSN, Broj_Sveske, Broj_Izdanja) VALUES (5, '09574174', 210, 2);

-- ------------------------------------------------------------
-- KONFERENCIJA
-- ------------------------------------------------------------
INSERT INTO KONFERENCIJA (Id_Izvora, ISBN) VALUES (3, '978-86-7466-930-1');
INSERT INTO KONFERENCIJA (Id_Izvora, ISBN) VALUES (4, '978-86-85525-30-7');

-- ------------------------------------------------------------
-- PUBLIKACIJA
-- ------------------------------------------------------------
-- P1: Naucni rad - objavljen
INSERT INTO PUBLIKACIJA (Naslov, Apstrakt, Jezik, Datum_Objavljivanja, Datum_Kreiranja_Zapisa, Status, Vidljivost)
VALUES (
    'Primena transformerskih modela u analizi srpskog teksta',
    'U ovom radu istrazen je potencijal transformerskih arhitektura, posebno BERT varijanti, za zadatke obrade srpskog prirodnog jezika. Eksperimentisano je sa modelima pretreniranim na visejezicnim korpusima i modelima fino podesenim na srpskim tekstualnim podacima. Rezultati pokazuju znacajno poboljsanje u zadacima klasifikacije sentimenta i prepoznavanja entiteta u poredenju sa tradicionalnim pristupu. Predlozena metodologija dostigla je F1 score od 0.89 na standardnim evaluacionim skupovima.',
    'srpski', DATE '2023-09-15', DATE '2023-06-01', 'objavljen', 'javna'
);

-- P2: Naucni rad - objavljen
INSERT INTO PUBLIKACIJA (Naslov, Apstrakt, Jezik, Datum_Objavljivanja, Datum_Kreiranja_Zapisa, Status, Vidljivost)
VALUES (
    'Optimizacija IoT senzorskih mreza primenom metaheuristika',
    'Internet of Things senzorske mreze suocavaju se sa izazovima ogranicenih energetskih resursa i neophodnosti dugog radnog veka. Ovaj rad predlaze hibridni algoritam koji kombinuje rojnu inteligenciju i genetske algoritme za optimizaciju rasporeda budenja cvorova. Evaluacija je sprovedena na simuliranom okruzenju sa 500 cvorova, pri cemu predlozeni pristup produzava zivotni vek mreze za 34% u poredenju sa aktuelnim metodama.',
    'engleski', DATE '2023-11-20', DATE '2023-07-10', 'objavljen', 'javna'
);

-- P3: Naucni rad - u recenziji
INSERT INTO PUBLIKACIJA (Naslov, Apstrakt, Jezik, Datum_Objavljivanja, Datum_Kreiranja_Zapisa, Status, Vidljivost)
VALUES (
    'Bezbednost pametnih ugovora na blockchain platformama',
    'Pametni ugovori predstavljaju fundamentalnu komponentu decentralizovanih aplikacija, ali njihove ranjivosti mogu prouzrokovati znacajne finansijske gubitke. Ovaj rad sistematski analizira klase ranjivosti pametnih ugovora na Ethereum platformi i predlaze automatizovani okvir za njihovu detekciju baziran na formalnoj verifikaciji i statickoj analizi koda. Evaluacijom na skupu od 10.000 realnih ugovora, alat je detektovao 91% poznatih ranjivosti uz stopu lazno pozitivnih rezultata ispod 5%.',
    'engleski', NULL, DATE '2024-01-15', 'poslat na recenziju', 'privatna'
);

-- P4: Knjiga - objavljena
INSERT INTO PUBLIKACIJA (Naslov, Apstrakt, Jezik, Datum_Objavljivanja, Datum_Kreiranja_Zapisa, Status, Vidljivost)
VALUES (
    'Numericke metode za inzenjere: teorija i primena',
    'Udzbenicka knjiga pokriva kljucne numericke metode neophodne u inzenjerskoj praksi: resavanje sistema linearnih jednacina, interpolacija, numericka integracija i diferencijacija, resavanje diferencijalnih jednacina i optimizacioni algoritmi. Svako poglavlje ukljucuje teorijsku osnovu, pseudokod i implementacije u programskim jezicima Python i MATLAB, kao i skup zadataka za vezbanje.',
    'srpski', DATE '2022-03-01', DATE '2021-09-01', 'objavljen', 'javna'
);

-- P5: Dataset - objavljen
INSERT INTO PUBLIKACIJA (Naslov, Apstrakt, Jezik, Datum_Objavljivanja, Datum_Kreiranja_Zapisa, Status, Vidljivost)
VALUES (
    'SrpNLP-Corpus: Anotiran korpus srpskog jezika za NLP zadatke',
    'Predstavljamo SrpNLP-Corpus, obiman anotiran skup podataka za srpski jezik koji obuhvata 250.000 recenica iz razlicitih domena: novinski clanci, naucni tekstovi, drustvene mreze i pravni dokumenti. Korpus je anotiran na nivou tokena za POS tagovanje, NER i zavisnosnu sintaksu. Dostupan je u CoNLL-U formatu i kompatibilan je sa popularnim NLP bibliotekama. Namenjen je istrazivacima koji razvijaju alate za obradu srpskog i srodnnih juzno-slovenskih jezika.',
    'engleski', DATE '2023-05-10', DATE '2023-02-20', 'objavljen', 'javna'
);

-- P6: Softverski artefakt - objavljen
INSERT INTO PUBLIKACIJA (Naslov, Apstrakt, Jezik, Datum_Objavljivanja, Datum_Kreiranja_Zapisa, Status, Vidljivost)
VALUES (
    'SrBERT: Fine-tuned BERT model za srpski jezik',
    'SrBERT je BERT model fino podesen na srpskom jeziku, dostupan kao open-source softverski artefakt. Model je treniran na korpusu od 2 milijarde tokena i postigao je vrhunske rezultate na evaluacionim skupovima za klasifikaciju teksta, prepoznavanje entiteta i analizu sentimenta. Paket ukljucuje pretreniran model, tokenizator, skripte za fino podesavanje i dokumentaciju sa primerima upotrebe.',
    'engleski', DATE '2023-08-01', DATE '2023-04-01', 'objavljen', 'javna'
);

-- P7: Naucni rad - u pripremi
INSERT INTO PUBLIKACIJA (Naslov, Apstrakt, Jezik, Datum_Objavljivanja, Datum_Kreiranja_Zapisa, Status, Vidljivost)
VALUES (
    'Kvantno racunanje i kriptografija: izazovi post-kvantne ere',
    'Ovaj rad analizira pretnje koje kvantni racunari predstavljaju za savremene kriptografske sisteme i pregleda aktuelne kandidate za post-kvantne kriptografske standarde koje razvija NIST. Posebna paznja posvecena je efikasnosti implementacije odabranih algoritama na mikrokontrolerskim platformama sa ogranicenim resursima.',
    'engleski', NULL, DATE '2024-03-01', 'u pripremi', 'privatna'
);

-- P8: Doktorska disertacija - objavljena
INSERT INTO PUBLIKACIJA (Naslov, Apstrakt, Jezik, Datum_Objavljivanja, Datum_Kreiranja_Zapisa, Status, Vidljivost)
VALUES (
    'Metode dubokog ucenja za detekciju anomalija u industrijskim sistemima',
    'Ova doktorska disertacija istrazuje primenu arhitektura dubokog ucenja, sa akcentom na autoenkodere i rekurentne neuronske mreze, za detekciju anomalija u kontinualnim industrijskim procesima. Predlozeni okvir omogucava adaptivno ucenje normalnog ponasanja sistema uz minimalan nadzor, sto ga cini prikladnim za realne industrijske scenarije. Eksperimentalna evaluacija izvrsena je na tri industrijska skupa podataka i pokazuje superiorne performanse u odnosu na state-of-the-art metode.',
    'srpski', DATE '2022-11-15', DATE '2021-10-01', 'objavljen', 'javna'
);

-- P9: Prezentacija - objavljena
INSERT INTO PUBLIKACIJA (Naslov, Apstrakt, Jezik, Datum_Objavljivanja, Datum_Kreiranja_Zapisa, Status, Vidljivost)
VALUES (
    '5G mreze i primene u pametnim gradovima',
    'Prezentacija daje pregled arhitekture 5G mrezne infrastrukture i ilustruje kljucne primene u konceptu pametnog grada: inteligentni saobracaj, pametna javna rasveta, daljinsko pracenje zivotne sredine i e-zdravstvo. Prikazani su rezultati pilot projekata u nekoliko evropskih gradova i razmotreni izazovi implementacije u kontekstu srbijanskih urbanih sredina.',
    'srpski', DATE '2023-06-10', DATE '2023-05-01', 'objavljen', 'javna'
);

-- P10: Naucni rad - prihvacen
INSERT INTO PUBLIKACIJA (Naslov, Apstrakt, Jezik, Datum_Objavljivanja, Datum_Kreiranja_Zapisa, Status, Vidljivost)
VALUES (
    'Sinteza nanomaterijala za biomedinske primene: pregled i perspektive',
    'U ovom preglednom radu dat je sistematski pregled metoda sinteze funkcionalnih nanomaterijala namenjenih biomedicinskim primenama, ukljucujuci dostavljanje lekova, biosenzore i dijagnosticke svrhe. Analizirani su kljucni parametri koji uticu na biokompatibilnost i efikasnost nanomaterijala, a razmotreni su i regulatorni aspekti njihove primene u medicinskim uredjajima.',
    'engleski', NULL, DATE '2023-12-01', 'prihvacen', 'javna'
);

-- ------------------------------------------------------------
-- NAUCNI_RAD
-- ------------------------------------------------------------
INSERT INTO NAUCNI_RAD (Id_Publikacije, DOI, Tip_Rada, Stranice, Id_Izvora)
VALUES (1, '10.5555/3455716.3455718', 'originalni naucni rad', '145-162', 1);

INSERT INTO NAUCNI_RAD (Id_Publikacije, DOI, Tip_Rada, Stranice, Id_Izvora)
VALUES (2, '10.1109/TNN.2023.3287654', 'originalni naucni rad', '88-101', 2);

INSERT INTO NAUCNI_RAD (Id_Publikacije, DOI, Tip_Rada, Stranice, Id_Izvora)
VALUES (3, NULL, 'originalni naucni rad', NULL, 5);

INSERT INTO NAUCNI_RAD (Id_Publikacije, DOI, Tip_Rada, Stranice, Id_Izvora)
VALUES (7, NULL, 'pregledni rad', NULL, 5);

INSERT INTO NAUCNI_RAD (Id_Publikacije, DOI, Tip_Rada, Stranice, Id_Izvora)
VALUES (10, '10.1016/j.eswa.2024.123456', 'pregledni rad', NULL, 5);

-- ------------------------------------------------------------
-- KNJIGA
-- ------------------------------------------------------------
INSERT INTO KNJIGA (Id_Publikacije, Izdavac, Mesto_Izdanja)
VALUES (4, 'Akademska misao', 'Beograd');

-- ------------------------------------------------------------
-- KNJIGA_UREDNICI
-- ------------------------------------------------------------
INSERT INTO KNJIGA_UREDNICI (Id_Publikacije, Urednik) VALUES (4, 'Prof. dr Jelena Markovic');
INSERT INTO KNJIGA_UREDNICI (Id_Publikacije, Urednik) VALUES (4, 'Prof. dr Marko Petrovic');

-- ------------------------------------------------------------
-- DATASET
-- ------------------------------------------------------------
INSERT INTO DATASET (Id_Publikacije, Broj_Zapisa, Velicina, Opis_Strukture, Format, Licenca_Koriscenja, Datum_Od, Datum_Do)
VALUES (5, 250000, 1800,
    'CoNLL-U format sa kolonama: ID, FORM, LEMMA, UPOS, XPOS, FEATS, HEAD, DEPREL, DEPS, MISC. Svaka recenica odvojena praznim redom.',
    'CoNLL-U', 'CC BY 4.0', DATE '2018-01-01', DATE '2022-12-31');

-- ------------------------------------------------------------
-- SOFTVERSKI_ARTEFAKT
-- ------------------------------------------------------------
INSERT INTO SOFTVERSKI_ARTEFAKT (Id_Publikacije, Programski_Jezik, Dokumentacija, Link_Ka_Repozitorijumu, Nacin_Licenciranja)
VALUES (6, 'Python',
    'Model se ucitava koriscenjem Hugging Face Transformers biblioteke. Detaljna dokumentacija dostupna na GitHub stranici projekta ukljucujuci primere finog podesavanja i inference skripte.',
    'https://github.com/example/srbert', 'Apache 2.0');

-- ------------------------------------------------------------
-- SA_PODRZANE_PLATFORME
-- ------------------------------------------------------------
INSERT INTO SA_PODRZANE_PLATFORME (Id_Publikacije, Podrzana_Platforma) VALUES (6, 'Linux x86_64');
INSERT INTO SA_PODRZANE_PLATFORME (Id_Publikacije, Podrzana_Platforma) VALUES (6, 'Windows 10/11 x64');
INSERT INTO SA_PODRZANE_PLATFORME (Id_Publikacije, Podrzana_Platforma) VALUES (6, 'macOS ARM64');

-- ------------------------------------------------------------
-- DOKTORSKA_DISERTACIJA
-- ------------------------------------------------------------
INSERT INTO DOKTORSKA_DISERTACIJA (Id_Publikacije) VALUES (8);

-- ------------------------------------------------------------
-- PREZENTACIJA
-- ------------------------------------------------------------
INSERT INTO PREZENTACIJA (Id_Publikacije) VALUES (9);

-- ------------------------------------------------------------
-- AUTORSTVO
-- ------------------------------------------------------------
-- P1: Petrovic (1), Jovanovic (2), Lazic (10)
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (1, 1, 1, 'Konceptualizacija, metodologija, pisanje', 'Korespondentni autor');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (1, 2, 2, 'Implementacija, evaluacija', 'Koautor');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (1, 10, 3, 'Anotacija podataka, eksperimenti', 'Koautor');

-- P2: Nikolic (3), Petrovic (1)
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (2, 3, 1, 'Konceptualizacija, implementacija, pisanje', 'Korespondentni autor');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (2, 1, 2, 'Metodologija, revizija', 'Koautor');

-- P3: Djordjevic (6), Popovic (7)
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (3, 6, 1, 'Konceptualizacija, analiza, pisanje', 'Korespondentni autor');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (3, 7, 2, 'Supervizija, revizija', 'Koautor');

-- P4: Markovic (4)
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (4, 4, 1, 'Autor', 'Jedini autor');

-- P5: Petrovic (1), Jovanovic (2), Lazic (10)
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (5, 1, 1, 'Dizajn korpusa, supervizija anotacije', 'Korespondentni autor');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (5, 2, 2, 'Anotacione smernice, validacija', 'Koautor');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (5, 10, 3, 'Prikupljanje podataka, anotacija', 'Koautor');

-- P6: Petrovic (1), Lazic (10)
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (6, 1, 1, 'Arhitektura, trening, dokumentacija', 'Korespondentni autor');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (6, 10, 2, 'Eksperimenti, evaluacija', 'Koautor');

-- P7: Djordjevic (6), Stojanovic (5)
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (7, 6, 1, 'Istrazivanje, pisanje', 'Korespondentni autor');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (7, 5, 2, 'Kvantni deo, revizija', 'Koautor');

-- P8: Lazic (10), Petrovic (1) - doktorat
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (8, 10, 1, 'Istrazivaç', 'Doktorand');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (8, 1, 2, 'Supervizija', 'Mentor');

-- P9: Vukovic (9), Nikolic (3)
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (9, 9, 1, 'Konceptualizacija, prezentacija', 'Glavni autor');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (9, 3, 2, 'Tehnicka analiza', 'Koautor');

-- P10: Ilic (8), Markovic (4)
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (10, 8, 1, 'Konceptualizacija, pisanje, revizija', 'Korespondentni autor');
INSERT INTO AUTORSTVO (Id_Publikacije, Id_Autora, Redosled_Autora, Tip_Doprinosa, Uloga) VALUES (10, 4, 2, 'Metodoloski doprinos', 'Koautor');

-- ------------------------------------------------------------
-- PUBLIKACIJA_KLJUCNE_RECI
-- ------------------------------------------------------------
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (1, 'obrada prirodnog jezika');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (1, 'BERT');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (1, 'srpski jezik');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (1, 'transfer learning');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (2, 'Internet of Things');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (2, 'optimizacija senzorskih mreza');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (2, 'metaheuristike');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (2, 'energetska efikasnost');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (3, 'blockchain');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (3, 'pametni ugovori');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (3, 'bezbednost');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (3, 'formalna verifikacija');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (4, 'numericke metode');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (4, 'inzenjerska matematika');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (4, 'Python');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (5, 'korpus');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (5, 'anotacija');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (5, 'srpski jezik');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (5, 'NER');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (6, 'BERT');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (6, 'NLP');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (6, 'open source');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (7, 'kvantno racunanje');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (7, 'kriptografija');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (7, 'post-kvantna bezbednost');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (8, 'duboko ucenje');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (8, 'detekcija anomalija');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (8, 'industrijski sistemi');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (8, 'autoenkoder');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (9, '5G');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (9, 'pametni grad');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (9, 'IoT');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (10, 'nanomaterijali');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (10, 'biomedinska primena');
INSERT INTO PUBLIKACIJA_KLJUCNE_RECI (Id_Publikacije, Kljucna_Rec) VALUES (10, 'dostavljanje lekova');

-- ------------------------------------------------------------
-- VERZIJA
-- ------------------------------------------------------------
INSERT INTO VERZIJA (Broj_Verzije, Id_Publikacije, Datum_Postavljanja, Opis_Izmene, Odgovorna_Osoba)
VALUES (1, 1, DATE '2023-06-01', 'Inicijalna verzija rada', 'Marko Petrovic');
INSERT INTO VERZIJA (Broj_Verzije, Id_Publikacije, Datum_Postavljanja, Opis_Izmene, Odgovorna_Osoba)
VALUES (2, 1, DATE '2023-07-15', 'Revizija nakon komentara recenzenata - prosirena sekcija eksperimenata', 'Marko Petrovic');
INSERT INTO VERZIJA (Broj_Verzije, Id_Publikacije, Datum_Postavljanja, Opis_Izmene, Odgovorna_Osoba)
VALUES (3, 1, DATE '2023-08-20', 'Finalna verzija prihvacena za objavljivanje', 'Marko Petrovic');

INSERT INTO VERZIJA (Broj_Verzije, Id_Publikacije, Datum_Postavljanja, Opis_Izmene, Odgovorna_Osoba)
VALUES (1, 2, DATE '2023-07-10', 'Inicijalna verzija', 'Stefan Nikolic');
INSERT INTO VERZIJA (Broj_Verzije, Id_Publikacije, Datum_Postavljanja, Opis_Izmene, Odgovorna_Osoba)
VALUES (2, 2, DATE '2023-09-05', 'Dodata komparativna evaluacija sa novijim metodama', 'Stefan Nikolic');

INSERT INTO VERZIJA (Broj_Verzije, Id_Publikacije, Datum_Postavljanja, Opis_Izmene, Odgovorna_Osoba)
VALUES (1, 3, DATE '2024-01-15', 'Inicijalna verzija poslata na recenziju', 'Milica Djordjevic');

INSERT INTO VERZIJA (Broj_Verzije, Id_Publikacije, Datum_Postavljanja, Opis_Izmene, Odgovorna_Osoba)
VALUES (1, 5, DATE '2023-02-20', 'Inicijalno objavljivanje korpusa v1.0', 'Marko Petrovic');
INSERT INTO VERZIJA (Broj_Verzije, Id_Publikacije, Datum_Postavljanja, Opis_Izmene, Odgovorna_Osoba)
VALUES (2, 5, DATE '2023-04-10', 'Dodat pravni domen, ispravke anotacija', 'Ana Jovanovic');

INSERT INTO VERZIJA (Broj_Verzije, Id_Publikacije, Datum_Postavljanja, Opis_Izmene, Odgovorna_Osoba)
VALUES (1, 6, DATE '2023-04-01', 'Inicijalno objavljivanje modela v1.0', 'Marko Petrovic');
INSERT INTO VERZIJA (Broj_Verzije, Id_Publikacije, Datum_Postavljanja, Opis_Izmene, Odgovorna_Osoba)
VALUES (2, 6, DATE '2023-06-15', 'Azuriran model sa vise trening podataka, popravke u dokumentaciji', 'Dragana Lazic');

-- ------------------------------------------------------------
-- FAJLOVI
-- ------------------------------------------------------------
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (1, 'transformeri_srpski_v1.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (2, 'transformeri_srpski_v2_revised.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (2, 'supplementary_experiments.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (3, 'transformeri_srpski_final.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (4, 'iot_optimizacija_v1.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (5, 'iot_optimizacija_v2.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (6, 'blockchain_security_v1.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (7, 'srpnlp_corpus_v1.zip');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (7, 'annotation_guidelines_v1.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (8, 'srpnlp_corpus_v2.zip');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (8, 'annotation_guidelines_v2.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (9, 'srbert_model_v1.zip');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (9, 'srbert_docs_v1.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (10, 'srbert_model_v2.zip');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (10, 'srbert_docs_v2.pdf');
INSERT INTO FAJLOVI (Id_Verzije, Fajl) VALUES (10, 'evaluation_scripts.zip');

-- ------------------------------------------------------------
-- RUNDA_RECENZIJE
-- ------------------------------------------------------------
INSERT INTO RUNDA_RECENZIJE (Broj_Runde, Id_Publikacije, Datum, Konacna_Odluka, Id_Urednika)
VALUES (1, 1, DATE '2023-06-20', 'manja revizija', 7);
INSERT INTO RUNDA_RECENZIJE (Broj_Runde, Id_Publikacije, Datum, Konacna_Odluka, Id_Urednika)
VALUES (2, 1, DATE '2023-08-01', 'prihvacen', 7);

INSERT INTO RUNDA_RECENZIJE (Broj_Runde, Id_Publikacije, Datum, Konacna_Odluka, Id_Urednika)
VALUES (1, 2, DATE '2023-08-01', 'manja revizija', 4);
INSERT INTO RUNDA_RECENZIJE (Broj_Runde, Id_Publikacije, Datum, Konacna_Odluka, Id_Urednika)
VALUES (2, 2, DATE '2023-10-15', 'prihvacen', 4);

INSERT INTO RUNDA_RECENZIJE (Broj_Runde, Id_Publikacije, Datum, Konacna_Odluka, Id_Urednika)
VALUES (1, 3, DATE '2024-02-20', NULL, 1);

INSERT INTO RUNDA_RECENZIJE (Broj_Runde, Id_Publikacije, Datum, Konacna_Odluka, Id_Urednika)
VALUES (1, 10, DATE '2024-01-10', 'prihvacen', 7);

-- ------------------------------------------------------------
-- VRSI_RECENZIJU
-- ------------------------------------------------------------
-- Runda 1 rada P1 (Id_Runde=1): recenzenti su Jovanovic(2) i Popovic(7)
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (1, 2, 'manja revizija');
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (1, 4, 'prihvati');

-- Runda 2 rada P1 (Id_Runde=2)
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (2, 2, 'prihvati');
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (2, 4, 'prihvati');

-- Runda 1 rada P2 (Id_Runde=3)
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (3, 9, 'manja revizija');
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (3, 2, 'prihvati');

-- Runda 2 rada P2 (Id_Runde=4)
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (4, 9, 'prihvati');
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (4, 2, 'prihvati');

-- Runda 1 rada P3 (Id_Runde=5)
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (5, 7, NULL);
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (5, 9, NULL);

-- Runda 1 rada P10 (Id_Runde=6)
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (6, 2, 'prihvati');
INSERT INTO VRSI_RECENZIJU (Id_Runde_Recenzije, Id_Recenzenta, Preporuka) VALUES (6, 8, 'prihvati');

-- ------------------------------------------------------------
-- CITIRA
-- ------------------------------------------------------------
-- P1 citira P5 (koristili smo korpus za trening)
INSERT INTO CITIRA (Id_Publikacije, Id_Citata, Tip_Citata, Mesto_Citiranja, Tekstualni_Kontekst)
VALUES (1, 5, 'direktna referenca', 'Sekcija 3.1 - Podaci', 'Za trening modela koriscen je SrpNLP-Corpus (ref)');

-- P1 citira P6
INSERT INTO CITIRA (Id_Publikacije, Id_Citata, Tip_Citata, Mesto_Citiranja, Tekstualni_Kontekst)
VALUES (1, 6, 'poredenje', 'Sekcija 4 - Eksperimenti', 'Poredenje sa SrBERT baznom linijom');

-- P2 citira P9
INSERT INTO CITIRA (Id_Publikacije, Id_Citata, Tip_Citata, Mesto_Citiranja, Tekstualni_Kontekst)
VALUES (2, 9, 'kontekstualna referenca', 'Uvod', 'IoT kao kljucna komponenta pametnih gradova');

-- P6 citira P5
INSERT INTO CITIRA (Id_Publikacije, Id_Citata, Tip_Citata, Mesto_Citiranja, Tekstualni_Kontekst)
VALUES (6, 5, 'direktna referenca', 'Sekcija 2 - Trening podaci', 'Model je treniran na SrpNLP-Corpus skupu podataka');

-- P7 citira P3
INSERT INTO CITIRA (Id_Publikacije, Id_Citata, Tip_Citata, Mesto_Citiranja, Tekstualni_Kontekst)
VALUES (7, 3, 'kontekstualna referenca', 'Sekcija 1 - Uvod', 'Bezbednosni aspekti blockchain sistema');

-- P8 citira P1
INSERT INTO CITIRA (Id_Publikacije, Id_Citata, Tip_Citata, Mesto_Citiranja, Tekstualni_Kontekst)
VALUES (8, 1, 'metodoloski uticaj', 'Sekcija 2 - Pregled literature', 'Primena NLP tehnika u industrijskoj dijagnostici');

-- ------------------------------------------------------------
-- POVEZAN_SA
-- ------------------------------------------------------------
-- P1 i P6 su tesno povezani (rad i softver)
INSERT INTO POVEZAN_SA (Id_Publikacije_1, Id_Publikacije_2, Tip_Povezanosti) VALUES (1, 6, 'istrazi, a zatim objavio softver');
-- P5 i P6 - korpus i model
INSERT INTO POVEZAN_SA (Id_Publikacije_1, Id_Publikacije_2, Tip_Povezanosti) VALUES (5, 6, 'trening podaci za model');
-- P8 i P1 - doktorat proistekao iz istrazivanja
INSERT INTO POVEZAN_SA (Id_Publikacije_1, Id_Publikacije_2, Tip_Povezanosti) VALUES (8, 1, 'doktorat zasnovan na prethodnom radu');

COMMIT;
