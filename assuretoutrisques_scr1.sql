
drop table paiements;
drop table polices;
drop table  type_polices;
drop table agents;



CREATE TABLE type_polices 
(
type_id integer CONSTRAINT type_id_type_polices_pk PRIMARY KEY,
nom_police varchar2(14) not null,
description varchar2(100),
pourcentage_com  number(2, 2) ,
prix number(6, 2)
);



CREATE TABLE agents 
(
agent_id integer CONSTRAINT agent_id_agents_pk PRIMARY KEY,
profile varchar2(10) not null,
mot_passe varchar2(14) not null,
nom	varchar2(30) not null,
prenom  varchar2(30) not null,
adresse varchar2(30),
 CONSTRAINT profile_enum CHECK (profile IN ('admin','agent') )
);




drop table clients;
CREATE TABLE clients
(
client_id integer CONSTRAINT client_id_clients_pk PRIMARY KEY,
nom varchar2(14) not null,
prenom varchar2(14) not null,
adresse varchar2(30)
);


CREATE TABLE polices
(
police_id integer CONSTRAINT police_id_polices_pk PRIMARY KEY,
etat	varchar2(14)  default 'encours',
date_debut date,
date_fin date,
date_achat date,
date_annulation date,
montant_com number(6, 2),  	
fequence_paiement_client   varchar2(14),
montant_paiement_client  number(6, 2),
type_id integer not null,
client_id integer, 
agent_id integer not null,
CONSTRAINT etat_police_enum CHECK (etat IN ('encours','vendu', 'annule') ),
 FOREIGN KEY (type_id) REFERENCES type_polices (type_id),
 FOREIGN KEY (client_id) REFERENCES clients (client_id),
 FOREIGN KEY (agent_id) REFERENCES agents (agent_id)
);



CREATE TABLE paiements
(
paiement_id  integer CONSTRAINT paiement_id_paiements_pk PRIMARY KEY,
type_paiement varchar2(14) not null,
num_cheque varchar2(14),
date_paiement date not null, 
montant_paiement number(6, 2),
police_id integer not null,
agent_id integer not null,
FOREIGN KEY (police_id) REFERENCES polices (police_id),
FOREIGN KEY (agent_id) REFERENCES agents (agent_id)
);

