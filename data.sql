CREATE TABLE `Students` (
  `idStudent` int NOT NULL AUTO_INCREMENT,
  `credential` varchar(20) DEFAULT NULL,
  `name` varchar(50) NOT NULL DEFAULT '',
  `firstLastName` varchar(30) DEFAULT NULL,
  `secondLastName` varchar(30) DEFAULT NULL,
  `gender` tinyint NOT NULL DEFAULT '0',
  `birthday` date NOT NULL DEFAULT '0000-00-00',
  `registration_date` date DEFAULT NULL,
  `user` varchar(15) DEFAULT NULL,
  `password` varchar(32) DEFAULT NULL,
  `phone` varchar(50) DEFAULT NULL,
  `mail` varchar(70) DEFAULT NULL,
  PRIMARY KEY (`idStudent`)
) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8mb4;


CREATE TABLE `Teachers` (
  `idTeacher` int NOT NULL AUTO_INCREMENT,
  `credential` varchar(20) DEFAULT NULL,
  `name` varchar(50) NOT NULL DEFAULT '',
  `firstLastName` varchar(30) DEFAULT NULL,
  `secondLastName` varchar(30) DEFAULT NULL,
  `gender` tinyint NOT NULL DEFAULT '0',
  `birthday` date NOT NULL DEFAULT '0000-00-00',
  `registration_date` date DEFAULT NULL,
  `user` varchar(15) DEFAULT NULL,
  `password` varchar(32) DEFAULT NULL,
  `phone` varchar(50) DEFAULT NULL,
  `mail` varchar(70) DEFAULT NULL,
  PRIMARY KEY (`idTeacher`)
) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8mb4;


INSERT INTO Students (idStudent,credential,name,firstLastName,secondLastName,gender,birthday,registration_date,user,password,phone,mail) VALUES
	 (1,'343360bc78','Jose Efren','Prieto','Sanchez',1,'1977-02-08','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','6456291225',NULL),
	 (2,'b099f92abc','Eva','Sanchez','Cristo',0,'1990-07-18','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','9353719604',NULL),
	 (3,'e3a98ccbad','Cuauhtemoc','Arano','Moreno',1,'1983-08-02','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','9614054225',NULL),
	 (4,'76c978bbea','Eusebio Jose','Cruz','Aguirre',1,'1951-10-26','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','8483556600',NULL),
	 (5,'df36b4d9b4','Irving Eduardo','Espinoza','Calvo',1,'1988-05-26','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','4661090154',NULL),
	 (6,'41a11701d3','Jorge','Martinez','Camacho',1,'1983-04-21','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','2208706300',NULL),
	 (7,'b2ad528cf5','Israel','Godinez','Cuacua',1,'1987-11-14','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','0015611089',NULL),
	 (8,'ad3ea63b59','Gabriela','Ruiz','Guillen',0,'1992-08-21','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','0418256763',NULL),
	 (9,'3d30317575','Juan Antonio','Cruz','Olmedo',1,'1983-05-24','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','7806381469',NULL),
	 (10,'ea35855160','Salvador  Eder','Enriquez','Contreras',1,'1982-06-23','2023-01-13',NULL,'6e9cf3eef65da697796cf33f27eb0f57','4556939811',NULL);


INSERT INTO Teachers (idTeacher,credential,name,firstLastName,secondLastName,gender,birthday,registration_date,user,password,phone,mail) VALUES
	 (1,'bae24d8a9c','Aracely','Lozano','Zarate',0,'1980-08-17','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','0660032053',NULL),
	 (2,'be8e7d1deb','Heidi Lourdes','Cruz','Morales',0,'1979-05-14','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','7000449287',NULL),
	 (3,'a42be28e4e','Jose Alberto','Lara','Estevez',1,'1973-02-04','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','7068250753',NULL),
	 (4,'750757dace','Luis Felipe','Arceo','Gonzalez',1,'1980-06-21','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','1292723502',NULL),
	 (5,'2627a45a50','Ricardo Alberto','Hernandez','Jacome',1,'1989-06-12','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','0947492524',NULL),
	 (6,'f5268891fe','Jorge Alberto','Rosales','Orea',1,'1991-04-23','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','6367849201',NULL),
	 (7,'b17ddb56bc','Pedro','Ramirez','Mora',1,'1964-10-19','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','2461704874',NULL),
	 (8,'68697bcca4','Alfonso','Aguirre','De La Vega',1,'1978-08-08','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','9461752576',NULL),
	 (9,'7b0c39b437','Daniela','Rosales','Orea',0,'1993-06-09','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','7617957841',NULL),
	 (10,'44f27b32b2','Nahely Elizabeth','Nuñez','Palaceta',0,'1976-12-17','2023-01-13',NULL,'6d922fd4cbceb1561c5bde918bbf4bee','9585428563',NULL);