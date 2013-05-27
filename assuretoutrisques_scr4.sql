rem prcédure stocké et trigger pour la génération des paiements 
rem création du trigger qui génère les paiements à chaque 1er du mois

DROP SEQUENCE paiements_seq;
CREATE SEQUENCE paiements_seq
  MINVALUE 1
  MAXVALUE 9999999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;


CREATE OR REPLACE PROCEDURE  creer_paiements(date_courante IN DATE) 
IS
	var_police_id polices.police_id%TYPE;
	var_agent_id agents.agent_id%TYPE;
	var_montant_com polices.montant_com%TYPE;

CURSOR cur_polices IS 
	SELECT police_id, agent_id, montant_com FROM polices 
	WHERE (( date_courante - date_debut) > 0) AND ((date_courante - date_debut) < 1825) 
	AND ( etat = 'vendu');

BEGIN

	OPEN cur_polices;

	LOOP 

		FETCH cur_polices INTO var_police_id, var_agent_id, var_montant_com;
		EXIT WHEN cur_polices%NOTFOUND;

		INSERT INTO paiements
		(paiement_id, type_paiement, date_paiement, montant_paiement, police_id, agent_id)
		VALUES
		(paiements_seq.nextval, 'residuel', date_courante , var_montant_com*0.1, var_police_id, var_agent_id);

	END LOOP;


END;
/


create or replace
TRIGGER generer_paiements_residuels
  BEFORE UPDATE ON t_timemachine
  FOR EACH ROW
WHEN (to_char(new.date_courante,'DD') = '01')
DECLARE
  
BEGIN

creer_paiements(:new.date_courante);


END;
/