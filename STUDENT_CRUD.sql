CREATE TABLE STUDENT (
	ID INT NOT NULL,
	NAME VARCHAR(255) NOT NULL,
	AGE INT NOT NULL,
	SEX VARCHAR(3) NOT NULL
);

ALTER TABLE STUDENT ADD CONSTRAINT PK_STUDENT PRIMARY KEY (ID);

INSERT INTO STUDENT (ID, NAME, AGE, SEX) VALUES (20120217, 'L? Minh Tr?', 21, 'Nam');

CREATE TABLE ACCOUNT (
	USERNAME VARCHAR(255) NOT NULL,
	PASSWORD VARCHAR(255) NOT NULL,
);

ALTER TABLE ACCOUNT ADD CONSTRAINT PK_ACCOUNT PRIMARY KEY (USERNAME);

INSERT INTO ACCOUNT (USERNAME, PASSWORD) VALUES ('user1', '123');