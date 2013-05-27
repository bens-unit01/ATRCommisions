rem
rem remplissage des tables 

rem table type_polices 

INSERT INTO type_polices VALUES
	(1,'assur_voiture1','formule de base', 0.05, 200);
	
INSERT INTO type_polices VALUES
	(2,'assur_voiture2','formule de base plus', 0.08, 200);

INSERT INTO type_polices VALUES
	(3,'assur_voiture3','formule avancée ', 0.1, 200);
	
INSERT INTO type_polices VALUES
	(4,'assur_maison1','formule de base', 0.05, 200);
	
INSERT INTO type_polices VALUES
	(5,'assur_maison2','formule de base plus', 0.1, 200);
	
INSERT INTO type_polices VALUES
	(6,'assur_maison3','formule avancée', 0.12, 200);
	

rem table clients 


INSERT INTO clients VALUES
	(1,'Foresti','Michel', '10 rue des lilas');
	
INSERT INTO clients VALUES
	(2,'Foresti','Pierre', '77 boul. Henri bourassa');
	
INSERT INTO clients VALUES
	(3,'Foresti','Jaques', '1789 boul. Sherbrooke est');
	
INSERT INTO clients VALUES
	(4,'Foresti','Simon', '144 rue st-hubert');

rem sequence agents_seq
DROP SEQUENCE agents_seq;
CREATE SEQUENCE agents_seq
  MINVALUE 1290000
  MAXVALUE 9999999
  START WITH 1290000
  INCREMENT BY 1
  CACHE 20;
  
  rem sequence polices 
  DROP SEQUENCE polices_seq;
CREATE SEQUENCE polices_seq
  MINVALUE 400
  MAXVALUE 9999999
  START WITH 400
  INCREMENT BY 1
  CACHE 20;


rem tables agents  et polices 


INSERT INTO agents VALUES
	(1,'admin','1111','FlouFlou', 'Jean', '10 rue des lilas');
	
rem 1er agent 	
INSERT INTO agents VALUES
	(2,'agent','1111','TestProfile', 'test', '10 rue des lilas');
rem polices vendu par l'agent 
INSERT INTO polices VALUES
	(polices_seq.nextval,'vendu', sysdate , sysdate+100, sysdate+5, null, 40, 'mensuel', 100, 1, 1, 2);


INSERT INTO polices VALUES
	(polices_seq.nextval,'vendu', sysdate , sysdate+100, sysdate+5, null, 50, 'mensuel', 100, 1, 2, 2 );


INSERT INTO polices VALUES
	(polices_seq.nextval,'vendu', sysdate , sysdate+100, sysdate+5, null, 35, 'mensuel', 100, 1, 3, 2 );
rem polices en cours 
INSERT INTO polices VALUES
	(polices_seq.nextval,'encours', sysdate , sysdate+100, sysdate+5, null, 35, 'mensuel', 100, 1, null, 2 );
	
INSERT INTO polices VALUES
	(polices_seq.nextval,'encours', sysdate , sysdate+100, sysdate+5, null, 35, 'mensuel', 100, 1, null, 2 );
	
INSERT INTO polices VALUES
	(polices_seq.nextval,'encours', sysdate , sysdate+100, sysdate+5, null, 35, 'mensuel', 100, 1, null, 2 );
	
rem 2eme agent
INSERT INTO agents VALUES
	(agents_seq.nextval,'agent','1111','ClairClair', 'Abdel', '10 rue des lilas');

rem polices vendu par l'agent 

INSERT INTO polices VALUES
	(polices_seq.nextval,'vendu', sysdate , sysdate+100, sysdate+5, null, 40, 'mensuel', 100, 1, 4, agents_seq.currval);



INSERT INTO polices VALUES
	(polices_seq.nextval,'vendu', sysdate , sysdate+100, sysdate+5, null, 50, 'mensuel', 100, 4, 4, agents_seq.currval);


INSERT INTO polices VALUES
	(polices_seq.nextval,'vendu', sysdate , sysdate+100, sysdate+5, null, 30, 'mensuel', 100, 2, 3, agents_seq.currval);
	
rem polices en cours 
INSERT INTO polices VALUES
	(polices_seq.nextval,'encours', sysdate , sysdate+100, sysdate+5, null, 35, 'mensuel', 100, 1, null, agents_seq.currval);
	
INSERT INTO polices VALUES
	(polices_seq.nextval,'encours', sysdate , sysdate+100, sysdate+5, null, 35, 'mensuel', 100, 1, null, agents_seq.currval);
	
INSERT INTO polices VALUES
	(polices_seq.nextval,'encours', sysdate , sysdate+100, sysdate+5, null, 35, 'mensuel', 100, 1, null, agents_seq.currval);
	
rem 3eme agent
	
INSERT INTO agents VALUES
	(agents_seq.nextval,'agent','1111','Tremblay', 'Sophie', '10 rue des lilas');
rem polices vendures par l'agent
INSERT INTO polices VALUES
	(polices_seq.nextval,'vendu', sysdate , sysdate+100, sysdate+5, null, 30, 'mensuel', 100, 3, 2, agents_seq.currval );


INSERT INTO polices VALUES
	(polices_seq.nextval,'vendu', sysdate , sysdate+100, sysdate+5, null, 25, 'mensuel', 100, 2, 2, agents_seq.currval );
	
rem polices en cours 

INSERT INTO polices VALUES
	(polices_seq.nextval,'encours', sysdate , sysdate+100, sysdate+5, null, 35, 'mensuel', 100, 1, null, agents_seq.currval);
	
INSERT INTO polices VALUES
	(polices_seq.nextval,'encours', sysdate , sysdate+100, sysdate+5, null, 35, 'mensuel', 100, 1, null, agents_seq.currval);
	
INSERT INTO polices VALUES
	(polices_seq.nextval,'encours', sysdate , sysdate+100, sysdate+5, null, 35, 'mensuel', 100, 1, null, agents_seq.currval);

rem 4eme et 5eme agents
	
INSERT INTO agents VALUES
	(agents_seq.nextval,'agent','1111','FlouFlou', 'Jean', '10 rue des lilas');
	
INSERT INTO agents VALUES
	(agents_seq.nextval,'agent','1111','FlouFlou', 'Paul', '10 rue des lilas');
	
commit;


	





	




	
	
	
		

	
	
	


