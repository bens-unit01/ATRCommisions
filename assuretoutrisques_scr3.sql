rem création de la table t_timemachine 


DROP TABLE t_timemachine;
CREATE TABLE t_timemachine
(
id_date integer primary key,
date_courante date
);


INSERT INTO t_timemachine
VALUES( 1, sysdate);

commit;