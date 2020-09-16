-- DROP TABLE tab_users;
-- DROP TABLE tab_grade;
-- DROP TABLE tab_class;
-- DROP TABLE tab_student;

CREATE TABLE tab_users(
	uId INT PRIMARY KEY AUTO_INCREMENT,
	uName VARCHAR(10) UNIQUE NOT NULL,
	uPassword VARCHAR(10) NOT NULL
);

CREATE TABLE tab_grade(
	gId INT PRIMARY KEY AUTO_INCREMENT,
	gName VARCHAR(200) UNIQUE NOT NULL
);

-- ALTER TABLE tab_grade CHANGE gName gName VARCHAR(200) UNIQUE NOT NULL;

CREATE TABLE tab_class(
	cId  INT PRIMARY KEY AUTO_INCREMENT,
	cName VARCHAR(200) NOT NULL,
	gId INT,
	comment VARCHAR(500)
);

ALTER TABLE tab_class ADD CONSTRAINT tab_class_gId FOREIGN KEY(gId) REFERENCES tab_grade(gId);

CREATE TABLE tab_student(
	sId INT PRIMARY KEY AUTO_INCREMENT,
	sName VARCHAR(10) NOT NULL,
	sGender CHAR(6) CHECK(sGender in ('male', 'female')) NOT NULL,
	cId INT,
	sPhone VARCHAR(20) NOT NULL UNIQUE,
	createTime TIMESTAMP NOT NULL
);
ALTER TABLE tab_student AUTO_INCREMENT=1000;

ALTER TABLE tab_student ADD CONSTRAINT tab_student_cId FOREIGN KEY(cId) REFERENCES tab_class(cId);


INSERT INTO tab_users VALUES(NULL, 'lucy', '123');

SELECT * FROM tab_users WHERE uName='lucy' AND uPassword='123';

-- DELETE FROM tab_grade;

INSERT INTO tab_grade VALUES(NULL, '2019Fall');
INSERT INTO tab_grade VALUES(NULL, '2020Winter');
INSERT INTO tab_grade VALUES(NULL, '2020Summer');
INSERT INTO tab_grade VALUES(NULL, '2020Fall');
INSERT INTO tab_grade VALUES(NULL, '2021Winter');

SELECT * FROM tab_grade;

SELECT * FROM tab_class;

-- DELETE FROM tab_class;

INSERT INTO tab_class VALUES(NULL, 'Game Programming', 2, 'Interactive Game Development');
INSERT INTO tab_class VALUES(NULL, 'Software Engineering Development', 1, 'Software Engineering Development Co-op Program');
INSERT INTO tab_class VALUES(NULL, 'Animation - 3D', 2, 'Post-secondary program; 2 years/ 4 semesters (16 months continuous)');
INSERT INTO tab_class VALUES(NULL, 'Digital Visual Effects', 3, 'Post-secondary program; 2 years/ 4 semesters');

SELECT 
	c.cId, c.cName, g.gName, c.comment 
FROM tab_class c 
JOIN tab_grade g 
ON c.gId=g.gId
WHERE c.cName LIKE '%p%';

SELECT gId, gName FROM tab_grade ORDER BY gId;

SELECT * FROM tab_class WHERE cName='GAME PROGRAMMING';

DELETE FROM tab_student;

SELECT * FROM tab_student WHERE sName='cong';

INSERT INTO tab_student VALUES(NULL, 'Cong', 'male', '1', 1234567890, NOW());
INSERT INTO tab_student VALUES(NULL, 'Max', 'male', '2', 123123, NOW());
INSERT INTO tab_student VALUES(NULL, 'Vivian', 'female', '3', 321321, NOW());
INSERT INTO tab_student VALUES(NULL, 'Heesoo', 'female', '4', 234234, NOW());
INSERT INTO tab_student VALUES(NULL, 'Jenny', 'female', '1', 124214, NOW());

SELECT cId, cName FROM tab_class WHERE gId=1;

SELECT cId, cName FROM tab_class ORDER BY cId;

SELECT c.cId, c.cName, g.gName FROM tab_class c JOIN tab_grade g ON c.gId=g.gId WHERE c.cName='game programming';


SELECT s.sId, s.sName, s.sGender, c.cId, g.gId, s.sPhone FROM tab_student s JOIN tab_class c ON s.cId=c.cId JOIN tab_grade g ON c.gId=g.gId WHERE s.sId=1015;

SELECT s.sId, s.sName, s.sGender, c.cName, g.gName, s.sPhone, s.createTime FROM tab_student s JOIN tab_class c ON s.cId=c.cId JOIN tab_grade g ON c.gId=g.gId


ALTER TABLE tab_student ADD isDeleted INT NOT NULL DEFAULT 0;

ALTER TABLE tab_class ADD isDeleted INT NOT NULL DEFAULT 0;

ALTER TABLE tab_grade ADD isDeleted INT NOT NULL DEFAULT 0;

UPDATE tab_student SET sName='Cong', sGender='Female', cId=1, sPhone=321123 WHERE sId=1011;

SELECT c.cId, c.cName, g.gName, c.comment FROM tab_class c JOIN tab_grade g ON c.gId = g.gId WHERE 1=1;

SELECT c.cName, c.gId, c.comment 
                                FROM tab_class c 
                                JOIN tab_grade g 
                                ON c.gId=g.gId 
																WHERE c.cId=1;
																
																
SELECT * FROM tab_grade;